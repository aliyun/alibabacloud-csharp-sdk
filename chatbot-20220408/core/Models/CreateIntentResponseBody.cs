// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateIntentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>43546474</para>
        /// </summary>
        [NameInMap("IntentId")]
        [Validation(Required=false)]
        public long? IntentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>df56gjh5et34g3g3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
