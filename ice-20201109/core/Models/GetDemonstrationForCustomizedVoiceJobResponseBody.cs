// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetDemonstrationForCustomizedVoiceJobResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDemonstrationForCustomizedVoiceJobResponseBodyData Data { get; set; }
        public class GetDemonstrationForCustomizedVoiceJobResponseBodyData : TeaModel {
            [NameInMap("DemonstrationList")]
            [Validation(Required=false)]
            public List<GetDemonstrationForCustomizedVoiceJobResponseBodyDataDemonstrationList> DemonstrationList { get; set; }
            public class GetDemonstrationForCustomizedVoiceJobResponseBodyDataDemonstrationList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("AudioId")]
                [Validation(Required=false)]
                public int? AudioId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://bucket.oss-cn-shanghai.aliyuncs.com/1.wav">http://bucket.oss-cn-shanghai.aliyuncs.com/1.wav</a></para>
                /// </summary>
                [NameInMap("DemoAudio")]
                [Validation(Required=false)]
                public string DemoAudio { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

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
