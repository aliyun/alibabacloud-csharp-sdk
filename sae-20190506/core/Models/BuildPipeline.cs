// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class BuildPipeline : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BuildConfig")]
        [Validation(Required=false)]
        public BuildPipelineBuildConfig BuildConfig { get; set; }
        public class BuildPipelineBuildConfig : TeaModel {
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
            /// <b>Example:</b>
            /// <para>code</para>
            /// </summary>
            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CodeConfig")]
        [Validation(Required=false)]
        public BuildPipelineCodeConfig CodeConfig { get; set; }
        public class BuildPipelineCodeConfig : TeaModel {
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

            [NameInMap("UpdateTraffic")]
            [Validation(Required=false)]
            public bool? UpdateTraffic { get; set; }

        }

        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("ImageConfig")]
        [Validation(Required=false)]
        public BuildPipelineImageConfig ImageConfig { get; set; }
        public class BuildPipelineImageConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ACR/ACREE</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>war/jar/zip</para>
            /// </summary>
            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://myoss.oss-cn-****.aliyuncs.com/my-buc/2019-06-30/****.jar">http://myoss.oss-cn-****.aliyuncs.com/my-buc/2019-06-30/****.jar</a></para>
            /// </summary>
            [NameInMap("PackageUrl")]
            [Validation(Required=false)]
            public string PackageUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public string PackageVersion { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TriggerConfig")]
        [Validation(Required=false)]
        public BuildPipelineTriggerConfig TriggerConfig { get; set; }
        public class BuildPipelineTriggerConfig : TeaModel {
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

    }

}
