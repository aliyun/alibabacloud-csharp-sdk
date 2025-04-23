// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class EvaluateTraceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidInputParams</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6000043e103011f0922edec44617e03c</para>
        /// </summary>
        [NameInMap("EvaluationId")]
        [Validation(Required=false)]
        public string EvaluationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eval_request missing dataset id or times</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F1AB295E-0D1F-5ECE-9FFA-98ABB4CB5DF5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
