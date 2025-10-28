// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CreateKyuubiTokenResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateKyuubiTokenResponseBodyData Data { get; set; }
        public class CreateKyuubiTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Token ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>tk-zpi0*****hdv4y</para>
            /// </summary>
            [NameInMap("tokenId")]
            [Validation(Required=false)]
            public string TokenId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
