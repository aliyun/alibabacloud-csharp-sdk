// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreatePolarFsRequest : TeaModel {
        /// <summary>
        /// <para>The acceleration storage space for Basic Edition with acceleration enabled. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("AccelerateStorageSize")]
        [Validation(Required=false)]
        public long? AccelerateStorageSize { get; set; }

        /// <summary>
        /// <para>The acceleration mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ONLY</b>: enables acceleration only.</description></item>
        /// <item><description><b>ON</b>: enables cold data storage and acceleration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ONLY</para>
        /// </summary>
        [NameInMap("AccelerateSwitch")]
        [Validation(Required=false)]
        public string AccelerateSwitch { get; set; }

        /// <summary>
        /// <para>The acceleration type. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>juice</b>: file system acceleration.</description></item>
        /// <item><description><b>alluxio</b>: transparent acceleration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>alluxio</para>
        /// </summary>
        [NameInMap("AccelerateType")]
        [Validation(Required=false)]
        public string AccelerateType { get; set; }

        /// <summary>
        /// <para>The list of authorized account IDs for Cold Storage Edition instances, separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>128***********，198***********</para>
        /// </summary>
        [NameInMap("AuthorizedUserIds")]
        [Validation(Required=false)]
        public string AuthorizedUserIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Auto-renewal is enabled.</description></item>
        /// <item><description><b>false</b>: Auto-renewal is disabled.</description></item>
        /// </list>
        /// <para>Default value: <b>false</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>PayType</b> is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically use coupons. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Coupons are used (default).</description></item>
        /// <item><description><b>false</b>: Coupons are not used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>basic</b>: Basic Edition (default).</description></item>
        /// <item><description><b>cold</b>: Cold Storage Edition.</description></item>
        /// <item><description><b>high_performance</b>: High-performance Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("CreationCategory")]
        [Validation(Required=false)]
        public string CreationCategory { get; set; }

        /// <summary>
        /// <para>The number of buckets.</para>
        /// <remarks>
        /// <para>This parameter is required only when acceleration (file system acceleration) is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CustomBucketCount")]
        [Validation(Required=false)]
        public int? CustomBucketCount { get; set; }

        /// <summary>
        /// <para>The bucket path.</para>
        /// <remarks>
        /// <para>This parameter is required only when acceleration (file system acceleration) is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/test</para>
        /// </summary>
        [NameInMap("CustomBucketPath")]
        [Validation(Required=false)]
        public string CustomBucketPath { get; set; }

        /// <summary>
        /// <para>The bucket and path information.</para>
        /// <remarks>
        /// <para>This parameter is required for transparent acceleration scenarios.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CustomBucketPathList")]
        [Validation(Required=false)]
        public List<CreatePolarFsRequestCustomBucketPathList> CustomBucketPathList { get; set; }
        public class CreatePolarFsRequestCustomBucketPathList : TeaModel {
            /// <summary>
            /// <para>The custom storage bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pfs-xxx.oss-[regionId]-internal.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The custom storage path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/data</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        /// <summary>
        /// <para>The custom AccessKey ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("CustomOssAk")]
        [Validation(Required=false)]
        public string CustomOssAk { get; set; }

        /// <summary>
        /// <para>The custom AccessKey secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("CustomOssSk")]
        [Validation(Required=false)]
        public string CustomOssSk { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>This parameter is required when <b>PayType</b> is set to <b>Prepaid</b>. Specifies whether the subscription cluster uses a yearly or monthly billing cycle. You must pass this parameter when the billing method is subscription. </para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: The subscription period is measured in years.</description></item>
        /// <item><description><b>Month</b>: The subscription period is measured in months.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The coupon code. If this parameter is not specified, the default coupon is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>727xxxxxx934</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query region IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The storage space. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public long? StorageSpace { get; set; }

        /// <summary>
        /// <para>Valid values for high-performance storage type:</para>
        /// <list type="bullet">
        /// <item><description><b>ESSDPL0</b></description></item>
        /// <item><description><b>ESSDPL1</b></description></item>
        /// </list>
        /// <para>Valid values for Basic Edition storage type:</para>
        /// <list type="bullet">
        /// <item><description><b>city_redundancy (zone-redundant)</b></description></item>
        /// </list>
        /// <para>Valid values for Cold Storage Edition storage type:</para>
        /// <list type="bullet">
        /// <item><description><b>city_redundancy (zone-redundant)</b></description></item>
        /// <item><description><b>local_redundancy (locally redundant)</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>local_redundancy</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>This parameter is required when <b>PayType</b> is set to <b>Prepaid</b>.</para>
        /// <list type="bullet">
        /// <item><description>When <b>Period</b> is set to <b>Month</b>, the valid values of <b>UsedTime</b> are integers in the range of <c>[1-9]</c>.</description></item>
        /// <item><description>When <b>Period</b> is set to <b>Year</b>, the valid values of <b>UsedTime</b> are integers in the range of <c>[1-3]</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-*******************</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-*********************</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-i</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
