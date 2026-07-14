// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeNetworkPackagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of premium Internet bandwidth plans.</para>
        /// </summary>
        [NameInMap("NetworkPackages")]
        [Validation(Required=false)]
        public List<DescribeNetworkPackagesResponseBodyNetworkPackages> NetworkPackages { get; set; }
        public class DescribeNetworkPackagesResponseBodyNetworkPackages : TeaModel {
            /// <summary>
            /// <para>The bandwidth of the premium Internet bandwidth plan. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The business status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-10T02:35:26Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The public egress IP address of the premium Internet bandwidth plan.</para>
            /// </summary>
            [NameInMap("EipAddresses")]
            [Validation(Required=false)]
            public List<string> EipAddresses { get; set; }

            /// <summary>
            /// <para>The expiration time of the premium Internet bandwidth plan.</para>
            /// <list type="bullet">
            /// <item><description>If the plan uses the subscription billing method, the actual expiration time is returned.</description></item>
            /// <item><description>If the plan uses the pay-as-you-go billing method, <c>2099-12-31T15:59:59Z</c> is returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2099-12-31T15:59:59Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The billing method of the premium Internet bandwidth plan.</para>
            /// <list type="bullet">
            /// <item><description>If the parameter <c>PayType</c> is set to <c>PrePaid</c>, valid values:<list type="bullet">
            /// <item><description>PayByBandwidth: pay-by-bandwidth.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>If the parameter <c>PayType</c> is set to <c>PostPaid</c>, valid values:<list type="bullet">
            /// <item><description>PayByTraffic: pay-by-data-transfer.</description></item>
            /// <item><description>PayByBandwidth: pay-by-bandwidth.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByTraffic</para>
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The ID of the premium Internet bandwidth plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np-amtp8e8q1o9e4****</para>
            /// </summary>
            [NameInMap("NetworkPackageId")]
            [Validation(Required=false)]
            public string NetworkPackageId { get; set; }

            /// <summary>
            /// <para>The status of the premium Internet bandwidth plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InUse</para>
            /// </summary>
            [NameInMap("NetworkPackageStatus")]
            [Validation(Required=false)]
            public string NetworkPackageStatus { get; set; }

            /// <summary>
            /// <para>The office network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-363353****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The office network name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// <para>The office network type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("OfficeSiteVpcType")]
            [Validation(Required=false)]
            public string OfficeSiteVpcType { get; set; }

            /// <summary>
            /// <para>The billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The effective period of the reserved network bandwidth.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-10T00:00:00Z</para>
            /// </summary>
            [NameInMap("ReservationActiveTime")]
            [Validation(Required=false)]
            public string ReservationActiveTime { get; set; }

            /// <summary>
            /// <para>The peak reserved network bandwidth. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ReservationBandwidth")]
            [Validation(Required=false)]
            public int? ReservationBandwidth { get; set; }

            /// <summary>
            /// <para>The billing method of the reserved network bandwidth.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PayByBandwidth</para>
            /// </summary>
            [NameInMap("ReservationInternetChargeType")]
            [Validation(Required=false)]
            public string ReservationInternetChargeType { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeNetworkPackagesResponseBodyNetworkPackagesTags> Tags { get; set; }
            public class DescribeNetworkPackagesResponseBodyNetworkPackagesTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The token for the next query. If NextToken is empty, no more results exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
