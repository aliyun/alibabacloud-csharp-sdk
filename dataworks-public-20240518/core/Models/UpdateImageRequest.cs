// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateImageRequest : TeaModel {
        /// <summary>
        /// <para>The image visibility. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Public: visible to all users.</description></item>
        /// <item><description>Private: visible only to the creator.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The VPC ID associated with the ACR instance. This parameter is required when referencing an ACR image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxx</para>
        /// </summary>
        [NameInMap("AcrAssociatedVpcId")]
        [Validation(Required=false)]
        public string AcrAssociatedVpcId { get; set; }

        /// <summary>
        /// <para>The Container Registry (ACR) instance ID. This parameter is required when referencing an ACR image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acr_instance_id</para>
        /// </summary>
        [NameInMap("AcrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>The image build configuration.</para>
        /// </summary>
        [NameInMap("BuildConfig")]
        [Validation(Required=false)]
        public UpdateImageRequestBuildConfig BuildConfig { get; set; }
        public class UpdateImageRequestBuildConfig : TeaModel {
            /// <summary>
            /// <para>The build type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PackageInstallation</para>
            /// </summary>
            [NameInMap("BuildType")]
            [Validation(Required=false)]
            public string BuildType { get; set; }

            /// <summary>
            /// <para>The list of pre-installation scripts.</para>
            /// </summary>
            [NameInMap("PackageInstallationScripts")]
            [Validation(Required=false)]
            public List<UpdateImageRequestBuildConfigPackageInstallationScripts> PackageInstallationScripts { get; set; }
            public class UpdateImageRequestBuildConfigPackageInstallationScripts : TeaModel {
                /// <summary>
                /// <para>The script content. If the content consists of package names, separate them with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>requests</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The script type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Python3</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The image description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create by xxxx</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom_image_xxxx_xxxx</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The image URI. This parameter is required when referencing an ACR image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry-vpc.cn-beijing.cr.aliyuncs.com/namespace/image:0.1.0</para>
        /// </summary>
        [NameInMap("ImageUri")]
        [Validation(Required=false)]
        public string ImageUri { get; set; }

        /// <summary>
        /// <para>The image name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task_image_001</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The image namespace. Set this parameter to DataWorks Default when referencing a DataWorks official image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespace_name</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The provider image ID. This parameter is required when referencing a DataWorks official image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>System_shell_20251201</para>
        /// </summary>
        [NameInMap("ProviderImageId")]
        [Validation(Required=false)]
        public string ProviderImageId { get; set; }

        /// <summary>
        /// <para>The image repository name. Set this parameter to DataWorks Default when referencing a DataWorks official image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>repo_name</para>
        /// </summary>
        [NameInMap("RepositoryName")]
        [Validation(Required=false)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// <para>The image sub-purpose.</para>
        /// </summary>
        [NameInMap("Supported")]
        [Validation(Required=false)]
        public UpdateImageRequestSupported Supported { get; set; }
        public class UpdateImageRequestSupported : TeaModel {
            /// <summary>
            /// <para>The image sub-module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Scheduler: data development.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduler</para>
            /// </summary>
            [NameInMap("Module")]
            [Validation(Required=false)]
            public string Module { get; set; }

            /// <summary>
            /// <para>The list of node types supported by the image.</para>
            /// </summary>
            [NameInMap("TaskTypes")]
            [Validation(Required=false)]
            public List<string> TaskTypes { get; set; }

        }

    }

}
