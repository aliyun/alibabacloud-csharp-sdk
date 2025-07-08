// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class ListOnlineEvalTaskResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>Internal error code. Set only when the response has an error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidInputParams</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>List of evaluation results.</para>
        /// </summary>
        [NameInMap("EvaluationResults")]
        [Validation(Required=false)]
        public List<string> EvaluationResults { get; set; }

        /// <summary>
        /// <para>Response error message. Set only when the response has an error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>must provide trace_id(s) or eval_id</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>22BA9A5A-E3D8-5B4C-90FC-F33F6E5853F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of evaluation results that meet the criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
