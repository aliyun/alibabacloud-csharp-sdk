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
        /// <item><description><para><c>BIOS</c>: BIOS boot mode.</para>
        /// </description></item>
        /// <item><description><para><c>UEFI</c>: UEFI boot mode.</para>
        /// </description></item>
        /// <item><description><para><c>UEFI-Preferred</c>: UEFI-preferred boot mode.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>To prevent startup failures, verify the boot modes that the image supports before you change its boot mode. For more information, see <a href="~~2244655#b9caa9b8bb1wf~~">Boot modes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BIOS</para>
        /// </summary>
        [NameInMap("BootMode")]
        [Validation(Required=false)]
        public string BootMode { get; set; }

        /// <summary>
        /// <para>The new description of the custom image. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// <para>If you do not specify this parameter, the original description is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run to check whether the request is valid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: performs a dry run to check the request for validity, syntax, and required permissions. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><c>false</c> (default): sends the request. If the request passes the validation checks, the operation is performed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The features of the image.</para>
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
            /// <item><description><para><c>v1</c>: When you create an ECS instance from this image, you cannot set the metadata access mode to <c>enforced mode</c>.</para>
            /// </description></item>
            /// <item><description><para><c>v2</c>: When you create an ECS instance from this image, you can set the metadata access mode to <c>enforced mode</c>.</para>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>You cannot change the value of <c>ImdsSupport</c> from <c>v2</c> to <c>v1</c>. To use the <c>v1</c> mode, create a new image from a snapshot that is associated with the image and set <c>ImdsSupport</c> to <c>v1</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("ImdsSupport")]
            [Validation(Required=false)]
            public string ImdsSupport { get; set; }

            /// <summary>
            /// <para>Specifies whether the image supports NVMe. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>supported</c>: The image supports NVMe. Instances that you create from this image support the NVMe protocol.</para>
            /// </description></item>
            /// <item><description><para><c>unsupported</c>: The image does not support NVMe. Instances that you create from this image do not support the NVMe protocol.</para>
            /// </description></item>
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
        /// <para>The name of the image family. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character. The name cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>. It can contain digits, periods (.), colons (:), underscores (_), and hyphens (-).</para>
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
        /// <para>The name of the custom image. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character. The name cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>. It can contain digits, periods (.), colons (:), underscores (_), and hyphens (-).</para>
        /// <para>If you do not specify this parameter, the original name is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testImageName</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The license type for activating the operating system after you import the image. The only valid value is <c>BYOL</c>.</para>
        /// <para><c>BYOL</c>: Bring Your Own License. If you use the BYOL license type, you must ensure that your license key is supported for use on Alibaba Cloud.</para>
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
        /// <para>The ID of the region where the custom image is located. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to view the latest list of Alibaba Cloud regions.</para>
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
        /// <para>The image status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Deprecated</c>: Deprecates the image. If a custom image that you want to deprecate is shared, you must unshare it first. You cannot share or copy a deprecated image. However, you can use the image to create an instance or replace a system disk.</para>
        /// </description></item>
        /// <item><description><para><c>Available</c>: Makes the image available. You can change the status of a deprecated image to <c>Available</c>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>However, if this is the only available custom image in the image family, deprecating it prevents the creation of instances from any image in that family. Use this option with caution.</para>
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
