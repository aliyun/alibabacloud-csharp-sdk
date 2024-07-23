// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeNetworkPackagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The premium bandwidth plans.</para>
        /// </summary>
        [NameInMap("NetworkPackages")]
        [Validation(Required=false)]
        public List<DescribeNetworkPackagesResponseBodyNetworkPackages> NetworkPackages { get; set; }
        public class DescribeNetworkPackagesResponseBodyNetworkPackages : TeaModel {
            /// <summary>
            /// <para>The bandwidth provided by the premium bandwidth plan. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The business status.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Expired</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>Normal</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("BusinessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// <para>The time when the premium bandwidth plan was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-10T02:35:26Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The public egress IP address of the premium bandwidth plan.</para>
            /// </summary>
            [NameInMap("EipAddresses")]
            [Validation(Required=false)]
            public List<string> EipAddresses { get; set; }

            /// <summary>
            /// <para>The time when the premium bandwidth plan expires.</para>
            /// <list type="bullet">
            /// <item><description>If the plan is a subscription one, the time when the plan expires is returned.</description></item>
            /// <item><description>If the plan is a pay-as-you-go one, <c>2099-12-31T15:59:59Z</c> is returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2099-12-31T15:59:59Z</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The charge type of the premium bandwidth plan.</para>
            /// <list type="bullet">
            /// <item><description><para>Valid value when the <c>PayType</c> parameter is set to <c>PrePaid</c>:</para>
            /// <list type="bullet">
            /// <item><description>PayByBandwidth: charges by fixed bandwidth.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Valid values when the <c>PayType</c> parameter is set to <c>PostPaid</c>:</para>
            /// <list type="bullet">
            /// <item><description>PayByTraffic: charges by data transfer.</description></item>
            /// <item><description>PayByBandwidth: charges by fixed bandwidth.</description></item>
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
            /// <para>The ID of the premium bandwidth plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>np-amtp8e8q1o9e4****</para>
            /// </summary>
            [NameInMap("NetworkPackageId")]
            [Validation(Required=false)]
            public string NetworkPackageId { get; set; }

            /// <summary>
            /// <para>The status of the premium bandwidth plan.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Creating</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>Released</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>InUse</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>Releasing</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
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
            /// <para>test</para>
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// <para>The type of the office network.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>standard: advanced office network</description></item>
            /// <item><description>customized: custom office network</description></item>
            /// <item><description>basic: basic office network</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("OfficeSiteVpcType")]
            [Validation(Required=false)]
            public string OfficeSiteVpcType { get; set; }

            /// <summary>
            /// <para>The billing method of the premium bandwidth plan.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PostPaid: pay-as-you-go</description></item>
            /// <item><description>PrePaid: subscription</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The time when the reserved network bandwidth took effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-10T00:00:00Z</para>
            /// </summary>
            [NameInMap("ReservationActiveTime")]
            [Validation(Required=false)]
            public string ReservationActiveTime { get; set; }

            /// <summary>
            /// <para>The peak bandwidth that is reserved for the premium bandwidth plan. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ReservationBandwidth")]
            [Validation(Required=false)]
            public int? ReservationBandwidth { get; set; }

            /// <summary>
            /// <para>The billing method of the reserved network bandwidth.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PayByTraffic: charges by data transfer.</para>
            /// </description></item>
            /// <item><description><para>PayByBandwidth: charges by fixed bandwidth.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayByBandwidth</para>
            /// </summary>
            [NameInMap("ReservationInternetChargeType")]
            [Validation(Required=false)]
            public string ReservationInternetChargeType { get; set; }

        }

        /// <summary>
        /// <para>The token that is used to start the next query. If the value of this parameter is empty, all results are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
