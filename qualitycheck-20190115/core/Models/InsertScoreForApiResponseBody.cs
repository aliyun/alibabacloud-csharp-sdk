// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class InsertScoreForApiResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public InsertScoreForApiResponseBodyData Data { get; set; }
        public class InsertScoreForApiResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>5728</para>
            /// </summary>
            [NameInMap("ScoreId")]
            [Validation(Required=false)]
            public long? ScoreId { get; set; }

            [NameInMap("ScoreName")]
            [Validation(Required=false)]
            public string ScoreName { get; set; }

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
        /// <para>96138D8D-8D26-4E41-BFF4-77AED1088BBD</para>
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
