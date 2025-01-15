// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeDdosOriginInstanceBillResponseBody : TeaModel {
        /// <summary>
        /// <para>The asset status.</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No asset is added to the instance for protection.</description></item>
        /// <item><description><b>1</b>: Assets are added to the instance for protection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AssetStatus")]
        [Validation(Required=false)]
        public int? AssetStatus { get; set; }

        /// <summary>
        /// <para>The payment status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The payment is not overdue.</description></item>
        /// <item><description><b>1</b>: The payment is overdue.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DebtStatus")]
        [Validation(Required=false)]
        public long? DebtStatus { get; set; }

        /// <summary>
        /// <para>The details about the traffic of EIPs with Anti-DDoS (Enhanced) enabled.</para>
        /// </summary>
        [NameInMap("FlowList")]
        [Validation(Required=false)]
        public List<DescribeDdosOriginInstanceBillResponseBodyFlowList> FlowList { get; set; }
        public class DescribeDdosOriginInstanceBillResponseBodyFlowList : TeaModel {
            /// <summary>
            /// <para>The traffic distribution by region. The JSON struct contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>bytes</b>: the traffic volume of EIPs with Anti-DDoS (Enhanced) enabled in a region. Unit: bytes.</description></item>
            /// <item><description><b>memberUid</b>: the owner account.</description></item>
            /// <item><description><b>instanceId</b>: the ID of the pay-as-you-go instance that protects the EIPs with Anti-DDoS (Enhanced) enabled.</description></item>
            /// <item><description><b>ip</b>: the EIPs with Anti-DDoS (Enhanced) enabled.</description></item>
            /// <item><description><b>region</b>: the region.</description></item>
            /// </list>
            /// <remarks>
            /// <para> If the memberUid field in the JSON struct is empty, the information about the current account is returned. The value of the bytes parameter in the outermost level of the JSON struct indicates the total traffic, and the values of the bytes parameters in inner levels indicate the traffic of the account.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;bytes\&quot;:79282719,\&quot;memberUid\&quot;:\&quot;\&quot;,\&quot;regionFlows\&quot;:{\&quot;cn-hangzhou\&quot;:[{\&quot;bytes\&quot;:79282719,\&quot;instanceId\&quot;:\&quot;ddosorigin_cn-u7c3lcr9r02\&quot;,\&quot;ip\&quot;:\&quot;47.118.168.57\&quot;,\&quot;region\&quot;:\&quot;cn-hangzhou\&quot;}]}}]</para>
            /// </summary>
            [NameInMap("MemberFlow")]
            [Validation(Required=false)]
            public string MemberFlow { get; set; }

            /// <summary>
            /// <para>The traffic distribution by region. The JSON struct contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>bytes</b>: the traffic volume of EIPs with Anti-DDoS (Enhanced) enabled in a region. Unit: bytes.</description></item>
            /// <item><description><b>instanceId</b>: the ID of the pay-as-you-go instance that protects the EIPs with Anti-DDoS (Enhanced) enabled.</description></item>
            /// <item><description><b>ip</b>: the EIPs with Anti-DDoS (Enhanced) enabled.</description></item>
            /// <item><description><b>region</b>: the region.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;cn-hangzhou\&quot;:[{\&quot;bytes\&quot;:0,\&quot;instanceId\&quot;:\&quot;ddosorigin_cn-u7c3lcr9r02\&quot;,\&quot;ip\&quot;:\&quot;47.118.168.124\&quot;,\&quot;region\&quot;:\&quot;cn-hangzhou\&quot;}]}</para>
            /// </summary>
            [NameInMap("RegionFlow")]
            [Validation(Required=false)]
            public string RegionFlow { get; set; }

            /// <summary>
            /// <para>The timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1620951900</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            [NameInMap("TotalBillFlow")]
            [Validation(Required=false)]
            public long? TotalBillFlow { get; set; }

            /// <summary>
            /// <para>The traffic of EIPs with Anti-DDoS (Enhanced) enabled. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6302081067</para>
            /// </summary>
            [NameInMap("TotalFlow")]
            [Validation(Required=false)]
            public long? TotalFlow { get; set; }

        }

        /// <summary>
        /// <para>The traffic distribution of EIPs with Anti-DDoS (Enhanced) enabled by region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;cn-hongkong\&quot;: 166491566}</para>
        /// </summary>
        [NameInMap("FlowRegion")]
        [Validation(Required=false)]
        public Dictionary<string, object> FlowRegion { get; set; }

        /// <summary>
        /// <para>The ID of the Anti-DDoS Origin (Pay-as-you-go) instance to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddosorigin_cn-u7c3lcr9r02</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of protected IP addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("IpCount")]
        [Validation(Required=false)]
        public long? IpCount { get; set; }

        /// <summary>
        /// <para>The protected IP addresses and enabled features.</para>
        /// </summary>
        [NameInMap("IpCountOrFunctionList")]
        [Validation(Required=false)]
        public List<DescribeDdosOriginInstanceBillResponseBodyIpCountOrFunctionList> IpCountOrFunctionList { get; set; }
        public class DescribeDdosOriginInstanceBillResponseBodyIpCountOrFunctionList : TeaModel {
            /// <summary>
            /// <para>The application scope of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>only_mainland_china</b>: regions in the Chinese mainland.</description></item>
            /// <item><description><b>global</b>: all regions.</description></item>
            /// <item><description><b>international_and_hmt</b>: regions outside the Chinese mainland.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("Coverage")]
            [Validation(Required=false)]
            public string Coverage { get; set; }

            /// <summary>
            /// <para>The number of IP addresses protected by the pay-as-you-go instance in the Chinese mainland.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("IpCntCn")]
            [Validation(Required=false)]
            public long? IpCntCn { get; set; }

            /// <summary>
            /// <para>The number of IP addresses protected by the pay-as-you-go instance outside the Chinese mainland.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("IpCntOv")]
            [Validation(Required=false)]
            public long? IpCntOv { get; set; }

            /// <summary>
            /// <para>The bill distribution by account. The JSON struct contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>eipCnIpCount</b>: the number of EIPs with Anti-DDoS (Enhanced) enabled in the Chinese mainland.</description></item>
            /// <item><description><b>eipOvIpCount</b>: the number of EIPs with Anti-DDoS (Enhanced) enabled outside the Chinese mainland.</description></item>
            /// <item><description><b>memberUid</b>: the owner account.</description></item>
            /// <item><description><b>standardAssetsCnIpCount</b>: the number of IP addresses of regular Alibaba Cloud services in the Chinese mainland.</description></item>
            /// <item><description><b>standardAssetsOvIpCount</b>: the number of IP addresses of regular Alibaba Cloud services outside the Chinese mainland.</description></item>
            /// </list>
            /// <remarks>
            /// <para> If the memberUid field in the JSON struct is empty, the information about the current account is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;eipCnIpCount\&quot;:3,\&quot;eipOvIpCount\&quot;:18,\&quot;memberUid\&quot;:\&quot;\&quot;,\&quot;standardAssetsCnIpCount\&quot;:2,\&quot;standardAssetsOvIpCount\&quot;:0},{\&quot;eipCnIpCount\&quot;:3,\&quot;eipOvIpCount\&quot;:0,\&quot;memberUid\&quot;:\&quot;1776997906319249\&quot;,\&quot;standardAssetsCnIpCount\&quot;:0,\&quot;standardAssetsOvIpCount\&quot;:0}]</para>
            /// </summary>
            [NameInMap("MemberIpCnt")]
            [Validation(Required=false)]
            public string MemberIpCnt { get; set; }

            /// <summary>
            /// <para>The billing time. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1680278400000</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

        }

        /// <summary>
        /// <para>The IP address distribution. The JSON struct contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>eipCnIpCount</b>: the number of EIPs with Anti-DDoS (Enhanced) enabled in the Chinese mainland.</description></item>
        /// <item><description><b>eipOvIpCount</b>: the number of EIPs with Anti-DDoS (Enhanced) enabled outside the Chinese mainland.</description></item>
        /// <item><description><b>standardAssetsCnIpCount</b>: the number of IP addresses of regular Alibaba Cloud services in the Chinese mainland.</description></item>
        /// <item><description><b>standardAssetsOvIpCount</b>: the number of IP addresses of regular Alibaba Cloud services outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;eipCnIpCount\&quot;:6,\&quot;eipOvIpCount\&quot;:17,\&quot;standardAssetsCnIpCount\&quot;:2,\&quot;standardAssetsOvIpCount\&quot;:0}</para>
        /// </summary>
        [NameInMap("IpInfo")]
        [Validation(Required=false)]
        public string IpInfo { get; set; }

        /// <summary>
        /// <para>The information about the monthly summary bills.</para>
        /// </summary>
        [NameInMap("MonthlySummaryList")]
        [Validation(Required=false)]
        public List<DescribeDdosOriginInstanceBillResponseBodyMonthlySummaryList> MonthlySummaryList { get; set; }
        public class DescribeDdosOriginInstanceBillResponseBodyMonthlySummaryList : TeaModel {
            /// <summary>
            /// <para>The number of days that the instance is activated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("EnableDays")]
            [Validation(Required=false)]
            public int? EnableDays { get; set; }

            /// <summary>
            /// <para>The total traffic of EIPs with Anti-DDoS (Enhanced) enabled in the Chinese mainland. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("FlowCn")]
            [Validation(Required=false)]
            public long? FlowCn { get; set; }

            /// <summary>
            /// <para>The total traffic of EIPs with Anti-DDoS (Enhanced) enabled outside the Chinese mainland. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("FlowIntl")]
            [Validation(Required=false)]
            public long? FlowIntl { get; set; }

            /// <summary>
            /// <para>The total number of protected IP addresses in the Chinese mainland.</para>
            /// <remarks>
            /// <para> The total number of protected IP addresses is the sum of the daily numbers of protected IP addresses in a month.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>28</para>
            /// </summary>
            [NameInMap("IpCountCn")]
            [Validation(Required=false)]
            public int? IpCountCn { get; set; }

            /// <summary>
            /// <para>The total number of protected IP addresses outside the Chinese mainland.</para>
            /// <remarks>
            /// <para> The total number of protected IP addresses is the sum of the daily numbers of protected IP addresses in a month.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("IpCountIntl")]
            [Validation(Required=false)]
            public int? IpCountIntl { get; set; }

            /// <summary>
            /// <para>The ID of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>112873971277****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The total traffic of regular Alibaba Cloud services in the Chinese mainland. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("StandardAssetsFlowCn")]
            [Validation(Required=false)]
            public long? StandardAssetsFlowCn { get; set; }

            /// <summary>
            /// <para>The total traffic of regular Alibaba Cloud services outside the Chinese mainland. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("StandardAssetsFlowIntl")]
            [Validation(Required=false)]
            public long? StandardAssetsFlowIntl { get; set; }

            /// <summary>
            /// <para>The ID of the administrator account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102518028277****</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72155560-F343-55C8-82FE-ED4D7E4AA97E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details about the traffic of regular Alibaba Cloud services.</para>
        /// </summary>
        [NameInMap("StandardAssetsFlowList")]
        [Validation(Required=false)]
        public List<DescribeDdosOriginInstanceBillResponseBodyStandardAssetsFlowList> StandardAssetsFlowList { get; set; }
        public class DescribeDdosOriginInstanceBillResponseBodyStandardAssetsFlowList : TeaModel {
            /// <summary>
            /// <para>The traffic distribution by region. The JSON struct contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>bytes</b>: the traffic volume of regular Alibaba Cloud services in a region. Unit: bytes.</description></item>
            /// <item><description><b>memberUid</b>: the owner account.</description></item>
            /// <item><description><b>instanceId</b>: the ID of the pay-as-you-go instance that protects the regular Alibaba Cloud services.</description></item>
            /// <item><description><b>ip</b>: the IP address of the regular Alibaba Cloud service protected by the Anti-DDoS Origin instance.</description></item>
            /// <item><description><b>region</b>: the region.</description></item>
            /// </list>
            /// <remarks>
            /// <para> If the memberUid field in the JSON struct is empty, the information about the current account is returned. The value of the bytes parameter in the outermost level of the JSON struct indicates the total traffic, and the values of the bytes parameters in inner levels indicate the traffic of the account.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;bytes\&quot;:79282719,\&quot;memberUid\&quot;:\&quot;\&quot;,\&quot;regionFlows\&quot;:{\&quot;cn-hangzhou\&quot;:[{\&quot;bytes\&quot;:79282719,\&quot;instanceId\&quot;:\&quot;ddosorigin_cn-u7c3lcr9r02\&quot;,\&quot;ip\&quot;:\&quot;47.118.168.57\&quot;,\&quot;region\&quot;:\&quot;cn-hangzhou\&quot;}]}}]</para>
            /// </summary>
            [NameInMap("MemberFlow")]
            [Validation(Required=false)]
            public string MemberFlow { get; set; }

            /// <summary>
            /// <para>The traffic distribution by region. The JSON struct contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>bytes</b>: the traffic volume of regular Alibaba Cloud services in a region. Unit: bytes.</description></item>
            /// <item><description><b>instanceId</b>: the ID of the pay-as-you-go instance that protects the regular Alibaba Cloud services.</description></item>
            /// <item><description><b>ip</b>: the IP address protected by the Anti-DDoS Origin instance.</description></item>
            /// <item><description><b>region</b>: the region.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;cn-hangzhou\&quot;:[{\&quot;bytes\&quot;:0,\&quot;instanceId\&quot;:\&quot;ddosorigin_cn-u7c3lcr9r02\&quot;,\&quot;ip\&quot;:\&quot;47.118.168.124\&quot;,\&quot;region\&quot;:\&quot;cn-hangzhou\&quot;}]}</para>
            /// </summary>
            [NameInMap("RegionFlow")]
            [Validation(Required=false)]
            public string RegionFlow { get; set; }

            /// <summary>
            /// <para>The timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1679846400000</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// <para>The traffic of regular Alibaba Cloud services. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6302081067</para>
            /// </summary>
            [NameInMap("TotalFlow")]
            [Validation(Required=false)]
            public long? TotalFlow { get; set; }

        }

        /// <summary>
        /// <para>The traffic distribution of regular Alibaba Cloud services by region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;cn-hongkong\&quot;: 166491566}</para>
        /// </summary>
        [NameInMap("StandardAssetsFlowRegion")]
        [Validation(Required=false)]
        public Dictionary<string, object> StandardAssetsFlowRegion { get; set; }

        /// <summary>
        /// <para>The total traffic of regular Alibaba Cloud services in the Chinese mainland in the current month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StandardAssetsTotalFlowCn")]
        [Validation(Required=false)]
        public long? StandardAssetsTotalFlowCn { get; set; }

        /// <summary>
        /// <para>The total traffic of regular Alibaba Cloud services outside the Chinese mainland in the current month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("StandardAssetsTotalFlowOv")]
        [Validation(Required=false)]
        public long? StandardAssetsTotalFlowOv { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: normal</description></item>
        /// <item><description><b>2</b>: expired</description></item>
        /// <item><description><b>3</b>: released</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <para>The total traffic of EIPs with Anti-DDoS (Enhanced) enabled in the Chinese mainland in the current month. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6302081067</para>
        /// </summary>
        [NameInMap("TotalFlowCn")]
        [Validation(Required=false)]
        public long? TotalFlowCn { get; set; }

        /// <summary>
        /// <para>The total traffic of EIPs with Anti-DDoS (Enhanced) enabled outside the Chinese mainland in the current month. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6204918019</para>
        /// </summary>
        [NameInMap("TotalFlowOv")]
        [Validation(Required=false)]
        public long? TotalFlowOv { get; set; }

    }

}
