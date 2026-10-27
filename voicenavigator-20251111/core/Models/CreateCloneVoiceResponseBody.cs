// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class CreateCloneVoiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The internal error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The cloned voice object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateCloneVoiceResponseBodyData Data { get; set; }
        public class CreateCloneVoiceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cloned voice ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8ee1160a-6999-478f-8df6-f33ef21f27d5</para>
            /// </summary>
            [NameInMap("CloneVoiceId")]
            [Validation(Required=false)]
            public string CloneVoiceId { get; set; }

            /// <summary>
            /// <para>The speaker.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cosyvoice-v3-plus-voicebot2-3666e4bbb2b94832ac4f4107b5804c34</para>
            /// </summary>
            [NameInMap("Voice")]
            [Validation(Required=false)]
            public string Voice { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance af81a389-91f0-4157-8d82-720edd02b66a
        ///  does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of dynamic error parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F132DDBA-66C4-5BD3-BF7E-9642FE877158</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
