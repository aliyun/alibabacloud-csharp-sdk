// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ImportKeyPairResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImportKeyPairResponseBodyData Data { get; set; }
        public class ImportKeyPairResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-03-05T10:29:22Z</para>
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
            /// <para>TestKeyPairName</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

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
