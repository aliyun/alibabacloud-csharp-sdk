// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListCustomizedVoicesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCustomizedVoicesResponseBodyData Data { get; set; }
        public class ListCustomizedVoicesResponseBodyData : TeaModel {
            [NameInMap("CustomizedVoiceList")]
            [Validation(Required=false)]
            public List<ListCustomizedVoicesResponseBodyDataCustomizedVoiceList> CustomizedVoiceList { get; set; }
            public class ListCustomizedVoicesResponseBodyDataCustomizedVoiceList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><b><b>4d5e829d498aaf966b119348</b></b></para>
                /// </summary>
                [NameInMap("DemoAudioMediaId")]
                [Validation(Required=false)]
                public string DemoAudioMediaId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>male</para>
                /// </summary>
                [NameInMap("Gender")]
                [Validation(Required=false)]
                public string Gender { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>story</para>
                /// </summary>
                [NameInMap("Scenario")]
                [Validation(Required=false)]
                public string Scenario { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("VoiceDesc")]
                [Validation(Required=false)]
                public string VoiceDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xiaozhuan</para>
                /// </summary>
                [NameInMap("VoiceId")]
                [Validation(Required=false)]
                public string VoiceId { get; set; }

                [NameInMap("VoiceName")]
                [Validation(Required=false)]
                public string VoiceName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>41</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
