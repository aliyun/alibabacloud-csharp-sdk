// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetConversationDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Phrases")]
        [Validation(Required=false)]
        public List<GetConversationDetailResponseBodyPhrases> Phrases { get; set; }
        public class GetConversationDetailResponseBodyPhrases : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>240</para>
            /// </summary>
            [NameInMap("Begin")]
            [Validation(Required=false)]
            public int? Begin { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1280</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public int? End { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>agent@ccc-test</para>
            /// </summary>
            [NameInMap("Identity")]
            [Validation(Required=false)]
            public string Identity { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("Words")]
            [Validation(Required=false)]
            public string Words { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7E407F9B-A278-52A0-B193-3EE5471D7A87</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
