// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyImageAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The new boot mode of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BIOS: Basic Input/Output System (BIOS)</description></item>
        /// <item><description>UEFI: Unified Extensible Firmware Interface (UEFI)</description></item>
        /// <item><description>UEFI-Preferred: BIOS and UEFI</description></item>
        /// </list>
        /// <remarks>
        /// <para> Before you change the boot mode, we recommend that you obtain the boot modes supported by the image. If you specify an unsupported boot mode for the image, ECS instances that use the image cannot start as expected. If you do not know which boot modes are supported by the image, we recommend that you use the image check feature to perform a check. For information about the image check feature, see <a href="https://help.aliyun.com/document_detail/439819.html">Overview</a>.</para>
        /// </remarks>
        /// <remarks>
        /// <para> For information about the UEFI-Preferred boot mode, see <a href="https://help.aliyun.com/document_detail/2244655.html">Best practices for ECS instance boot modes</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>BIOS</para>
        /// </summary>
        [NameInMap("BootMode")]
        [Validation(Required=false)]
        public string BootMode { get; set; }

        /// <summary>
        /// <para>The new description of the custom image. The description must be 2 to 256 characters in length It cannot start with <a href="http://https://%E3%80%82">http:// or https://.</a></para>
        /// <para>This parameter is empty by default, which specifies that the original description is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The attributes of the custom image.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public ModifyImageAttributeRequestFeatures Features { get; set; }
        public class ModifyImageAttributeRequestFeatures : TeaModel {
            /// <summary>
            /// <para>Specifies whether to support the Non-Volatile Memory Express (NVMe) protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>supported: The image supports NVMe. Instances created from this image also support NVMe.</description></item>
            /// <item><description>unsupported: The image does not support NVMe. Instances created from this image do not support NVMe.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>supported</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("NvmeSupport")]
            [Validation(Required=false)]
            public string NvmeSupport { get; set; }

        }

        /// <summary>
        /// <para>The name of the image family. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with acs: or aliyun. <a href="http://https://%E3%80%82%E3%80%81%EF%BC%88.%EF%BC%89%E3%80%81%EF%BC%88:%EF%BC%89%E3%80%81%EF%BC%88_%EF%BC%89%EF%BC%88-%EF%BC%89%E3%80%82">It cannot contain http:// or https://. It can contain letters, digits, periods (.), colons (:), underscores (_), and hyphens (-).</a></para>
        /// <para>By default, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou-daily-update</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// <para>The ID of the custom image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-bp18ygjuqnwhechc****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The name of the custom image. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with acs: or aliyun. <a href="http://https://%E3%80%82%E3%80%81%EF%BC%88.%EF%BC%89%E3%80%81%EF%BC%88:%EF%BC%89%E3%80%81%EF%BC%88_%EF%BC%89%EF%BC%88-%EF%BC%89%E3%80%82">It cannot contain http:// or https://. It can contain letters, digits, periods (.), colons (:), underscores (_), and hyphens (-).</a></para>
        /// <para>By default, this parameter is empty. In this case, the original name is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testImageName</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The type of the license that is used to activate the operating system after the image is imported. Set the value to BYOL.</para>
        /// <para>BYOL: The license that comes with the source operating system is used. When you use the BYOL license, make sure that your license key is supported by Alibaba Cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Auto</para>
        /// </summary>
        [NameInMap("LicenseType")]
        [Validation(Required=false)]
        public string LicenseType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the custom image. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The new state of the custom image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Deprecated: puts the image into the Deprecated state. If the custom image is shared, you must unshare it before you can put it into the Deprecated state. Images in the Deprecated state cannot be shared or copied, but can be used to create instances or replace system disks.</description></item>
        /// <item><description>Available: puts the image into the Available state. You can restore an image from the Deprecated state to the Available state.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you want to roll back a custom image in the image family to a previous version, you can put the latest available custom image into the Deprecated state. If no custom images are in the Available state within the image family, an image family cannot be used to create instances. Proceed with caution if only a single custom image is in the Available state within the image family.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Deprecated</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
