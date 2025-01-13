// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateImagePipelineRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of Alibaba Cloud accounts to which to share the image that will be created based on the image template. You can specify up to 20 account IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("AddAccount")]
        [Validation(Required=false)]
        public List<long?> AddAccount { get; set; }

        [NameInMap("AdvancedOptions")]
        [Validation(Required=false)]
        public CreateImagePipelineRequestAdvancedOptions AdvancedOptions { get; set; }
        public class CreateImagePipelineRequestAdvancedOptions : TeaModel {
            [NameInMap("RetainCloudAssistant")]
            [Validation(Required=false)]
            public bool? RetainCloudAssistant { get; set; }

        }

        /// <summary>
        /// <para>The source image.</para>
        /// <list type="bullet">
        /// <item><description>If you set <c>BaseImageType</c> to IMAGE, set the BaseImage parameter to the ID of a custom image.</description></item>
        /// <item><description>If you set <c>BaseImageType</c> to IMAGE_FAMILY, set the BaseImage parameter to the name of an image family.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>m-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("BaseImage")]
        [Validation(Required=false)]
        public string BaseImage { get; set; }

        /// <summary>
        /// <para>The type of the source image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IMAGE: image</description></item>
        /// <item><description>IMAGE_FAMILY: image family</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE</para>
        /// </summary>
        [NameInMap("BaseImageType")]
        [Validation(Required=false)]
        public string BaseImageType { get; set; }

        /// <summary>
        /// <para>The build content in the image template. The content cannot exceed 16 KB in size. For information about the commands supported by Image Builder, see <a href="https://help.aliyun.com/document_detail/200206.html">Commands supported by Image Builder</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FROM IMAGE:m-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("BuildContent")]
        [Validation(Required=false)]
        public string BuildContent { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.**** For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to release the intermediate instance when the image cannot be created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// <remarks>
        /// <para>If the intermediate instance cannot be started, the instance is released by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeleteInstanceOnFailure")]
        [Validation(Required=false)]
        public bool? DeleteInstanceOnFailure { get; set; }

        /// <summary>
        /// <para>The description of the image template. The description must be 2 to 256 characters in length. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The image family. The image family name must be 2 to 128 characters in length. The name must start with a letter and cannot start with acs: or aliyun. The name cannot contain http:// or https:// and can contain letters, digits, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// <para>The prefix of the image name. The prefix must be 2 to 64 characters in length. The prefix must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. The prefix can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <para>The system generates the final complete image name that consists of the specified prefix and the ID of the build task (<c>ExecutionId</c>) in the format of <c>{ImageName}_{ExecutionId}</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testImageName</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        [NameInMap("ImportImageOptions")]
        [Validation(Required=false)]
        public CreateImagePipelineRequestImportImageOptions ImportImageOptions { get; set; }
        public class CreateImagePipelineRequestImportImageOptions : TeaModel {
            [NameInMap("Architecture")]
            [Validation(Required=false)]
            public string Architecture { get; set; }

            [NameInMap("BootMode")]
            [Validation(Required=false)]
            public string BootMode { get; set; }

            [NameInMap("DiskDeviceMappings")]
            [Validation(Required=false)]
            public List<CreateImagePipelineRequestImportImageOptionsDiskDeviceMappings> DiskDeviceMappings { get; set; }
            public class CreateImagePipelineRequestImportImageOptionsDiskDeviceMappings : TeaModel {
                [NameInMap("DiskImageSize")]
                [Validation(Required=false)]
                public int? DiskImageSize { get; set; }

                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                [NameInMap("OSSBucket")]
                [Validation(Required=false)]
                public string OSSBucket { get; set; }

                [NameInMap("OSSObject")]
                [Validation(Required=false)]
                public string OSSObject { get; set; }

            }

            [NameInMap("Features")]
            [Validation(Required=false)]
            public CreateImagePipelineRequestImportImageOptionsFeatures Features { get; set; }
            public class CreateImagePipelineRequestImportImageOptionsFeatures : TeaModel {
                [NameInMap("NvmeSupport")]
                [Validation(Required=false)]
                public string NvmeSupport { get; set; }

            }

            [NameInMap("LicenseType")]
            [Validation(Required=false)]
            public string LicenseType { get; set; }

            [NameInMap("OSType")]
            [Validation(Required=false)]
            public string OSType { get; set; }

            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("RetainImportedImage")]
            [Validation(Required=false)]
            public bool? RetainImportedImage { get; set; }

        }

        /// <summary>
        /// <para>The instance type. You can call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query instance types.</para>
        /// <para>If you do not configure this parameter, an instance type that provides the fewest vCPUs and memory resources is automatically selected. This configuration is subject to resource availability of instance types. For example, the ecs.g6.large instance type is automatically selected. If available ecs.g6.large resources are insufficient, the ecs.g6.xlarge instance type is selected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The size of the outbound public bandwidth for the intermediate instance. Unit: Mbit/s. Valid values: 0 to 100.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>The name of the launch template. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. The name can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <remarks>
        /// <para> If you do not specify <c>Name</c>, the return value of <c>ImagePipelineId</c> is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testImagePipeline</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NvmeSupport")]
        [Validation(Required=false)]
        public string NvmeSupport { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The repair mode of the image template.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Standard: the standard mode.</para>
        /// <para>Supported check items in Linux operating systems:</para>
        /// <list type="bullet">
        /// <item><description>GUESTOS.CloudInit</description></item>
        /// <item><description>GUESTOS.Dhcp</description></item>
        /// <item><description>GUESTOS.Virtio</description></item>
        /// <item><description>GUESTOS.OnlineResizeFS</description></item>
        /// <item><description>GUESTOS.Grub</description></item>
        /// <item><description>GUESTOS.Fstab</description></item>
        /// </list>
        /// <para>Supported check items in Windows operating systems:</para>
        /// <list type="bullet">
        /// <item><description>GUESTOS.Virtio</description></item>
        /// <item><description>GUESTOS.Updat</description></item>
        /// <item><description>GUESTOS.Hotfix</description></item>
        /// <item><description>GUESTOS.Server</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> As the check and repair capabilities continue to improve, the number of check items may increase. For more information about check items, see <a href="https://help.aliyun.com/document_detail/439819.html">Overview of image check</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("RepairMode")]
        [Validation(Required=false)]
        public string RepairMode { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The system disk size of the intermediate instance. Unit: GiB. Valid values: 20 to 500.</para>
        /// <para>Default value: 40.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// <para>The tags to add to the template.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateImagePipelineRequestTag> Tag { get; set; }
        public class CreateImagePipelineRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N. Valid values of N: 1 to 20. You cannot specify empty strings as tag keys. The tag key must be 1 to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value must be 0 to 128 characters in length. It cannot start with <c>acs:</c> or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The test content in the image template. The content cannot exceed 16 KB in size. For information about the commands supported by Image Builder, see <a href="https://help.aliyun.com/document_detail/200206.html">Commands supported by Image Builder</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("TestContent")]
        [Validation(Required=false)]
        public string TestContent { get; set; }

        /// <summary>
        /// <para>The IDs of regions to which you want to distribute the image that is created based on the image template. You can specify up to 20 region IDs.</para>
        /// <para>If you do not specify this parameter, the image is created only in the current region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ToRegionId")]
        [Validation(Required=false)]
        public List<string> ToRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// <para>If you do not specify this parameter, a new VPC and vSwitch are created. Make sure that the VPC quota in your account is sufficient. For more information, see <a href="https://help.aliyun.com/document_detail/27750.html">Limits and quotas</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
