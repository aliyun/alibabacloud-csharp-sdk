// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class BuildPipeline : TeaModel {
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        [NameInMap("BuildConfig")]
        [Validation(Required=false)]
        public BuildPipelineBuildConfig BuildConfig { get; set; }
        public class BuildPipelineBuildConfig : TeaModel {
            [NameInMap("BeforeBuildCommand")]
            [Validation(Required=false)]
            public string BeforeBuildCommand { get; set; }

            [NameInMap("BuildType")]
            [Validation(Required=false)]
            public string BuildType { get; set; }

            [NameInMap("DockerfilePath")]
            [Validation(Required=false)]
            public string DockerfilePath { get; set; }

            [NameInMap("RunCommand")]
            [Validation(Required=false)]
            public string RunCommand { get; set; }

            [NameInMap("RuntimeType")]
            [Validation(Required=false)]
            public string RuntimeType { get; set; }

            [NameInMap("RuntimeVersion")]
            [Validation(Required=false)]
            public string RuntimeVersion { get; set; }

            [NameInMap("TomcatConfig")]
            [Validation(Required=false)]
            public TomcatConfig TomcatConfig { get; set; }

            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

        }

        [NameInMap("CodeConfig")]
        [Validation(Required=false)]
        public BuildPipelineCodeConfig CodeConfig { get; set; }
        public class BuildPipelineCodeConfig : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("BranchName")]
            [Validation(Required=false)]
            public string BranchName { get; set; }

            [NameInMap("CommitId")]
            [Validation(Required=false)]
            public string CommitId { get; set; }

            [NameInMap("CommitUrl")]
            [Validation(Required=false)]
            public string CommitUrl { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            [NameInMap("Provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            [NameInMap("RepoFullName")]
            [Validation(Required=false)]
            public string RepoFullName { get; set; }

            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

        }

        [NameInMap("DeployConfig")]
        [Validation(Required=false)]
        public BuildPipelineDeployConfig DeployConfig { get; set; }
        public class BuildPipelineDeployConfig : TeaModel {
            [NameInMap("AlwaysAllocateCPU")]
            [Validation(Required=false)]
            public bool? AlwaysAllocateCPU { get; set; }

            [NameInMap("MaximumInstanceCount")]
            [Validation(Required=false)]
            public int? MaximumInstanceCount { get; set; }

            [NameInMap("MinimumInstanceCount")]
            [Validation(Required=false)]
            public int? MinimumInstanceCount { get; set; }

            [NameInMap("UpdateApplicationInput")]
            [Validation(Required=false)]
            public string UpdateApplicationInput { get; set; }

        }

        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("ImageConfig")]
        [Validation(Required=false)]
        public BuildPipelineImageConfig ImageConfig { get; set; }
        public class BuildPipelineImageConfig : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("Repository")]
            [Validation(Required=false)]
            public string Repository { get; set; }

        }

        [NameInMap("PackageConfig")]
        [Validation(Required=false)]
        public BuildPipelinePackageConfig PackageConfig { get; set; }
        public class BuildPipelinePackageConfig : TeaModel {
            [NameInMap("PackageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }

            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            [NameInMap("PackageUrl")]
            [Validation(Required=false)]
            public string PackageUrl { get; set; }

            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public string PackageVersion { get; set; }

        }

        [NameInMap("TriggerConfig")]
        [Validation(Required=false)]
        public BuildPipelineTriggerConfig TriggerConfig { get; set; }
        public class BuildPipelineTriggerConfig : TeaModel {
            [NameInMap("BranchName")]
            [Validation(Required=false)]
            public string BranchName { get; set; }

            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
