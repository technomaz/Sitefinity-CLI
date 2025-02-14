﻿using System;
using System.IO;

namespace Sitefinity_CLI
{
    public class Constants
    {
        public const string CLIName = "Sitefinity CLI";

        // Folder names
        public const string ResourcePackagesFolderName = "ResourcePackages";
        public const string MVCFolderName = "MVC";
        public const string ModuleFolderName = "Modules";
        public const string ControllersFolderName = "Controllers";
        public const string ViewsFolderName = "Views";
        public const string ScriptsFolderName = "Scripts";
        public const string ModelsFolderName = "Models";
        public const string TemplatesFolderName = "Templates";
        public const string ResourcePackageTemplatesFolderName = "ResourcePackage";
        public const string GridWidgetTemplatesFolderName = "GridWidget";
        public const string PageTemplateTemplatesFolderName = "PageTemplate";
        public const string CustomWidgetTemplatesFolderName = "CustomWidget";
        public const string ModuleTemplatesFolderName = "Module";
        public const string IntegrationTestsTemplateFolderName = "IntegrationTests";
        public const string IntegrationTestsFolderName = "SitefinityWebApp.Tests.Integration";
        public const string AssemblyInfoFileName = "AssemblyInfo";
        public const string IntegrationTestClassName = "DemoTests";
        public const string PackagesFileName = "packages";
        public const string CsProjTemplateName = "csproj";
        public const string PackagesFolderName = "packages";
        public const string LicenseAgreementsFolderName = "LicenseAgreements";

        // Paths
        public static string PageTemplatesPath = Path.Combine("MVC", "Views", "Layouts");
        public static string GridWidgetPath = Path.Combine("GridSystem", "Templates");

        // Error messages
        public const string DirectoryNotFoundMessage = "Directory not found. Path: \"{0}\"";
        public const string FileExistsMessage = "File \"{0}\" already exists. Path: \"{1}\"";
        public const string TemplateNotFoundMessage = "The {0} you want to replicate is not found. Path: \"{1}\"";
        public const string ResourceExistsMessage = "{0} with name {1} already exists. Path: \"{2}\"";
        public const string ProjectNotFound = "Unable to find csproj file";
        public const string SolutionNotFoundMessage = "Unable to find sln file";
        public const string ConfigFileNotCreatedMessage = "Unable to create configuration file! Path: \"{0}\"";
        public const string ConfigFileNotCreatedPermissionsMessage = "Insufficient permissions to create configuration file! Path: \"{0}\"";
        public const string FileNotFoundMessage = "File \"{0}\" not found";
        public const string FileIsNotSolutionMessage = "File \"{0}\" is not a sln file";
        public const string ErrorOccuredWhileCreatingItemFromTemplate = "An error occured while creating an item from template. Path: {0}";
        public const string VersionNotFound = "Version: {0} was not found in https://nuget.sitefinity.com";
        public const string VersionIsGreaterThanOrEqual = "{0} Sitefinity version ({1}) is >= than the version you are trying to upgrade to ({2})";

        // Warning messages
        public const string EnterResourcePackagePromptMessage = "Enter the name of the resource package where the resource should be added:";
        public const string SourceTemplatePromptMessage = "Enter the name of the {0} you want to replicate:";
        public const string HigherSitefinityVersionMessage = "Your version of Sitefinity CLI creates files compatible with Sitefinity CMS {1}. There may be inconsistencies with your project version - {0}";
        public const string ProducedFilesVersionMessage = "Created files are compatible with Sitefinity CMS version {0}";
        public const string SitefinityNotRecognizedMessage = "Cannot recognize project as Sitefinity CMS. Do you wish to proceed?";
        public const string AddFilesToProjectMessage = "The file(s) should be added to the project manually.";
        public const string FilesAddedToProjectMessage = "The file(s) are added to the project successfully.";
        public const string AddFilesInsufficientPrivilegesMessage = "Insufficient privileges to add the file(s) to the project.";
        public const string AddFilesToSolutionFailureMessage = "File \"{0}\" unable to be added to solution!";
        public const string SolutionNotReadable = "Unable to read solution";
        public const string NoProjectsFoundToUpgradeWarningMessage = "No projects with Sitefinity references found to upgrade.";
        public const string AcceptLicenseNotification = "Do you accept the terms and conditions";
        public const string UpgradeWarning = "Make sure to have your project under source control. Currently there is no revert mechanism in the upgrade tool. The upgrade will launch visual studio instance in order to execute nuget upgrade. DO NOT CLOSE the opened visual studio. This will stop the upgrade. Do you want to continue?";
        public const string SettingExecutionPolicyMessage = "Setting the execution polity for the curren process to unrestricted!";
        public static string UpgradeSuccessMessage = "Successfully updated '{0}' to version '{1}'." + Environment.NewLine + "Make sure to REBUILD your solution before starting up the site!";

        // Success messages
        public const string ConfigFileCreatedMessage = "Configuration file created successfully! Path: \"{0}\"";
        public const string CustomWidgetCreatedMessage = "Custom widget \"{0}\" created!";
        public const string FileCreatedMessage = "File \"{0}\" created! Path: \"{1}\"";
        public const string ResourcePackageCreatedMessage = "Resource package \"{0}\" created! Path: \"{1}\"";
        public const string ModuleCreatedMessage = "Module \"{0}\" created!";
        public const string IntegrationTestsCreatedMessage = "Integration tests project \"{0}\" created!";
        public const string AddFilesToSolutionSuccessMessage = "File \"{0}\" succesfully added to solution!";
        public const string NumberOfProjectsWithSitefinityReferencesFoundSuccessMessage = "{0} projects with Sitefinity references found";
        public const string StartUpgradeSuccessMessage = "Starting upgrade of project \"{0}\"...";
        public const string UpgradeWasCanceled = "The upgrade was canceled.";
        public const string TargetFrameworkChanged = "Target framework for {0} set to {1}";
        public const string TargetFrameworkDoesNotNeedChanged = "Target framework for {0} does not need change ({1})";

        // Descriptions
        public const string TemplateNameOptionDescription = "The name of the file you want to replicate. Default value: ";
        public const string DescriptionOptionDescription = "The description of your module";
        public const string ResourcePackageOptionDescription = "The name of the resource package where you want to add the generated resource. Default value: ";
        public const string ProjectRoothPathOptionDescription = "The path to the root of the project where the command will execute.";
        public const string VersionOptionDescription = "Sitefinity version which is compatible with the resource you want to generate.";
        public const string NameArgumentDescription = "The name of the resource you want to add to the current project.";
        public const string TemplateNameOptionTemplate = "-t|--template";
        public const string DescriptionOptionTemplate = "-d|--description";
        public const string ProjectOrSolutionPathOptionDescription = "The path to the project or solution where Sitefinity is installed.";
        public const string VersionToOptionDescription = "The Sitefinity version to upgrade to.";
        public const string VersionForUpgradeOptionDescription = "The Sitefinity version to upgrade to. If omitted, the latest available Sitefinity version is used.";
        public const string SourceForUpgradeOptionDescription = "Specifies the list of package sources (as URLs) to use for the updates. If omitted, the command uses the sources provided in configuration files.";
        public const string SkipPromptsDescription = "If you use this option you will skip all warning prompts.";
        public const string AcceptLicenseOptionDescription = "If you use this option you will automatically accept the licence of the version you are upgrading to. You can later on find the license text in the LicenseAgreement folder of a sitefinity package. If you don't agree to any of the terms in the license you must uninstall the product!";
        public const string PackageSourcesDescription = "Provide the nuget package sources used to install the new version of sitefinity";
        public const string VersionOptionTemplate = "-v|--version";
        public const string SourceOptionTemplate = "-s|--source";
        public const string SkipPrompts = "--skipPrompts";
        public const string AcceptLicense = "--acceptLicense";
        public const string PackageSources = "-ps|--packageSources";

        // File extensions
        public const string RazorFileExtension = ".cshtml";
        public const string HtmlFileExtension = ".html";
        public const string CSharpFileExtension = ".cs";
        public const string VBFileExtension = ".vb";
        public const string JavaScriptFileExtension = ".js";
        public const string CsprojFileExtension = ".csproj";
        public const string SlnFileExtension = ".sln";
        public const string ConfigFileExtension = ".config";
        public const string VBProjFileExtension = ".vbproj";

        // Command names
        public const string AddCommandName = "add";
        public const string AddResourcePackageCommandName = "package";
        public const string AddResourcePackageCommandFullName = "Resource package";
        public const string AddPageTemplateCommandName = "pagetemplate";
        public const string AddPageTemplateCommandFullName = "Page template";
        public const string AddGridWidgetCommandName = "gridwidget";
        public const string AddGridWidgetCommandFullName = "Grid widget";
        public const string AddCustomWidgetCommandName = "widget";
        public const string AddCustomWidgetCommandFullName = "Widget";
        public const string AddModuleCommandName = "module";
        public const string AddModuleCommandFullName = "Module project";
        public const string AddIntegrationTestsCommandName = "tests";
        public const string AddIntegrationTestsCommandFullName = "Integration tests project";
        public const string GenerateConfigCommandName = "config";
        public const string UpgradeCommandName = "upgrade";

        public const string DefaultResourcePackageName_VersionsBefore12_0 = "Bootstrap";
        public const string DefaultResourcePackageName = "Bootstrap4";
        public const string DefaultGridWidgetName = "grid-6+6";
        public const string DefaultSourceTemplateName = "Default";

        // Csproj editor constants
        public const string ItemGroupElem = "ItemGroup";
        public const string CompileElem = "Compile";
        public const string ReferenceElem = "Reference";
        public const string NoneElem = "None";
        public const string ContentElem = "Content";
        public const string ProjectElem = "Project";
        public const string HintPathElem = "HintPath";
        public const string TargetFrameworkVersionElem = "TargetFrameworkVersion";
        public const string IncludeAttribute = "Include";
        public const string XmlnsAttribute = "xmlns";

        // Packages config editor constants
        public const string PackagesElem = "packages";
        public const string PackageElem = "package";
        public const string IdAttribute = "id";
        public const string VersionAttribute = "version";
        public const string PackagesConfigFileName = "packages.config";

        // Sitefinity package management
        public const string SitefinityAllNuGetPackageId = "Telerik.Sitefinity.All";
        public const string EntryElem = "entry";
        public const string PropertiesElem = "properties";
        public const string DependenciesElem = "Dependencies";
        public const string VersionElem = "Version";
        public const string TitleElem = "title";
        public const string TelerikSitefinityReferenceKeyWords = "Telerik.Sitefinity";
        public const string ProgressSitefinityReferenceKeyWords = "Progress.Sitefinity";
        public const string ProgressSitefinityRendererReferenceKeyWords = "Progress.Sitefinity.Renderer";
        public const string SitefinityUpgradePowershellFolderName = "PowerShell";
        public const string SitefinityPublicKeyToken = "b28c218413bdf563";
    }
}
