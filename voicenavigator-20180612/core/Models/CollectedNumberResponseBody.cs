// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class CollectedNumberResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Broadcast</para>
        /// </summary>
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;duration\&quot;:31340,\&quot;endTime\&quot;:1638243934786,\&quot;hangUpDirection\&quot;:\&quot;ivr\&quot;,\&quot;startTime\&quot;:1638243903446}</para>
        /// </summary>
        [NameInMap("ActionParams")]
        [Validation(Required=false)]
        public string ActionParams { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Interruptible")]
        [Validation(Required=false)]
        public bool? Interruptible { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>da37319b-6c83-4268-9f19-814aed62e401</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TextResponse")]
        [Validation(Required=false)]
        public string TextResponse { get; set; }

    }

}
