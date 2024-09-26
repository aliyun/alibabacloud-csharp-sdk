// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DeleteDocResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>30002406051</para>
        /// </summary>
        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public long? KnowledgeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DFB71B34-4188-4EA2-9988-EF3014E75910</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
