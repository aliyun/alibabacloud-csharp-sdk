// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateImageShrinkRequest : TeaModel {
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
        /// <para>The ACR instance ID. This parameter is required when referencing an ACR image.</para>
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
        public string BuildConfigShrink { get; set; }

        /// <summary>
        /// <para>The client idempotency token.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dasfsd-94fqwe-da8d</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The image description, up to 128 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create by xxxx</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to synchronize the image to MaxCompute. Specify this parameter when referencing an ACR image. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSyncMaxCompute")]
        [Validation(Required=false)]
        public bool? EnableSyncMaxCompute { get; set; }

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
        /// <para>The image name, which can contain lowercase letters, digits, and underscores (_), up to 128 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task_image_001</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The image namespace. Set this parameter to DataWorks Default when referencing a DataWorks official image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespace_name</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The image ID from the image provider. This parameter is required when referencing a DataWorks official image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>System_shell_20251201</para>
        /// </summary>
        [NameInMap("ProviderImageId")]
        [Validation(Required=false)]
        public string ProviderImageId { get; set; }

        /// <summary>
        /// <para>The image reference data type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ACR: ACR image repository.</description></item>
        /// <item><description>DataWorks: DataWorks official image.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACR</para>
        /// </summary>
        [NameInMap("ProviderType")]
        [Validation(Required=false)]
        public string ProviderType { get; set; }

        /// <summary>
        /// <para>The image repository name. Set this parameter to DataWorks Default when referencing a DataWorks official image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>repo_name</para>
        /// </summary>
        [NameInMap("RepositoryName")]
        [Validation(Required=false)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// <para>The image sub-purpose.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Supported")]
        [Validation(Required=false)]
        public string SupportedShrink { get; set; }

    }

}
