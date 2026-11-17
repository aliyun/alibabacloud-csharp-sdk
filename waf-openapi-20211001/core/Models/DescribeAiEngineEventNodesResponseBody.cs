// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeAiEngineEventNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of nodes.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAiEngineEventNodesResponseBodyItems> Items { get; set; }
        public class DescribeAiEngineEventNodesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The details of the node in the specified language. The details are in Markdown format.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description><b>Characteristic</b>: single quote closure</description></item>
            /// <item><description><b>Risk</b>: high</description></item>
            /// </list>
            /// </summary>
            [NameInMap("NodeDetail")]
            [Validation(Required=false)]
            public string NodeDetail { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>node-109-04</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The name of the node in the specified language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SQL Injection</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The summary of the node in the specified language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The request matches SQL injection characteristics.</para>
            /// </summary>
            [NameInMap("NodeSummary")]
            [Validation(Required=false)]
            public string NodeSummary { get; set; }

            /// <summary>
            /// <para>The node tag. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>bypass</b>: Suspected bypass.</para>
            /// </description></item>
            /// <item><description><para><b>protect</b>: Mitigated.</para>
            /// </description></item>
            /// <item><description><para><b>attempt</b>: Reconnaissance and probing.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>bypass</para>
            /// </summary>
            [NameInMap("NodeTag")]
            [Validation(Required=false)]
            public string NodeTag { get; set; }

            /// <summary>
            /// <para>The time when the node occurred. The time is in the UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1792973400000</para>
            /// </summary>
            [NameInMap("OccurredAt")]
            [Validation(Required=false)]
            public long? OccurredAt { get; set; }

        }

        /// <summary>
        /// <para>The number of entries to return on each page in a paging query. Valid values: 1 to 20. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used to query the next page. If a next page exists, this field returns a value.</para>
        /// <remarks>
        /// <para>If this parameter returns a value, a next page exists. You can use the returned <b>NextToken</b> as a request parameter to obtain the data on the next page until no value is returned, which indicates that all data is obtained.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAGBgV9tolsLfijC4wam2htS*****D/46H3X2wIS</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-demo</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of nodes for the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
