// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListPasskeysResponseBody : TeaModel {
        [NameInMap("Passkeys")]
        [Validation(Required=false)]
        public List<ListPasskeysResponseBodyPasskeys> Passkeys { get; set; }
        public class ListPasskeysResponseBodyPasskeys : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1737450279</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1737450390</para>
            /// </summary>
            [NameInMap("LastUseDate")]
            [Validation(Required=false)]
            public string LastUseDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PASSKEY-CuZjEHhWcr7GIQOMGvkS</para>
            /// </summary>
            [NameInMap("PasskeyId")]
            [Validation(Required=false)]
            public string PasskeyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>device1</para>
            /// </summary>
            [NameInMap("PasskeyName")]
            [Validation(Required=false)]
            public string PasskeyName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
