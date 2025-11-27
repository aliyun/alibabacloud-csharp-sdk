// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ContextualAnswerResponseBody : TeaModel {
        /// <summary>
        /// <para>Content of the response from the large model.</para>
        /// </summary>
        [NameInMap("Answer")]
        [Validation(Required=false)]
        public Answer Answer { get; set; }

        /// <summary>
        /// <para>Error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceNotFound</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource project is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID of the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22F081FB-90D7-525A-BFE4-D28DC906A28F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
