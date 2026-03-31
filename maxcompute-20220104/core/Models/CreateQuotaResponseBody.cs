// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateQuotaResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateQuotaResponseBodyData Data { get; set; }
        public class CreateQuotaResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>os_PayAsYouGoQuota_p</para>
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0bc520ad17171208978521777d742c</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
