// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListResourceExecutionStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTRBMDc0NjAtRUJFNy00N0NBLTk3NTctMTJDQzQ</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ED571CBD-9F96-419D-B919-CF340BBCA157</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The execution information of the resource.</para>
        /// </summary>
        [NameInMap("ResourceExecutionStatus")]
        [Validation(Required=false)]
        public List<ListResourceExecutionStatusResponseBodyResourceExecutionStatus> ResourceExecutionStatus { get; set; }
        public class ListResourceExecutionStatusResponseBodyResourceExecutionStatus : TeaModel {
            /// <summary>
            /// <para>The ID of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exec-6be6d6ff805349d9ac13</para>
            /// </summary>
            [NameInMap("ExecutionId")]
            [Validation(Required=false)]
            public string ExecutionId { get; set; }

            /// <summary>
            /// <para>The time when the execution started running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-13T08:48:34Z</para>
            /// </summary>
            [NameInMap("ExecutionTime")]
            [Validation(Required=false)]
            public string ExecutionTime { get; set; }

            /// <summary>
            /// <para>The output of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ 				&quot;commandOutput&quot;: &quot;hello\n&quot; 			}</para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            /// <summary>
            /// <para>The ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1e1bxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The status of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
