// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreatePolarFsRequest : TeaModel {
        /// <summary>
        /// <para>The acceleration space size. Unit: GB. The value must be no less than 5000 and must be a multiple of 1000. This parameter is required when acceleration is enabled for the basic edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("AccelerateStorageSize")]
        [Validation(Required=false)]
        public long? AccelerateStorageSize { get; set; }

        /// <summary>
        /// <para>The acceleration startup mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ONLY</b>: enables acceleration only.</description></item>
        /// <item><description><b>ON</b>: enables cold data and acceleration.</description></item>
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
        /// <para>The list of authorized accounts for the cold storage edition instance. Separate multiple accounts with commas (<c>,</c>).</para>
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
        /// <item><description><b>true</b>: enables auto-renewal.</description></item>
        /// <item><description><b>false</b>: disables auto-renewal.</description></item>
        /// </list>
        /// <para>Default value: <b>false</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the <b>PayType</b> parameter is set to <b>Prepaid</b>.</para>
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
        /// <item><description><b>true</b>: uses coupons (default).</description></item>
        /// <item><description><b>false</b>: does not use coupons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The edition. Valid values: basic (Basic Edition, default), high_performance (High-performance Edition), and cold (Cold Storage Edition). For the basic edition, you must specify the AccelerateSwitch and AccelerateStorageSize parameters. For the high_performance edition, you must specify the StorageType parameter (essdpl0 or essdpl1). For the cold edition, the StorageType parameter (local_redundancy or city_redundancy) is optional.</para>
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
        /// <para>The bucket and corresponding path information.</para>
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
        /// <para>LTAIExampleCustomOssKeyId</para>
        /// </summary>
        [NameInMap("CustomOssAk")]
        [Validation(Required=false)]
        public string CustomOssAk { get; set; }

        /// <summary>
        /// <para>The custom AccessKey secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExampleCustomOssSecret123</para>
        /// </summary>
        [NameInMap("CustomOssSk")]
        [Validation(Required=false)]
        public string CustomOssSk { get; set; }

        /// <summary>
        /// <para>The PolarDB cluster ID. This parameter is required when you call this operation. If this parameter is not specified, the InvalidDBClusterId.Malformed error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The database ecosystem. Valid values: polardb_mysql (PolarDB for MySQL), polardb_pg (PolarDB for PostgreSQL), and polar_agentic_db (AgenticDB). The gateway maps these values to the mysql, postgresql, and agentic_db backends respectively. Pass the request value instead of the display name such as MySQL or PostgreSQL. If an ActionUnauthorized (HTTP 403) error is returned, check the call permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb_mysql</para>
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
        /// <para>If the billing method is <b>Prepaid</b>, this is a required pass parameter. Specifies whether the subscription cluster is billed by year or by month. </para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: year. If you select subscription, the unit is year.</description></item>
        /// <item><description><b>Month</b>: month. If you select subscription, the unit is month.</description></item>
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
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-xxx</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

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
        /// <para>The storage type. For the high_performance edition, use lowercase essdpl0 or essdpl1. For the cold edition, use local_redundancy or city_redundancy. Select the value based on the edition. The value is case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>local_redundancy</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The subscription duration. This parameter is required when the <b>PayType</b> parameter is set to <b>Prepaid</b>.</para>
        /// <list type="bullet">
        /// <item><description>If the <b>Period</b> parameter is set to <b>Month</b>, the value of <b>UsedTime</b> must be an integer in the range of <c>[1-9]</c>.</description></item>
        /// <item><description>If the <b>Period</b> parameter is set to <b>Year</b>, the value of <b>UsedTime</b> must be an integer in the range of <c>[1-3]</c>.</description></item>
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
