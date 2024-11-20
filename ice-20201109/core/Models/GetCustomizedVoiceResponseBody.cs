// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetCustomizedVoiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomizedVoiceResponseBodyData Data { get; set; }
        public class GetCustomizedVoiceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The personalized human voice.</para>
            /// </summary>
            [NameInMap("CustomizedVoice")]
            [Validation(Required=false)]
            public GetCustomizedVoiceResponseBodyDataCustomizedVoice CustomizedVoice { get; set; }
            public class GetCustomizedVoiceResponseBodyDataCustomizedVoice : TeaModel {
                /// <summary>
                /// <para>The media asset ID of the sample audio file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b>42d3c312402982be65975f5b</b></b></para>
                /// </summary>
                [NameInMap("DemoAudioMediaId")]
                [Validation(Required=false)]
                public string DemoAudioMediaId { get; set; }

                /// <summary>
                /// <para>The gender. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>female</description></item>
                /// <item><description>male</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>female</para>
                /// </summary>
                [NameInMap("Gender")]
                [Validation(Required=false)]
                public string Gender { get; set; }

                /// <summary>
                /// <para>The demonstration scenario.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>story</b></description></item>
                /// <item><description><b>interaction</b></description></item>
                /// <item><description><b>navigation</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>interaction</para>
                /// </summary>
                [NameInMap("Scenario")]
                [Validation(Required=false)]
                public string Scenario { get; set; }

                /// <summary>
                /// <para>The voice description.</para>
                /// </summary>
                [NameInMap("VoiceDesc")]
                [Validation(Required=false)]
                public string VoiceDesc { get; set; }

                /// <summary>
                /// <para>The voice ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xiaozhuan</para>
                /// </summary>
                [NameInMap("VoiceId")]
                [Validation(Required=false)]
                public string VoiceId { get; set; }

                /// <summary>
                /// <para>The voice name.</para>
                /// </summary>
                [NameInMap("VoiceName")]
                [Validation(Required=false)]
                public string VoiceName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
