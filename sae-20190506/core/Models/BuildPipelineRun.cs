// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class BuildPipelineRun : TeaModel {
        [NameInMap("BuildConfig")]
        [Validation(Required=false)]
        public BuildPipelineRunBuildConfig BuildConfig { get; set; }
        public class BuildPipelineRunBuildConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>mvn clean package</para>
            /// </summary>
            [NameInMap("BeforeBuildCommand")]
            [Validation(Required=false)]
            public string BeforeBuildCommand { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>buildpacks/dockerfile</para>
            /// </summary>
            [NameInMap("BuildType")]
            [Validation(Required=false)]
            public string BuildType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>code/Dockerfile</para>
            /// </summary>
            [NameInMap("DockerfilePath")]
            [Validation(Required=false)]
            public string DockerfilePath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>java -jar target/app.jar</para>
            /// </summary>
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

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Trigger")]
            [Validation(Required=false)]
            public BuildPipelineRunBuildConfigTrigger Trigger { get; set; }
            public class BuildPipelineRunBuildConfigTrigger : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>master</para>
                /// </summary>
                [NameInMap("BranchName")]
                [Validation(Required=false)]
                public string BranchName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PUSH</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>code</para>
            /// </summary>
            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

        }

        [NameInMap("BuildDuration")]
        [Validation(Required=false)]
        public long? BuildDuration { get; set; }

        [NameInMap("CodeConfig")]
        [Validation(Required=false)]
        public BuildPipelineRunCodeConfig CodeConfig { get; set; }
        public class BuildPipelineRunCodeConfig : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
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

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>github/gitee/gitlab等</para>
            /// </summary>
            [NameInMap("Provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sae-samples/java-maven-demo</para>
            /// </summary>
            [NameInMap("RepoFullName")]
            [Validation(Required=false)]
            public string RepoFullName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3001</para>
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

        }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("DeployConfig")]
        [Validation(Required=false)]
        public BuildPipelineRunDeployConfig DeployConfig { get; set; }
        public class BuildPipelineRunDeployConfig : TeaModel {
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

            [NameInMap("UpdateTraffic")]
            [Validation(Required=false)]
            public bool? UpdateTraffic { get; set; }

        }

        [NameInMap("DeployDuration")]
        [Validation(Required=false)]
        public long? DeployDuration { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("ImageConfig")]
        [Validation(Required=false)]
        public BuildPipelineRunImageConfig ImageConfig { get; set; }
        public class BuildPipelineRunImageConfig : TeaModel {
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
        public BuildPipelineRunPackageConfig PackageConfig { get; set; }
        public class BuildPipelineRunPackageConfig : TeaModel {
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

        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        [NameInMap("PipelineRunId")]
        [Validation(Required=false)]
        public string PipelineRunId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Steps")]
        [Validation(Required=false)]
        public List<BuildPipelineRunSteps> Steps { get; set; }
        public class BuildPipelineRunSteps : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("TriggerConfig")]
        [Validation(Required=false)]
        public BuildPipelineRunTriggerConfig TriggerConfig { get; set; }
        public class BuildPipelineRunTriggerConfig : TeaModel {
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

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        [NameInMap("WaitDuration")]
        [Validation(Required=false)]
        public long? WaitDuration { get; set; }

    }

}
