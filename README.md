# Portfolio – ASP.NET Core MVC

A clean, minimal portfolio website for showcasing MIT projects.

## Requirements
- [.NET 8 SDK](https://dotnet.microsoft.com/download)

## Running locally

```bash
cd portfolio
dotnet run
```

Then open `https://localhost:5001` in your browser.

---

## Personalising the site

### 1. Update your name and bio
Edit `Views/Shared/_Layout.cshtml` — change `Your Name` in the `<title>` and nav logo.
Edit `Views/Home/Index.cshtml` — update:
- `Your Name` in the hero
- The About Me paragraphs
- Your email, LinkedIn, and GitHub links in the Contact section
- The skill tags in the About section

### 2. Add your projects
Edit `Models/ProjectData.cs`. Each `Project` object has:
| Field | Purpose |
|---|---|
| `Slug` | URL-friendly ID, e.g. `"iphone-app"` |
| `Title` | Displayed name |
| `ShortDescription` | One-liner shown on the home page card |
| `FullDescription` | Multi-paragraph text on the detail page (use `\n\n` between paragraphs) |
| `GitHubUrl` | Full URL to the GitHub repo |
| `TechStack` | Comma-separated list of technologies |
| `Features` | Bullet points shown in the sidebar |
| `CoverImage` | Path to the card thumbnail, e.g. `/images/projects/iphone-app/cover.png` |
| `ImagePaths` | List of screenshot paths shown in the gallery |

### 3. Add your images

Place images inside `wwwroot/images/projects/<slug>/`.

**For the iPhone app**, for example:
```
wwwroot/
  images/
    projects/
      iphone-app/
        cover.png      ← card thumbnail (landscape, ~16:9)
        screen1.png    ← portrait screenshot
        screen2.png
        screen3.png
```

**Tip for iPhone screenshots:** portrait images automatically display with a 9:16 aspect ratio in the gallery, which looks great for phone screenshots. Just drop them in and they'll look right.

Cover images work best at **800×450px** (16:9 landscape). Screenshots can be any size — the gallery handles them.

### 4. Add your profile photo
Replace the "Your Photo" placeholder in the About section:
1. Add your photo to `wwwroot/images/profile.jpg`
2. In `Views/Home/Index.cshtml`, replace:
```html
<div class="about-photo-placeholder">
    <span>Your Photo</span>
</div>
```
with:
```html
<img src="/images/profile.jpg" alt="Your Name" />
```

---

## Project structure

```
portfolio/
├── Controllers/
│   ├── HomeController.cs        — serves the home page
│   └── ProjectController.cs     — serves individual project pages
├── Models/
│   ├── Project.cs               — data model
│   └── ProjectData.cs           — all your project content lives here
├── Views/
│   ├── Home/Index.cshtml        — home page (hero, about, project grid, contact)
│   ├── Project/Detail.cshtml    — individual project page with gallery
│   └── Shared/_Layout.cshtml    — nav + footer wrapper
└── wwwroot/
    ├── css/site.css             — all styles
    ├── js/site.js               — lightbox + nav highlighting
    └── images/projects/         — your screenshots go here
```

## URLs
| Page | URL |
|---|---|
| Home | `/` |
| Project detail | `/project/detail/<slug>` |

---

## Deploying
This is a standard ASP.NET Core 8 app and can be deployed to:
- **Azure App Service** — push to GitHub, connect to Azure
- **Railway / Render** — Dockerfile not required, they detect .NET
- **Self-hosted** — `dotnet publish -c Release` and serve with Nginx/Kestrel
