// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageEventOperationPageResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageEventOperationPageResponseBodyData Data { get; set; }
        public class DescribeImageEventOperationPageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The alert handling rules.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeImageEventOperationPageResponseBodyDataList> List { get; set; }
            public class DescribeImageEventOperationPageResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The rule conditions. The value is in the JSON format. Valid values of keys:</para>
                /// <list type="bullet">
                /// <item><description><b>condition</b>: the matching condition.</description></item>
                /// <item><description><b>type</b>: the matching type.</description></item>
                /// <item><description><b>value</b>: the matching value.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;condition\&quot;: \&quot;MD5\&quot;, \&quot;type\&quot;: \&quot;equals\&quot;, \&quot;value\&quot;: \&quot;0083a31cc0083a31ccf7c10367a6e783e\&quot;}]</para>
                /// </summary>
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public string Conditions { get; set; }

                /// <summary>
                /// <para>The keyword of the alert item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PEM</para>
                /// </summary>
                [NameInMap("EventKey")]
                [Validation(Required=false)]
                public string EventKey { get; set; }

                /// <summary>
                /// <para>The name of the alert item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PEM</para>
                /// </summary>
                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                /// <summary>
                /// <para>The alert type.</para>
                /// <list type="bullet">
                /// <item><description>Only <b>sensitiveFile</b> may be returned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sensitiveFile</para>
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// <para>The primary key of the alert handling rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2646624</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The remarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                /// <summary>
                /// <para>The operation code.</para>
                /// <list type="bullet">
                /// <item><description>Only <b>whitelist</b> may be returned, which means that the alert item is added to the whitelist.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>whitelist</para>
                /// </summary>
                [NameInMap("OperationCode")]
                [Validation(Required=false)]
                public string OperationCode { get; set; }

                /// <summary>
                /// <para>The application scope of the rule. The value is in the JSON format. Valid values of keys:</para>
                /// <list type="bullet">
                /// <item><description><b>type</b></description></item>
                /// <item><description><b>value</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;type\&quot;: \&quot;repo\&quot;, \&quot;value\&quot;: \&quot;test-aaa/shenzhen-repo-01\&quot;}</para>
                /// </summary>
                [NameInMap("Scenarios")]
                [Validation(Required=false)]
                public string Scenarios { get; set; }

                /// <summary>
                /// <para>The source of the whitelist. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>image</b>: image.</description></item>
                /// <item><description><b>agentless</b>: agentless detection.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>agentless</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

            }

            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeImageEventOperationPageResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeImageEventOperationPageResponseBodyDataPageInfo : TeaModel {
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
        /// <para>A3D7C47D-3F11-57BB-90E8-E5C20C61****</para>
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
