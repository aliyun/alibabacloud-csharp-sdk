// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeAiEngineEventOperationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of event status change records, sorted in descending order by operation time.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAiEngineEventOperationsResponseBodyItems> Items { get; set; }
        public class DescribeAiEngineEventOperationsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The event processing status before the modification. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>unhandled</b>: Unprocessed.</description></item>
            /// <item><description><b>handling</b>: Processing.</description></item>
            /// <item><description><b>handled</b>: Processed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>handling</para>
            /// </summary>
            [NameInMap("FromStatus")]
            [Validation(Required=false)]
            public string FromStatus { get; set; }

            /// <summary>
            /// <para>The time of the event operation. The time is in the UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1792973400000</para>
            /// </summary>
            [NameInMap("OperatedAt")]
            [Validation(Required=false)]
            public long? OperatedAt { get; set; }

            /// <summary>
            /// <para>The ID of the operation record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>op109102</para>
            /// </summary>
            [NameInMap("OperationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

            /// <summary>
            /// <para>The event processing status after the modification. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>unhandled</b>: Unprocessed.</description></item>
            /// <item><description><b>handling</b>: Processing.</description></item>
            /// <item><description><b>handled</b>: Processed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>handled</para>
            /// </summary>
            [NameInMap("ToStatus")]
            [Validation(Required=false)]
            public string ToStatus { get; set; }

        }

        /// <summary>
        /// <para>The number of entries to return on each page during paging in a paged query. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for querying the next page. If a next page exists, this field returns a value.</para>
        /// <remarks>
        /// <para>If this parameter returns a value, it indicates that a next page exists. You can use the returned <b>NextToken</b> as a request parameter to obtain the data on the next page until no value is returned, which indicates that all data is obtained.</para>
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
        /// <para>01A1****-1219-019A-8B44-*****9C2C8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of operation records for the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
