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
                /// <item><description>The time when the job was created.</description></item>
                /// <item><description>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</description></item>
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
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The scenario. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>story</description></item>
                /// <item><description>interaction</description></item>
                /// <item><description>navigation</description></item>
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
                /// <item><description>Initialization</description></item>
                /// <item><description>AudioDetecting</description></item>
                /// <item><description>PreTraining</description></item>
                /// <item><description>Training</description></item>
                /// <item><description>Success</description></item>
                /// <item><description>Fail</description></item>
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
                /// <item><description>Basic</description></item>
                /// <item><description>Standard</description></item>
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
