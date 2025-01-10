// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class GetCartoonResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0EC7*726E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetCartoonResponseBodyResult Result { get; set; }
        public class GetCartoonResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://ai***.mp4">https://ai***.mp4</a></para>
            /// </summary>
            [NameInMap("StartVideoMd5")]
            [Validation(Required=false)]
            public string StartVideoMd5 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>40c8***97</para>
            /// </summary>
            [NameInMap("StartVideoUrl")]
            [Validation(Required=false)]
            public string StartVideoUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

    }

}
