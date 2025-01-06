// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenBandwidthPackagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the bandwidth plan.</para>
        /// </summary>
        [NameInMap("CenBandwidthPackages")]
        [Validation(Required=false)]
        public DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackages CenBandwidthPackages { get; set; }
        public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackages : TeaModel {
            [NameInMap("CenBandwidthPackage")]
            [Validation(Required=false)]
            public List<DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackage> CenBandwidthPackage { get; set; }
            public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackage : TeaModel {
                /// <summary>
                /// <para>The maximum bandwidth of the bandwidth plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                /// <summary>
                /// <para>The billing method of the bandwidth plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PREPAY</para>
                /// </summary>
                [NameInMap("BandwidthPackageChargeType")]
                [Validation(Required=false)]
                public string BandwidthPackageChargeType { get; set; }

                /// <summary>
                /// <para>The status of the bandwidth plan. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: running as expected.</description></item>
                /// <item><description><b>FinancialLocked</b>: locked due to overdue payments.</description></item>
                /// <item><description><b>SecurityLocked</b>: locked due to security reasons</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// <para>The ID of the bandwidth plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cenbwp-4c2zaavbvh5x****</para>
                /// </summary>
                [NameInMap("CenBandwidthPackageId")]
                [Validation(Required=false)]
                public string CenBandwidthPackageId { get; set; }

                /// <summary>
                /// <para>A list of CEN instances that are associated with the bandwidth plan.</para>
                /// </summary>
                [NameInMap("CenIds")]
                [Validation(Required=false)]
                public DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageCenIds CenIds { get; set; }
                public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageCenIds : TeaModel {
                    [NameInMap("CenId")]
                    [Validation(Required=false)]
                    public List<string> CenId { get; set; }

                }

                /// <summary>
                /// <para>The time when the bandwidth plan was created. The time is displayed in the ISO8601 standard in the YYYY-MM-DDThh:mmZ format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-02-01T11:14Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the bandwidth plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time when the bandwidth plan expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-09-08T16:00Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The ID of the area that you want to query. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>china</b>: Chinese mainland.</description></item>
                /// <item><description><b>asia-pacific</b>: Asia Pacific</description></item>
                /// <item><description><b>europe</b>: Europe</description></item>
                /// <item><description><b>north-america</b>: North America</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>china</para>
                /// </summary>
                [NameInMap("GeographicRegionAId")]
                [Validation(Required=false)]
                public string GeographicRegionAId { get; set; }

                /// <summary>
                /// <para>The ID of the other area connected by the bandwidth plan. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>china</b>: Chinese mainland.</description></item>
                /// <item><description><b>asia-pacific</b>: Asia Pacific</description></item>
                /// <item><description><b>europe</b>: Europe</description></item>
                /// <item><description><b>north-america</b>: North America</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>north-america</para>
                /// </summary>
                [NameInMap("GeographicRegionBId")]
                [Validation(Required=false)]
                public string GeographicRegionBId { get; set; }

                /// <summary>
                /// <para>The ID of the connected area.</para>
                /// 
                /// <b>Example:</b>
                /// <para>north-america_china</para>
                /// </summary>
                [NameInMap("GeographicSpanId")]
                [Validation(Required=false)]
                public string GeographicSpanId { get; set; }

                /// <summary>
                /// <para>Indicates whether renewal data is included.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter returns <b>true</b> only when the <b>IncludeReservationData</b> parameter is set to <b>true</b> and a pending order exists.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HasReservationData")]
                [Validation(Required=false)]
                public string HasReservationData { get; set; }

                /// <summary>
                /// <para>Indicates whether the bandwidth plan supports cross-border communication.</para>
                /// <list type="bullet">
                /// <item><description><b>false</b></description></item>
                /// <item><description><b>true</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsCrossBorder")]
                [Validation(Required=false)]
                public bool? IsCrossBorder { get; set; }

                /// <summary>
                /// <para>The name of the bandwidth plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The details about the connected regions.</para>
                /// </summary>
                [NameInMap("OrginInterRegionBandwidthLimits")]
                [Validation(Required=false)]
                public DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageOrginInterRegionBandwidthLimits OrginInterRegionBandwidthLimits { get; set; }
                public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageOrginInterRegionBandwidthLimits : TeaModel {
                    [NameInMap("OrginInterRegionBandwidthLimit")]
                    [Validation(Required=false)]
                    public List<DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageOrginInterRegionBandwidthLimitsOrginInterRegionBandwidthLimit> OrginInterRegionBandwidthLimit { get; set; }
                    public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageOrginInterRegionBandwidthLimitsOrginInterRegionBandwidthLimit : TeaModel {
                        /// <summary>
                        /// <para>The maximum bandwidth value for the inter-region connection.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("BandwidthLimit")]
                        [Validation(Required=false)]
                        public string BandwidthLimit { get; set; }

                        /// <summary>
                        /// <para>The connected regions.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>north-america_china</para>
                        /// </summary>
                        [NameInMap("GeographicSpanId")]
                        [Validation(Required=false)]
                        public string GeographicSpanId { get; set; }

                        /// <summary>
                        /// <para>The ID of the local region.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("LocalRegionId")]
                        [Validation(Required=false)]
                        public string LocalRegionId { get; set; }

                        /// <summary>
                        /// <para>The ID of the peer region.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>us-west-1</para>
                        /// </summary>
                        [NameInMap("OppositeRegionId")]
                        [Validation(Required=false)]
                        public string OppositeRegionId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The expiration time of the temporary upgrade.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-30T16:00Z</para>
                /// </summary>
                [NameInMap("ReservationActiveTime")]
                [Validation(Required=false)]
                public string ReservationActiveTime { get; set; }

                /// <summary>
                /// <para>The bandwidth value to which the bandwidth plan is restored when the temporary upgrade ends.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ReservationBandwidth")]
                [Validation(Required=false)]
                public string ReservationBandwidth { get; set; }

                /// <summary>
                /// <para>The new billing method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PREPAY</para>
                /// </summary>
                [NameInMap("ReservationInternetChargeType")]
                [Validation(Required=false)]
                public string ReservationInternetChargeType { get; set; }

                /// <summary>
                /// <para>The renewal method.</para>
                /// <list type="bullet">
                /// <item><description><b>TEMP_UPGRADE</b>: temporary upgrade</description></item>
                /// <item><description><b>UPGRADE</b>: upgrade</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UPGRADE</para>
                /// </summary>
                [NameInMap("ReservationOrderType")]
                [Validation(Required=false)]
                public string ReservationOrderType { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the ACL belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aekzoyr5k36****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether the bandwidth plan is associated with a CEN instance.</para>
                /// <list type="bullet">
                /// <item><description><b>Idle</b></description></item>
                /// <item><description><b>InUse</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>InUse</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tags of the bandwidth plan.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageTags Tags { get; set; }
                public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageTagsTag> Tag { get; set; }
                    public class DescribeCenBandwidthPackagesResponseBodyCenBandwidthPackagesCenBandwidthPackageTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TagKey</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TagValue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The number of the returned page.</para>
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
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9D7E2400-2755-4AF5-9B73-12565E4F73A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
