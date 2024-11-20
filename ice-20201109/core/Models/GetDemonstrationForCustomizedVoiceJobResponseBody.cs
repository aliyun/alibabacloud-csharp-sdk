// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetDemonstrationForCustomizedVoiceJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDemonstrationForCustomizedVoiceJobResponseBodyData Data { get; set; }
        public class GetDemonstrationForCustomizedVoiceJobResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of 20 text entries to be read and the corresponding sample audio.</para>
            /// </summary>
            [NameInMap("DemonstrationList")]
            [Validation(Required=false)]
            public List<GetDemonstrationForCustomizedVoiceJobResponseBodyDataDemonstrationList> DemonstrationList { get; set; }
            public class GetDemonstrationForCustomizedVoiceJobResponseBodyDataDemonstrationList : TeaModel {
                /// <summary>
                /// <para>The sequence number of the text, which corresponds to the AduioRecordId parameter to be passed during audio check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("AudioId")]
                [Validation(Required=false)]
                public int? AudioId { get; set; }

                /// <summary>
                /// <para>The URL of the sample audio.</para>
                /// <list type="bullet">
                /// <item><description><para>The value is an Object Storage Service (OSS) URL.</para>
                /// <para>**</para>
                /// <para><b>Note</b>: The URL expires in 12 hours.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://bucket.oss-cn-shanghai.aliyuncs.com/1.wav">http://bucket.oss-cn-shanghai.aliyuncs.com/1.wav</a></para>
                /// </summary>
                [NameInMap("DemoAudio")]
                [Validation(Required=false)]
                public string DemoAudio { get; set; }

                /// <summary>
                /// <para>The text content to be read.</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

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
