// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videorecog20200320.Models
{
    public class UnderstandVideoContentResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UnderstandVideoContentResponseBodyData Data { get; set; }
        public class UnderstandVideoContentResponseBodyData : TeaModel {
            [NameInMap("TagInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> TagInfo { get; set; }

            [NameInMap("VideoInfo")]
            [Validation(Required=false)]
            public UnderstandVideoContentResponseBodyDataVideoInfo VideoInfo { get; set; }
            public class UnderstandVideoContentResponseBodyDataVideoInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>43380</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>25.0</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public float? Fps { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1280</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public long? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>720</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public long? Width { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>71EC3F13-F0CA-4558-AC7F-A351106F59F2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
