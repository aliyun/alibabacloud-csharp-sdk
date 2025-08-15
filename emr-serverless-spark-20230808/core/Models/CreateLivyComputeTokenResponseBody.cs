// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CreateLivyComputeTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1000000</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateLivyComputeTokenResponseBodyData Data { get; set; }
        public class CreateLivyComputeTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Token ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>lctk-xxxxxxxx</para>
            /// </summary>
            [NameInMap("tokenId")]
            [Validation(Required=false)]
            public string TokenId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
