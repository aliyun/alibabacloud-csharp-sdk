// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class UploadImageRequest : TeaModel {
        /// <summary>
        /// <para>The size of the data disk. Valid values: 80 to 500. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("DataDiskSize")]
        [Validation(Required=false)]
        public int? DataDiskSize { get; set; }

        /// <summary>
        /// <para>The description of the image. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable security check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSecurityCheck")]
        [Validation(Required=false)]
        public bool? EnableSecurityCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether the image is a GPU-accelerated image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("GpuCategory")]
        [Validation(Required=false)]
        public bool? GpuCategory { get; set; }

        /// <summary>
        /// <para>The type of the pre-installed GPU driver.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>gpu_grid9: This GPU driver is used on cloud computers of the following two specifications: graphics – 4 vCPUs, 23 GiB memory, 4 GiB GPU memory, and graphics – 10 vCPUs, 46 GiB memory, 8 GiB GPU memory.</description></item>
        /// <item><description>gpu_custom: You can install the driver later.</description></item>
        /// <item><description>gpu_grid12: This GPU driver is used on graphical cloud computers of specifications other than the following two specifications: graphics – 4 vCPUs, 23 GiB memory, &amp; 4 GiB GPU memory, and graphics – 10 vCPUs, 46 GiB memory, &amp; 8 GiB GPU memory.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>gpu_grid9</para>
        /// </summary>
        [NameInMap("GpuDriverType")]
        [Validation(Required=false)]
        public string GpuDriverType { get; set; }

        /// <summary>
        /// <para>The name of the image. The name must be 2 to 128 characters in length. The name must start with a letter but cannot start with <c>http://</c> or <c>https://</c>. The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Win10_Test</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The type of the license that is used to activate the operating system after the image is imported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Auto: Elastic Desktop Service detects the operating system of the image and allocates a license to the operating system. In this mode, the system first checks whether a license allocated by an official Alibaba Cloud channel is specified in the <c>Platform</c>. If a license allocated by an official Alibaba Cloud channel is specified, the system allocates the license to the imported image. If no such license is specified, the BYOL (Bring Your Own License) mode is used.</description></item>
        /// <item><description>Aliyun: The license that is allocated by an official Alibaba Cloud channel and is specified by <c>Platform</c> is used for the operating system distribution.</description></item>
        /// <item><description>BYOL: The license that comes with the source operating system is used. When you use the BYOL mode, make sure that your license key is supported by Alibaba Cloud.</description></item>
        /// </list>
        /// <para>Default value: Auto.</para>
        /// <remarks>
        /// <para> Windows 10 cannot be activated by Alibaba Cloud. Set the <c>LicenseType</c> to BYOL for Windows 10.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Auto</para>
        /// </summary>
        [NameInMap("LicenseType")]
        [Validation(Required=false)]
        public string LicenseType { get; set; }

        /// <summary>
        /// <para>The type of the operating system.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Linux</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Windows</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <para>The object path of the image file in Object Storage Service (OSS).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://ossbucket:endpoint/object">https://ossbucket:endpoint/object</a></para>
        /// </summary>
        [NameInMap("OssObjectPath")]
        [Validation(Required=false)]
        public string OssObjectPath { get; set; }

        /// <summary>
        /// <para>The protocol type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASP: in-house Adaptive Streaming Protocol (ASP)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASP</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The size of the system disk. Unit: GB.</para>
        /// <remarks>
        /// <para>The size of the system disk cannot be smaller than the size of the image.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public string SystemDiskSize { get; set; }

    }

}
