// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInternetOpenIpResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeInternetOpenIpResponseBodyDataList> DataList { get; set; }
        public class DescribeInternetOpenIpResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The reason why recommended intelligent policies are unavailable. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>No recommended intelligent policies are available.</description></item>
            /// <item><description>This feature is available only to some users.</description></item>
            /// <item><description>The policy configuration has been modified. No recommended intelligent policies are available.</description></item>
            /// <item><description>The recommended intelligent policies have been configured. No new recommended intelligent policies are available.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>No recommended intelligent policies are available.</para>
            /// </summary>
            [NameInMap("AclRecommendDetail")]
            [Validation(Required=false)]
            public string AclRecommendDetail { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1ix9w22kv6aew9****</para>
            /// </summary>
            [NameInMap("AssetsInstanceId")]
            [Validation(Required=false)]
            public string AssetsInstanceId { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>launch-advisor-2023****</para>
            /// </summary>
            [NameInMap("AssetsName")]
            [Validation(Required=false)]
            public string AssetsName { get; set; }

            /// <summary>
            /// <para>The asset type of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EcsEIP</para>
            /// </summary>
            [NameInMap("AssetsType")]
            [Validation(Required=false)]
            public string AssetsType { get; set; }

            /// <summary>
            /// <para>The total number of ports.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DetailNum")]
            [Validation(Required=false)]
            public int? DetailNum { get; set; }

            /// <summary>
            /// <para>Specifies whether an access control policy is recommended. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasAclRecommend")]
            [Validation(Required=false)]
            public bool? HasAclRecommend { get; set; }

            /// <summary>
            /// <para>The list of ports.</para>
            /// </summary>
            [NameInMap("PortList")]
            [Validation(Required=false)]
            public List<string> PortList { get; set; }

            /// <summary>
            /// <para>The public IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.0.113.1</para>
            /// </summary>
            [NameInMap("PublicIp")]
            [Validation(Required=false)]
            public string PublicIp { get; set; }

            /// <summary>
            /// <para>The region ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>3</b>: high risk</description></item>
            /// <item><description><b>2</b>: medium risk</description></item>
            /// <item><description><b>1</b>: low risk</description></item>
            /// <item><description><b>0</b>: no risk</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

            /// <summary>
            /// <para>The reason for the risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Previous traffic is all malicious traffic.</para>
            /// </summary>
            [NameInMap("RiskReason")]
            [Validation(Required=false)]
            public string RiskReason { get; set; }

            /// <summary>
            /// <para>The list of applications.</para>
            /// </summary>
            [NameInMap("ServiceNameList")]
            [Validation(Required=false)]
            public List<string> ServiceNameList { get; set; }

            [NameInMap("SrcIpCnt")]
            [Validation(Required=false)]
            public long? SrcIpCnt { get; set; }

            [NameInMap("TotalReplyBytes")]
            [Validation(Required=false)]
            public long? TotalReplyBytes { get; set; }

            /// <summary>
            /// <para>The percentage of traffic of a day. Unit: percent (%).</para>
            /// 
            /// <b>Example:</b>
            /// <para>11.1</para>
            /// </summary>
            [NameInMap("TrafficPercent1Day")]
            [Validation(Required=false)]
            public string TrafficPercent1Day { get; set; }

            /// <summary>
            /// <para>The percentage of traffic of 30 days. Unit: percent (%).</para>
            /// 
            /// <b>Example:</b>
            /// <para>99.9</para>
            /// </summary>
            [NameInMap("TrafficPercent30Day")]
            [Validation(Required=false)]
            public string TrafficPercent30Day { get; set; }

            /// <summary>
            /// <para>The percentage of traffic of seven days. Unit: percent (%).</para>
            /// 
            /// <b>Example:</b>
            /// <para>77.7</para>
            /// </summary>
            [NameInMap("TrafficPercent7Day")]
            [Validation(Required=false)]
            public string TrafficPercent7Day { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeInternetOpenIpResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeInternetOpenIpResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6B780BD6-282C-51A9-A8E6-59F636BAFA54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
