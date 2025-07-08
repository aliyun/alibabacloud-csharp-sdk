// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class ListTracesDatasResponseBody : TeaModel {
        /// <summary>
        /// <para>The internal error code. This parameter is returned only when an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExecutionFailure</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is returned only when an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>failed to get trace data</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>POP request id</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A87228C-969A-1381-98CF-AE07AE630FA5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of traces that meet the condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The JSON array with each element being a trace\&quot;s JSON string. Length of the array is equal to or less than the page size parameter value.</para>
        /// </summary>
        [NameInMap("Traces")]
        [Validation(Required=false)]
        public List<object> Traces { get; set; }

    }

}
