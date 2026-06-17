// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInternetOpenServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of data.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeInternetOpenServiceResponseBodyDataList> DataList { get; set; }
        public class DescribeInternetOpenServiceResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The number of details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DetailNum")]
            [Validation(Required=false)]
            public int? DetailNum { get; set; }

            /// <summary>
            /// <para>The inbound traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>447458.0</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// <para>The outbound traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1123</para>
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            /// <summary>
            /// <para>The list of open ports.</para>
            /// </summary>
            [NameInMap("PortList")]
            [Validation(Required=false)]
            public List<string> PortList { get; set; }

            /// <summary>
            /// <para>The security threat.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ProbRisk")]
            [Validation(Required=false)]
            public string ProbRisk { get; set; }

            /// <summary>
            /// <para>The description of the security threat.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ProbRiskDesc")]
            [Validation(Required=false)]
            public string ProbRiskDesc { get; set; }

            /// <summary>
            /// <para>The protocol type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The number of exposed public IP addresses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("PublicIpNum")]
            [Validation(Required=false)]
            public int? PublicIpNum { get; set; }

            /// <summary>
            /// <para>The risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

            /// <summary>
            /// <para>The description of the risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RiskReason")]
            [Validation(Required=false)]
            public string RiskReason { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SMB</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public int? ServiceName { get; set; }

            /// <summary>
            /// <para>The recommended policy level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("SuggestLevel")]
            [Validation(Required=false)]
            public int? SuggestLevel { get; set; }

            /// <summary>
            /// <para>The total traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>621404</para>
            /// </summary>
            [NameInMap("TotalBytes")]
            [Validation(Required=false)]
            public long? TotalBytes { get; set; }

            /// <summary>
            /// <para>The traffic percentage over the last 24 hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TrafficPercent1Day")]
            [Validation(Required=false)]
            public string TrafficPercent1Day { get; set; }

            /// <summary>
            /// <para>The traffic percentage over the last 30 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TrafficPercent30Day")]
            [Validation(Required=false)]
            public string TrafficPercent30Day { get; set; }

            /// <summary>
            /// <para>The traffic percentage over the last 7 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>77</para>
            /// </summary>
            [NameInMap("TrafficPercent7Day")]
            [Validation(Required=false)]
            public string TrafficPercent7Day { get; set; }

            /// <summary>
            /// <para>The reason why the protocol is not identified if the detected protocol is \<c>Unknown\\</c>.</para>
            /// </summary>
            [NameInMap("UnknownReason")]
            [Validation(Required=false)]
            public List<string> UnknownReason { get; set; }

        }

        /// <summary>
        /// <para>The paging information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeInternetOpenServiceResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeInternetOpenServiceResponseBodyPageInfo : TeaModel {
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
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99A65AA0-C5B5-5092-BFCF-8111B436****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
