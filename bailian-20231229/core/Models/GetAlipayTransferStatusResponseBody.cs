// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetAlipayTransferStatusResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAlipayTransferStatusResponseBodyData Data { get; set; }
        public class GetAlipayTransferStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1348393307144609</para>
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("alipayOrderDetail")]
            [Validation(Required=false)]
            public string AlipayOrderDetail { get; set; }

            [NameInMap("alipayOrderId")]
            [Validation(Required=false)]
            public string AlipayOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1007576424487905</para>
            /// </summary>
            [NameInMap("mainAccountId")]
            [Validation(Required=false)]
            public string MainAccountId { get; set; }

            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            [NameInMap("qrURL")]
            [Validation(Required=false)]
            public string QrURL { get; set; }

            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("transAmount")]
            [Validation(Required=false)]
            public string TransAmount { get; set; }

            [NameInMap("walletItemCode")]
            [Validation(Required=false)]
            public string WalletItemCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6a71f2d9-f1c9-913b-818b-11402910xxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
