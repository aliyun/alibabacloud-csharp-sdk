// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListWhitePortalMenuResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DC4E1**********0DF67E2C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListWhitePortalMenuResponseBodyResult> Result { get; set; }
        public class ListWhitePortalMenuResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AuthPointsValue")]
            [Validation(Required=false)]
            public int? AuthPointsValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8a4***********1e769</para>
            /// </summary>
            [NameInMap("ReceiverId")]
            [Validation(Required=false)]
            public string ReceiverId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ReceiverType")]
            [Validation(Required=false)]
            public int? ReceiverType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
