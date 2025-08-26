// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeBankCardResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeBankCardResponseBodyData Data { get; set; }
        public class RecognizeBankCardResponseBodyData : TeaModel {
            [NameInMap("BankName")]
            [Validation(Required=false)]
            public string BankName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6212262315007683105</para>
            /// </summary>
            [NameInMap("CardNumber")]
            [Validation(Required=false)]
            public string CardNumber { get; set; }

            [NameInMap("CardType")]
            [Validation(Required=false)]
            public string CardType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>07/26</para>
            /// </summary>
            [NameInMap("ValidDate")]
            [Validation(Required=false)]
            public string ValidDate { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D9C7521-0367-42EE-9646-FD066CCADB26</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
