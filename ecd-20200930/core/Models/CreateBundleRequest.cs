// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateBundleRequest : TeaModel {
        /// <summary>
        /// <para>The name of the cloud computer template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testBundleName</para>
        /// </summary>
        [NameInMap("BundleName")]
        [Validation(Required=false)]
        public string BundleName { get; set; }

        /// <summary>
        /// <para>The description of the cloud computer template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The cloud computer specifications. You can call <a href="https://help.aliyun.com/document_detail/436974.html">DescribeBundles</a> to query cloud computer templates and obtain the supported cloud computer specifications from the <c>DesktopType</c> parameter in the response.</para>
        /// <remarks>
        /// <para>Non-GPU images can only use non-GPU specifications, and GPU images can only use GPU specifications.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.enterprise_office.2c4g</para>
        /// </summary>
        [NameInMap("DesktopType")]
        [Validation(Required=false)]
        public string DesktopType { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-4zfb6zj728hhr****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The operating system language. Currently, only system images are supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Simplified Chinese.</description></item>
        /// <item><description>zh-HK: Traditional Chinese (Hong Kong (China)).</description></item>
        /// <item><description>en-US: English.</description></item>
        /// <item><description>ja-JP: Japanese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The performance level of the system cloud disk. When the cloud computer specifications are set to graphics or high frequency, you can configure the cloud disk performance level. For more information about the differences between performance levels, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD cloud disks</a>. Settings: standard SSD and ESSD cloud disks are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("RootDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string RootDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The system disk size. Unit: GiB. The supported system disk sizes correspond to the specifications. For more information, see <a href="https://help.aliyun.com/document_detail/188609.html">Overview of cloud computer specifications</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("RootDiskSizeGib")]
        [Validation(Required=false)]
        public int? RootDiskSizeGib { get; set; }

        /// <summary>
        /// <para>The performance level of the data cloud disk. When the cloud computer specifications are set to graphics or high frequency, you can configure the cloud disk performance level. For more information about the differences between performance levels, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD cloud disks</a>. Settings: standard SSD and ESSD cloud disks are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("UserDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string UserDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The list of data disk sizes. Currently, only one data disk can be configured.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("UserDiskSizeGib")]
        [Validation(Required=false)]
        public List<int?> UserDiskSizeGib { get; set; }

    }

}
