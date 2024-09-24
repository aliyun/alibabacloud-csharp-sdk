// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBuildRiskListResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The status code <b>200</b> indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageBuildRiskListResponseBodyData Data { get; set; }
        public class DescribeImageBuildRiskListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The risks.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeImageBuildRiskListResponseBodyDataList> List { get; set; }
            public class DescribeImageBuildRiskListResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The number of affected images.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The timestamp generated when the first scan was performed. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1723710827000</para>
                /// </summary>
                [NameInMap("FirstScanTime")]
                [Validation(Required=false)]
                public long? FirstScanTime { get; set; }

                /// <summary>
                /// <para>The timestamp generated when the last scan was performed. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1723710827999</para>
                /// </summary>
                [NameInMap("LastScanTime")]
                [Validation(Required=false)]
                public long? LastScanTime { get; set; }

                /// <summary>
                /// <para>The type key of the risk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>other</para>
                /// </summary>
                [NameInMap("RiskClass")]
                [Validation(Required=false)]
                public string RiskClass { get; set; }

                /// <summary>
                /// <para>The type name of the risk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>other</para>
                /// </summary>
                [NameInMap("RiskClassName")]
                [Validation(Required=false)]
                public string RiskClassName { get; set; }

                /// <summary>
                /// <para>The key of the risk. You can call the <a href="~~~~">DescribeImageBuildRiskList</a> operation to obtain the value of <b>RiskKey</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>no_user</para>
                /// </summary>
                [NameInMap("RiskKey")]
                [Validation(Required=false)]
                public string RiskKey { get; set; }

                /// <summary>
                /// <para>The rule name of the risk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>no_user</para>
                /// </summary>
                [NameInMap("RiskKeyName")]
                [Validation(Required=false)]
                public string RiskKeyName { get; set; }

                /// <summary>
                /// <para>The risk level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>high</b></description></item>
                /// <item><description><b>medium</b></description></item>
                /// <item><description><b>low</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>medium</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// <para>The number of unprocessed images.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UnprocessedNum")]
                [Validation(Required=false)]
                public int? UnprocessedNum { get; set; }

            }

            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeImageBuildRiskListResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeImageBuildRiskListResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <para>The page number. Default value: <b>1</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <para>The number of entries per page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.</para>
                /// <remarks>
                /// <para> We recommend that you do not leave this parameter empty.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>The total number of entries returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>109</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE120DAB-F4E7-4C53-ADC3-A97578AB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
