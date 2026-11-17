// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeAiEngineEvidenceRequestsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of evidence requests.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAiEngineEvidenceRequestsResponseBodyItems> Items { get; set; }
        public class DescribeAiEngineEvidenceRequestsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The list of attack source groups for the request.</para>
            /// </summary>
            [NameInMap("AttackSources")]
            [Validation(Required=false)]
            public List<DescribeAiEngineEvidenceRequestsResponseBodyItemsAttackSources> AttackSources { get; set; }
            public class DescribeAiEngineEvidenceRequestsResponseBodyItemsAttackSources : TeaModel {
                /// <summary>
                /// <para>The list of sources of this type.</para>
                /// </summary>
                [NameInMap("Sources")]
                [Validation(Required=false)]
                public List<DescribeAiEngineEvidenceRequestsResponseBodyItemsAttackSourcesSources> Sources { get; set; }
                public class DescribeAiEngineEvidenceRequestsResponseBodyItemsAttackSourcesSources : TeaModel {
                    /// <summary>
                    /// <para>The display attribute of the source, such as the region code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>US-CA</para>
                    /// </summary>
                    [NameInMap("Attribute")]
                    [Validation(Required=false)]
                    public string Attribute { get; set; }

                    /// <summary>
                    /// <para>The source value, such as an IP address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2XX.0.113.1X</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The attack source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The evidence ID. The value can contain up to 64 ASCII characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EVD-20241025-001</para>
            /// </summary>
            [NameInMap("EvidenceId")]
            [Validation(Required=false)]
            public string EvidenceId { get; set; }

            /// <summary>
            /// <para>The host of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api.example.com</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>The HTTP response status code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("HttpStatus")]
            [Validation(Required=false)]
            public int? HttpStatus { get; set; }

            /// <summary>
            /// <para>The evidence impact tag. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>block</b>: The request is blocked.</para>
            /// </description></item>
            /// <item><description><para><b>challenge</b>: The request is challenged.</para>
            /// </description></item>
            /// <item><description><para><b>monitor</b>: The request is monitored.</para>
            /// </description></item>
            /// <item><description><para><b>bypass</b>: The request is suspected to be a bypass.</para>
            /// </description></item>
            /// <item><description><para><b>attempt</b>: The request is a reconnaissance probe.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>bypass</para>
            /// </summary>
            [NameInMap("ImpactType")]
            [Validation(Required=false)]
            public string ImpactType { get; set; }

            /// <summary>
            /// <para>The HTTP method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GET</para>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>The ID of the associated node. This ID corresponds to the NodeId in the node list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>node-109-04</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The masked request path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/api/orders/query</para>
            /// </summary>
            [NameInMap("RequestPath")]
            [Validation(Required=false)]
            public string RequestPath { get; set; }

            /// <summary>
            /// <para>The time when the original request was made. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1792973400000</para>
            /// </summary>
            [NameInMap("RequestTime")]
            [Validation(Required=false)]
            public long? RequestTime { get; set; }

            /// <summary>
            /// <para>The ID of the protected object to which the request belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// <para>Specifies whether the request is suspected to be a bypass. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The request is suspected to be a bypass.</description></item>
            /// <item><description><b>0</b>: The request is not a bypass.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SuspectedBypass")]
            [Validation(Required=false)]
            public int? SuspectedBypass { get; set; }

            /// <summary>
            /// <para>The trace ID of the original request. The value can contain up to 128 ASCII characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>trace-20241025-109-04</para>
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        /// <summary>
        /// <para>The number of entries to return on each page in a paging query. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. If a next page exists, this field returns a value.</para>
        /// <remarks>
        /// <para>If this parameter returns a value, it indicates that a next page exists. You can use the returned <b>NextToken</b> as a request parameter to obtain the data of the next page until no value is returned, which indicates that all data is obtained.</para>
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
        /// <para>01A1CEE2-<em><b><b>9-019A-8B44-2</b></b></em>C2C8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of evidence requests that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
