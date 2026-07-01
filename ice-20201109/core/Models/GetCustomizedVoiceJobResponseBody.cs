// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetCustomizedVoiceJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned if the request was successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomizedVoiceJobResponseBodyData Data { get; set; }
        public class GetCustomizedVoiceJobResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the human voice cloning job.</para>
            /// </summary>
            [NameInMap("CustomizedVoiceJob")]
            [Validation(Required=false)]
            public GetCustomizedVoiceJobResponseBodyDataCustomizedVoiceJob CustomizedVoiceJob { get; set; }
            public class GetCustomizedVoiceJobResponseBodyDataCustomizedVoiceJob : TeaModel {
                /// <summary>
                /// <para>The time when the job was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-06-07T02:27:08Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The gender. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>female</para>
                /// </description></item>
                /// <item><description><para>male</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>female</para>
                /// </summary>
                [NameInMap("Gender")]
                [Validation(Required=false)]
                public string Gender { get; set; }

                /// <summary>
                /// <para>The ID of the human voice cloning job.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b>571c704445f9a0ee011406c2</b></b></para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The status description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Training failed</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The scenario. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>story</para>
                /// </description></item>
                /// <item><description><para>interaction</para>
                /// </description></item>
                /// <item><description><para>navigation</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>story</para>
                /// </summary>
                [NameInMap("Scenario")]
                [Validation(Required=false)]
                public string Scenario { get; set; }

                /// <summary>
                /// <para>The job state. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Initialization</para>
                /// </description></item>
                /// <item><description><para>AudioDetecting</para>
                /// </description></item>
                /// <item><description><para>PreTraining</para>
                /// </description></item>
                /// <item><description><para>Training</para>
                /// </description></item>
                /// <item><description><para>Success</para>
                /// </description></item>
                /// <item><description><para>Fail</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Fail</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the human voice cloning job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Basic</para>
                /// </description></item>
                /// <item><description><para>Standard</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The voice description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>这是一个专属人声</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>Basic</para>
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
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
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
