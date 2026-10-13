namespace portfolio.Models;

public static class ProjectData
{
    public static List<Project> GetAll() => new()
    {
        new Project
        {
            Id = 1,
            Slug = "iphone-app",
            Title = "iOS Fitness Tracker",
            ShortDescription = "A native iPhone app built with Swift that tracks and encourages daily workouts",
            FullDescription = @"This iOS application was developed as part of the Master of Information Technology program, focusing on mobile development best practices and user-centred design.

The app allows users to follow and log daily workouts, for users who want to start including exercising in their daily routine. Offers a reward system where points from completed task can be used to feed pet. As well as a feature to provide information on exerises in specific areas.

The project involved designing a clean, intuitive UI that follows Apple's Human Interface Guidelines, implementing local data persistence with Core Data, and building a RESTful API integration for cloud sync. Also includes user account creation and authentication via Firebase",
            GitHubUrl = "https://github.com/gemkrairiksh/fitventure-ios",
            TechStack = "Swift, SwiftUI, Xcode, Firebase Authentication, Firebase Firestore, Exercise API",
            Category = "IPhone Software Engineering",
            Features = new List<string>
            {
                "Gamified daily workout plans with progressive difficulty (running, full body exercises)",
                "Exercise movements generated via third-party Exercise API",
                "Built-in workout timer with automatic rest/break intervals",
                "User authentication and account creation via Firebase (email sign-up)",
                "Virtual pet system — earn points from workouts to feed, level up and buy new pets",
                "Pet health and happiness tracked based on workout consistency"

            },
            // Place your screenshots in wwwroot/images/projects/iphone-app/
            // e.g. screen1.png, screen2.png, screen3.png
            ImagePaths = new List<string>
            {
                //"/images/projects/iphone-app/screen1.png",
                "/images/projects/iphone-app/screen2.png",
                "/images/projects/iphone-app/screen3.png",
                "/images/projects/iphone-app/screen4.png"
            },
            CoverImage = "/images/projects/iphone-app/cover.png"
        },
        new Project
        {
            Id = 2,
            Slug = "ml-thesis",
            Title = "Credit Risk Prediction using Explainable Machine Learning",
            ShortDescription = "A Comparative Analysis using SHAP and LIME",
            FullDescription = @"This study examines whether complex machine learning models are meaningfully more accurate
than interpretable models for credit risk prediction, and evaluates the reliability of post-hoc explanation
tools as a transparency solution. Six classification models were trained on the Home Credit Default Risk
dataset and evaluated using standard credit risk metrics. SHAP and LIME were applied to the three
black-box models and assessed on feature attribution consistency, stability, and fidelity. Additionally,
feature selection and hyperparameter tuning were applied to evaluate whether a reduced, optimised model
can match full-feature performance.",
            GitHubUrl = "https://github.com/gemkrairiksh-pk/Credit-Risk-using-Explainable-Machine-Learning.git",
            TechStack = "Python, Scikit-learn, XGBoost, LightGBM, SHAP (TreeSHAP), LIME, Pandas, NumPy, Matplotlib, Seaborn, Jupyter Notebook",
            Category = "Machine Learning",
            Features = new List<string>
            {
                "Compared 6 models: Logistic Regression, Decision Tree, Scorecard, Random Forest, XGBoost, LightGBM",
    "LightGBM achieved best AUC-ROC (0.7616); logistic regression trailed by only 0.0144",
    "SHAP (TreeSHAP) demonstrated near-perfect inter-model agreement (Spearman 0.98)",
    "LIME exhibited low stability (0.54–0.64) and very low fidelity (R² 0.18–0.37)",
    "Reduced 40-feature model achieved AUC within 0.001 of full 72-feature baseline",
    "Dataset: Home Credit Default Risk (307,511 observations, Kaggle)"
            },
            ImagePaths = new List<string>
            {
                "/images/projects/data-pipeline/model_comparison.png",
                "/images/projects/data-pipeline/shap_summary_lgbm.png"
            },
            CoverImage = "/images/projects/data-pipeline/model_comparison.png" 
        }
    };

    public static Project? GetBySlug(string slug) =>
        GetAll().FirstOrDefault(p => p.Slug == slug);
}
