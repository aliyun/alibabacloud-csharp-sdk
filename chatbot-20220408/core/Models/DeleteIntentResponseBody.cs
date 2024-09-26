// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DeleteIntentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("IntentId")]
        [Validation(Required=false)]
        public long? IntentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3464dfg3qwr34tf34</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
