// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videorecog20200320.Models
{
    public class GetAsyncJobResultResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAsyncJobResultResponseBodyData Data { get; set; }
        public class GetAsyncJobResultResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>InvalidParameter</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>paramsIllegal</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7DFDA846-178B-4ADB-B69A-62C641214D81</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;Outputs\&quot;:[{\&quot;ImageURL\&quot;:\&quot;<a href="http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/video-cover/2020-03-25-11/pic_4t7zW6R6SUGn4DLF.mp4_2375_1920_1080_96ce5a96b5b16628cd778c035b68356d_beautified.png?Expires=1585136160&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=MDd7BqbivlLRd16MTKbPFQHV3u****%5C%5C%22,%5C%5C%22Confidence%5C%5C%22:8.426481079120514%7D,%7B%5C%5C%22ImageURL%5C%5C%22:%5C%5C%22http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/video-cover/2020-03-25-11/pic_4t7zW6R6SUGn4DLF.mp4_2996_1920_1080_d5df0556bf420242c84fe6f7a45d01e1_beautified.png?Expires=1585136160&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&Signature=htaW5G%2BpqPBW%2BEMTe01ckVoGsQ****%5C%5C%22,%5C%5C%22Confidence%5C%5C%22:6.225726566341124%7D%5D%7D">http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/video-cover/2020-03-25-11/pic_4t7zW6R6SUGn4DLF.mp4_2375_1920_1080_96ce5a96b5b16628cd778c035b68356d_beautified.png?Expires=1585136160&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=MDd7BqbivlLRd16MTKbPFQHV3u****\\&quot;,\\&quot;Confidence\\&quot;:8.426481079120514},{\\&quot;ImageURL\\&quot;:\\&quot;http://algo-app-aic-vd-cn-shanghai-prod.oss-cn-shanghai.aliyuncs.com/video-cover/2020-03-25-11/pic_4t7zW6R6SUGn4DLF.mp4_2996_1920_1080_d5df0556bf420242c84fe6f7a45d01e1_beautified.png?Expires=1585136160&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSRp****&amp;Signature=htaW5G%2BpqPBW%2BEMTe01ckVoGsQ****\\&quot;,\\&quot;Confidence\\&quot;:6.225726566341124}]}</a></para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PROCESS_SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A1F44EC4-118D-4A03-B213-F908F36F7DAA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
