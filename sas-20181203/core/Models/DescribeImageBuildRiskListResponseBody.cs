// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBuildRiskListResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success. Any other value indicates failure. You can use this field to determine the cause of the failure.</para>
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
            /// <para>The summary list of build risks.</para>
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
                /// <para>The timestamp of the first scan. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1723710827000</para>
                /// </summary>
                [NameInMap("FirstScanTime")]
                [Validation(Required=false)]
                public long? FirstScanTime { get; set; }

                /// <summary>
                /// <para>The timestamp of the most recent scan. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1723710827999</para>
                /// </summary>
                [NameInMap("LastScanTime")]
                [Validation(Required=false)]
                public long? LastScanTime { get; set; }

                /// <summary>
                /// <para>The key of the build risk rule category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>other</para>
                /// </summary>
                [NameInMap("RiskClass")]
                [Validation(Required=false)]
                public string RiskClass { get; set; }

                /// <summary>
                /// <para>The category name of the build risk rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>other</para>
                /// </summary>
                [NameInMap("RiskClassName")]
                [Validation(Required=false)]
                public string RiskClassName { get; set; }

                /// <summary>
                /// <para>The key of the build risk rule. You can call the <a href="~~~~">DescribeImageBuildRiskList</a> operation to obtain the value of <b>RiskKey</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>no_user</para>
                /// </summary>
                [NameInMap("RiskKey")]
                [Validation(Required=false)]
                public string RiskKey { get; set; }

                /// <summary>
                /// <para>The name of the build risk rule.</para>
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
                /// <item><description><para><b>high</b>: High.</para>
                /// </description></item>
                /// <item><description><para><b>medium</b>: Medium.</para>
                /// </description></item>
                /// <item><description><para><b>low</b>: Low.</para>
                /// </description></item>
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
            /// <para>The paging parameters.</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeImageBuildRiskListResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeImageBuildRiskListResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <para>The page number of the current page when paging is used. Default value: <b>1</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <para>The maximum number of entries per page when paging is used. Default value: 20. If you leave this parameter empty, 20 entries are returned per page.</para>
                /// <remarks>
                /// <para>Do not leave PageSize empty.</para>
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
        /// <para>The detailed information about the error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE120DAB-F4E7-4C53-ADC3-A97578AB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
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
