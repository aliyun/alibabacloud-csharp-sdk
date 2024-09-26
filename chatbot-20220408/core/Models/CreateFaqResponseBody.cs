// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateFaqResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>30001979424</para>
        /// </summary>
        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public long? KnowledgeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>28805A7C-D695-548C-A31B-67E52C2C274F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
