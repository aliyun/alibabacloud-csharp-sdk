// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetCustomizedVoiceJobResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomizedVoiceJobResponseBodyData Data { get; set; }
        public class GetCustomizedVoiceJobResponseBodyData : TeaModel {
            [NameInMap("CustomizedVoiceJob")]
            [Validation(Required=false)]
            public GetCustomizedVoiceJobResponseBodyDataCustomizedVoiceJob CustomizedVoiceJob { get; set; }
            public class GetCustomizedVoiceJobResponseBodyDataCustomizedVoiceJob : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Gender")]
                [Validation(Required=false)]
                public string Gender { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><b><b>571c704445f9a0ee011406c2</b></b></para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Scenario")]
                [Validation(Required=false)]
                public string Scenario { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Fail</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
