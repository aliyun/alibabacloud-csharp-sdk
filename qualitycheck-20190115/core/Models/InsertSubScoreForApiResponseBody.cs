// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class InsertSubScoreForApiResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public InsertSubScoreForApiResponseBodyData Data { get; set; }
        public class InsertSubScoreForApiResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>5730</para>
            /// </summary>
            [NameInMap("ScoreSubId")]
            [Validation(Required=false)]
            public long? ScoreSubId { get; set; }

            [NameInMap("ScoreSubName")]
            [Validation(Required=false)]
            public string ScoreSubName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D34079C5-AA2F-490E-ADD8-5BFF08AAE207</para>
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
