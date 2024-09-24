// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetCustomizedVoiceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomizedVoiceResponseBodyData Data { get; set; }
        public class GetCustomizedVoiceResponseBodyData : TeaModel {
            [NameInMap("CustomizedVoice")]
            [Validation(Required=false)]
            public GetCustomizedVoiceResponseBodyDataCustomizedVoice CustomizedVoice { get; set; }
            public class GetCustomizedVoiceResponseBodyDataCustomizedVoice : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><b><b>42d3c312402982be65975f5b</b></b></para>
                /// </summary>
                [NameInMap("DemoAudioMediaId")]
                [Validation(Required=false)]
                public string DemoAudioMediaId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>female</para>
                /// </summary>
                [NameInMap("Gender")]
                [Validation(Required=false)]
                public string Gender { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>interaction</para>
                /// </summary>
                [NameInMap("Scenario")]
                [Validation(Required=false)]
                public string Scenario { get; set; }

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

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
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
