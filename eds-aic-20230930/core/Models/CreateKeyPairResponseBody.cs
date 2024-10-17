// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateKeyPairResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateKeyPairResponseBodyData Data { get; set; }
        public class CreateKeyPairResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-06-30 08:45:09.0</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>kp-6v2q33ae4tw3*****</para>
            /// </summary>
            [NameInMap("KeyPairId")]
            [Validation(Required=false)]
            public string KeyPairId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testKeyPairName</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MIIEpAIBAAKCAQEAtReyMzLIcBH78EV2zj****</para>
            /// </summary>
            [NameInMap("PrivateKeyBody")]
            [Validation(Required=false)]
            public string PrivateKeyBody { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>69BCBBE4-FCF2-59B8-AD9D-531EB422****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
