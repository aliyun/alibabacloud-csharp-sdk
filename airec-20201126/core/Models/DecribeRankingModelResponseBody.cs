// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class DecribeRankingModelResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>829F38F6-E2D6-4109-90A6-888160BD16C2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DecribeRankingModelResponseBodyResult Result { get; set; }
        public class DecribeRankingModelResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the ranking model was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-07T02:24:26.000Z</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the ranking model was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-04-27T06:38:28.000Z</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The metadata.</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public Dictionary<string, object> Meta { get; set; }

            /// <summary>
            /// <para>The ID of the ranking model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ranktest</para>
            /// </summary>
            [NameInMap("rankingModelId")]
            [Validation(Required=false)]
            public string RankingModelId { get; set; }

        }

    }

}
