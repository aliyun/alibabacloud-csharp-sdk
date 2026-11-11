// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ImportImageRequest : TeaModel {
        /// <summary>
        /// <para>The business region ID. Example: cn-hangzhou.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The business line to which the image belongs. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The boot mode of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BIOS: legacy BIOS boot.</description></item>
        /// <item><description>UEFI: UEFI boot.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UEFI</para>
        /// </summary>
        [NameInMap("BootMode")]
        [Validation(Required=false)]
        public string BootMode { get; set; }

        /// <summary>
        /// <para>The description of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom cloud desktop image</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the image security check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables the security check.</description></item>
        /// <item><description>false: disables the security check.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("EnableSecurityCheck")]
        [Validation(Required=false)]
        public bool? EnableSecurityCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether the image is a GPU image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: yes.</description></item>
        /// <item><description>false: no.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("GpuCategory")]
        [Validation(Required=false)]
        public bool? GpuCategory { get; set; }

        /// <summary>
        /// <para>The GPU driver type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>gpu_grid9: GRID 9 driver.</description></item>
        /// <item><description>gpu_grid12: GRID 12 driver.</description></item>
        /// <item><description>gpu_custom: custom driver.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>gpu_grid12</para>
        /// </summary>
        [NameInMap("GpuDriverType")]
        [Validation(Required=false)]
        public string GpuDriverType { get; set; }

        /// <summary>
        /// <para>The name of the image after it is imported. This parameter cannot be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DemoImage</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The operating system license type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Auto: automatically selected.</description></item>
        /// <item><description>Aliyun: provided by Alibaba Cloud.</description></item>
        /// <item><description>BYOL: Bring Your Own License.
        /// Default value: Auto.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Auto</para>
        /// </summary>
        [NameInMap("LicenseType")]
        [Validation(Required=false)]
        public string LicenseType { get; set; }

        /// <summary>
        /// <para>The operating system type of the image file. It must be consistent with the actual operating system of the image, such as Windows or Linux.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <para>The complete OSS object URL of the image file to be imported, including the bucket domain name and file path. The file must be uploaded before you call this operation. Example: <a href="https://BucketName.oss-cn-hangzhou.aliyuncs.com/FilePath">https://BucketName.oss-cn-hangzhou.aliyuncs.com/FilePath</a>.</para>
        /// </summary>
        [NameInMap("OssObjectPath")]
        [Validation(Required=false)]
        public string OssObjectPath { get; set; }

        /// <summary>
        /// <para>The product type. Currently, only CloudDesktop (cloud desktop) is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudDesktop</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The connection protocol of the image. Valid values: ASP and HDX. Default value: ASP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASP</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The size of the system cloud disk. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

    }

}
