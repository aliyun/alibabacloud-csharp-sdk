// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CreateKyuubiServiceResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateKyuubiServiceResponseBodyData Data { get; set; }
        public class CreateKyuubiServiceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Kyuubi Service ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>kb-f99935b350fb4****7ef700b8b4197a3</para>
            /// </summary>
            [NameInMap("kyuubiServiceId")]
            [Validation(Required=false)]
            public string KyuubiServiceId { get; set; }

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
