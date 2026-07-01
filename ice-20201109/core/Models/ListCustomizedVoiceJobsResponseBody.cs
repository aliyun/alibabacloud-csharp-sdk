// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListCustomizedVoiceJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCustomizedVoiceJobsResponseBodyData Data { get; set; }
        public class ListCustomizedVoiceJobsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The queried human voice cloning jobs.</para>
            /// </summary>
            [NameInMap("CustomizedVoiceJobList")]
            [Validation(Required=false)]
            public List<ListCustomizedVoiceJobsResponseBodyDataCustomizedVoiceJobList> CustomizedVoiceJobList { get; set; }
            public class ListCustomizedVoiceJobsResponseBodyDataCustomizedVoiceJobList : TeaModel {
                /// <summary>
                /// <list type="bullet">
                /// <item><description><para>The time when the job was created.</para>
                /// </description></item>
                /// <item><description><para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-01T06:23:59Z</para>
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
                /// <para>The time when the job was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-06-27T02:42:28Z</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The ID of the human voice cloning job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2245ab99a7fd4116a4fd3f499b7a56c5</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The returned message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Training succeeded</para>
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
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <list type="bullet">
                /// <item><description><para>The voice type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Basic</para>
                /// </description></item>
                /// <item><description><para>Standard</para>
                /// </description></item>
                /// </list>
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
                /// <list type="bullet">
                /// <item><description>The description can be up to 256 characters in length.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>这是这个声音的描述</para>
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
                /// <list type="bullet">
                /// <item><description>The name can be up to 32 characters in length.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>小专</para>
                /// </summary>
                [NameInMap("VoiceName")]
                [Validation(Required=false)]
                public string VoiceName { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>271</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: true false</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
