// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class DeleteRankingModelResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D486768B-8BF8-4D80-B491-43DC3D0AF8AB</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public DeleteRankingModelResponseBodyResult Result { get; set; }
        public class DeleteRankingModelResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>meta</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public Dictionary<string, object> Meta { get; set; }

            [NameInMap("rankingModelId")]
            [Validation(Required=false)]
            public string RankingModelId { get; set; }

        }

    }

}
