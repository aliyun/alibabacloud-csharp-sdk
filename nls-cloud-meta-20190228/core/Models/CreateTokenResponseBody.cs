// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nls_cloud_meta20190228.Models
{
    public class CreateTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>50000000</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public int? ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Specified access key is not found.</para>
        /// </summary>
        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dd05a301b40441c99a2671905325****</para>
        /// </summary>
        [NameInMap("NlsRequestId")]
        [Validation(Required=false)]
        public string NlsRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A51587CB-5193-4DB8-9AED-CD4365C2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public CreateTokenResponseBodyToken Token { get; set; }
        public class CreateTokenResponseBodyToken : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1553825814</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public int? ExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fb1c4648a61b426589dab0fe90d1****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>107992689699****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
