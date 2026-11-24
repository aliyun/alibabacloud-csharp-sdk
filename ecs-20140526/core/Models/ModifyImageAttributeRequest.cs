// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyImageAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The boot mode of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BIOS: BIOS boot mode.</description></item>
        /// <item><description>UEFI: UEFI boot mode.</description></item>
        /// <item><description>UEFI-Preferred: Dual boot mode.</description></item>
        /// </list>
        /// <notice>
        /// 
        /// <para>   To prevent instances from failing to start due to an unsupported boot mode, make sure that you understand the boot modes supported by the target image before you modify the boot mode. For more information about image boot modes, see <a href="~~2244655#b9caa9b8bb1wf~~">Image boot modes</a>.</para>
        /// </notice>
        /// 
        /// <b>Example:</b>
        /// <para>BIOS</para>
        /// </summary>
        [NameInMap("BootMode")]
        [Validation(Required=false)]
        public string BootMode { get; set; }

        /// <summary>
        /// <para>The description of the custom image. The description must be 2 to 256 characters in length and cannot start with http:// or https://.</para>
        /// <para>Default value: empty. The original description is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: A precheck request is sent, and the image attributes are not modified. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description>false: A normal request is sent, and the image attributes are modified if the request passes the check.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The feature-related attributes of the image.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public ModifyImageAttributeRequestFeatures Features { get; set; }
        public class ModifyImageAttributeRequestFeatures : TeaModel {
            /// <summary>
            /// <para>The metadata access mode of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>v1: When you create an ECS instance from this image, you cannot set the metadata access mode to enforced.</description></item>
            /// <item><description>v2: When you create an ECS instance from this image, you can set the metadata access mode to enforced.<notice>
            /// 
            /// You cannot change ImdsSupport from v2 to v1. To change the value, create a new image from a snapshot associated with this image and set the value to v1.</description></item>
            /// </list>
            /// </notice>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("ImdsSupport")]
            [Validation(Required=false)]
            public string ImdsSupport { get; set; }

            /// <summary>
            /// <para>Modifies the NVMe support attribute of the image. If this parameter is not specified, the original value is retained.</para>
            /// <remarks>
            /// <para>Notice: Before you enable this feature, ensure that the NVMe driver is pre-installed in the operating system. Recommended procedure: install the driver on an instance, create a custom image, and then call this operation. Forcibly enabling this feature without the driver causes the instance to fail to start.</para>
            /// </remarks>
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
        /// <para>The name of the image family. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with aliyun or acs:. It cannot contain http:// or https://. It can contain letters, digits, periods (.), colons (:), underscores (_), and hyphens (-).</para>
        /// <para>Default value: empty.</para>
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
        /// <para>The name of the custom image. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with aliyun or acs:. It cannot contain http:// or https://. It can contain letters, digits, periods (.), colons (:), underscores (_), and hyphens (-).</para>
        /// <para>Default value: empty. The original name is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testImageName</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The license type used to activate the operating system after the image is imported. Only BYOL is supported.</para>
        /// <para>BYOL: The license provided with the source operating system. If you use BYOL, you must ensure that your license key is supported on Alibaba Cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BYOL</para>
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
        /// <para>The status of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Deprecated: Sets the image to the deprecated state. If the custom image is shared, you must unshare it before you can set it to the deprecated state. You cannot share or copy a deprecated image. However, you can use the image to create instances or replace system disks.</description></item>
        /// <item><description>Available: Sets the image to the available state. You can restore a deprecated image to the available state.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you want to roll back a custom image in an image family to the previous version, you can set the latest available custom image to the deprecated state. However, if the image is the only available custom image in the image family, deprecating the image leaves the image family without any available custom images for creating instances. Proceed with caution.</para>
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
