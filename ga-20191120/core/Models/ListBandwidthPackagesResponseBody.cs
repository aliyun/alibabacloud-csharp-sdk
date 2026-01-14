// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListBandwidthPackagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the bandwidth plans.</para>
        /// </summary>
        [NameInMap("BandwidthPackages")]
        [Validation(Required=false)]
        public List<ListBandwidthPackagesResponseBodyBandwidthPackages> BandwidthPackages { get; set; }
        public class ListBandwidthPackagesResponseBodyBandwidthPackages : TeaModel {
            /// <summary>
            /// <para>The IDs of the GA instances that are associated with the bandwidth plans.</para>
            /// </summary>
            [NameInMap("Accelerators")]
            [Validation(Required=false)]
            public List<string> Accelerators { get; set; }

            /// <summary>
            /// <para>The bandwidth value of the bandwidth plan. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The ID of the bandwidth plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gbwp-bp1sgzldyj6b4q7cx****</para>
            /// </summary>
            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            /// <summary>
            /// <para>The type of the bandwidth. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Basic</b></description></item>
            /// <item><description><b>Enhanced</b></description></item>
            /// <item><description><b>Advanced</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Basic</para>
            /// </summary>
            [NameInMap("BandwidthType")]
            [Validation(Required=false)]
            public string BandwidthType { get; set; }

            /// <summary>
            /// <para>The metering method that is used when you use the pay-as-you-go billing method.</para>
            /// <list type="bullet">
            /// <item><description><b>PayByTraffic</b>: pay-by-data-transfer.</description></item>
            /// <item><description><b>PayBY95</b>: pay-by-95th-percentile.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByTraffic</para>
            /// </summary>
            [NameInMap("BillingType")]
            [Validation(Required=false)]
            public string BillingType { get; set; }

            /// <summary>
            /// <para>Area A of the cross-region acceleration bandwidth plan. <b>China-mainland</b> is returned.</para>
            /// <para>This parameter is returned only if you call the operation on the international site (alibabacloud.com).</para>
            /// 
            /// <b>Example:</b>
            /// <para>China-mainland</para>
            /// </summary>
            [NameInMap("CbnGeographicRegionIdA")]
            [Validation(Required=false)]
            public string CbnGeographicRegionIdA { get; set; }

            /// <summary>
            /// <para>Area B of the cross-region acceleration bandwidth plan. <b>Global</b> is returned.</para>
            /// <para>This parameter is returned only if you call the operation on the international site (alibabacloud.com).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Global</para>
            /// </summary>
            [NameInMap("CbnGeographicRegionIdB")]
            [Validation(Required=false)]
            public string CbnGeographicRegionIdB { get; set; }

            /// <summary>
            /// <para>The billing method of the bandwidth plan.</para>
            /// <list type="bullet">
            /// <item><description><b>PREPAY</b>: subscription. This is the default value.</description></item>
            /// <item><description><b>POSTPAY</b>: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The time when the bandwidth plan was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578966918000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the bandwidth plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The expiration time of the bandwidth plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578966918000</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The name of the bandwidth plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The percentage of the guaranteed minimum bandwidth if the pay-by-95th-percentile metering method is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Ratio")]
            [Validation(Required=false)]
            public int? Ratio { get; set; }

            /// <summary>
            /// <para>The ID of the region where the GA instance is deployed. <b>cn-hangzhou</b> is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2ry6mp2c****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The status of the bandwidth plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>init:</b> The bandwidth plan is being initialized.</description></item>
            /// <item><description><b>active:</b> The bandwidth plan is available.</description></item>
            /// <item><description><b>binded:</b> The bandwidth plan is associated with a GA instance.</description></item>
            /// <item><description><b>binding:</b> The bandwidth plan is being associated with a GA instance.</description></item>
            /// <item><description><b>unbinding:</b> The bandwidth plan is being disassociated from a GA instance.</description></item>
            /// <item><description><b>updating:</b> The bandwidth plan is being updated.</description></item>
            /// <item><description><b>finacialLocked:</b> The bandwidth plan is locked due to overdue payments.</description></item>
            /// <item><description><b>locked</b>: The bandwidth plan is locked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The tag of the bandwidth plan.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListBandwidthPackagesResponseBodyBandwidthPackagesTags> Tags { get; set; }
            public class ListBandwidthPackagesResponseBodyBandwidthPackagesTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the bandwidth plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag-key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the bandwidth plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag-value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of the bandwidth plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Basic:</b> a basic bandwidth plan.</description></item>
            /// <item><description><b>CrossDomain:</b> a cross-region acceleration bandwidth plan.</description></item>
            /// </list>
            /// <para>If you call the operation on the China site (aliyun.com), <b>Basic</b> is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Basic</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B6DBBB0-2D01-4C6A-A384-4129266E6B78</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
