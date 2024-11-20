// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListCustomizedVoicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCustomizedVoicesResponseBodyData Data { get; set; }
        public class ListCustomizedVoicesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The queried personalized human voices.</para>
            /// </summary>
            [NameInMap("CustomizedVoiceList")]
            [Validation(Required=false)]
            public List<ListCustomizedVoicesResponseBodyDataCustomizedVoiceList> CustomizedVoiceList { get; set; }
            public class ListCustomizedVoicesResponseBodyDataCustomizedVoiceList : TeaModel {
                /// <summary>
                /// <para>The media asset ID of the sample audio file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b>4d5e829d498aaf966b119348</b></b></para>
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
                /// <para>male</para>
                /// </summary>
                [NameInMap("Gender")]
                [Validation(Required=false)]
                public string Gender { get; set; }

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

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>41</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
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
