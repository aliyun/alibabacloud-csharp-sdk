// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class UpdateIntentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>234234234534</para>
        /// </summary>
        [NameInMap("IntentId")]
        [Validation(Required=false)]
        public long? IntentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dfaf23dfas234234234534</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
