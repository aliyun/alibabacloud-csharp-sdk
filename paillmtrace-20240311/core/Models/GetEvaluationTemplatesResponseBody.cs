// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class GetEvaluationTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>Internal error code. Set only when the response has an error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExecutionFailure</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>A series of templates used internally by the evaluation system to construct LLM interaction information.</para>
        /// </summary>
        [NameInMap("EvaluationTemplates")]
        [Validation(Required=false)]
        public List<object> EvaluationTemplates { get; set; }

        /// <summary>
        /// <para>Response error message. Set only when the response has an error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cannot get data back.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A87228C-969A-1381-98CF-AE07AE630FA5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
