// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateImageShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Public: The image is visible to all users.</description></item>
        /// <item><description>Private: The image is visible only to the creator.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) associated with the ACR instance. This parameter is required if you reference an ACR image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxx</para>
        /// </summary>
        [NameInMap("AcrAssociatedVpcId")]
        [Validation(Required=false)]
        public string AcrAssociatedVpcId { get; set; }

        /// <summary>
        /// <para>The ACR instance ID. This parameter is required if you reference an ACR image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acr_instance_id</para>
        /// </summary>
        [NameInMap("AcrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>The build configuration of the image.</para>
        /// </summary>
        [NameInMap("BuildConfig")]
        [Validation(Required=false)]
        public string BuildConfigShrink { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure idempotence.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dasfsd-94fqwe-da8d</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the image. The description can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create by xxxx</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to synchronize the image to MaxCompute. Specify this parameter when you reference an ACR image. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSyncMaxCompute")]
        [Validation(Required=false)]
        public bool? EnableSyncMaxCompute { get; set; }

        /// <summary>
        /// <para>The URI of the image. This parameter is required if you reference an ACR image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry-vpc.cn-beijing.cr.aliyuncs.com/namespace/image:0.1.0</para>
        /// </summary>
        [NameInMap("ImageUri")]
        [Validation(Required=false)]
        public string ImageUri { get; set; }

        /// <summary>
        /// <para>The name of the image. The name can contain lowercase letters, digits, and underscores (_), and can be up to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task_image_001</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The namespace of the image. If you reference a DataWorks official image, set this parameter to DataWorks Default.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespace_name</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The ID of the image provided by the image provider. This parameter is required if you reference a DataWorks official image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>System_shell_20251201</para>
        /// </summary>
        [NameInMap("ProviderImageId")]
        [Validation(Required=false)]
        public string ProviderImageId { get; set; }

        /// <summary>
        /// <para>The reference data type of the image. Valid values:</para>
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
        /// <para>The name of the image repository. If you reference a DataWorks official image, set this parameter to DataWorks Default.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>repo_name</para>
        /// </summary>
        [NameInMap("RepositoryName")]
        [Validation(Required=false)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// <para>The sub-purpose of the image.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Supported")]
        [Validation(Required=false)]
        public string SupportedShrink { get; set; }

    }

}
