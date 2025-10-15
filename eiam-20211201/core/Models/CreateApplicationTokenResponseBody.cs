// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateApplicationTokenResponseBody : TeaModel {
        [NameInMap("ApplicationTokens")]
        [Validation(Required=false)]
        public CreateApplicationTokenResponseBodyApplicationTokens ApplicationTokens { get; set; }
        public class CreateApplicationTokenResponseBodyApplicationTokens : TeaModel {
            /// <summary>
            /// <para>应用token</para>
            /// 
            /// <b>Example:</b>
            /// <para>SATFwqX8zxGf83pJcJw78KFGjmrft4erWeZYBGS8oE7NN6qoE217yaJpUdMb1UuuGqhDiF43sCA4CF91CTL5iGntqwyLuaAcS9FJ9HfGadE5a7TjiwVafwrBYkt3XXX</para>
            /// </summary>
            [NameInMap("ApplicationToken")]
            [Validation(Required=false)]
            public string ApplicationToken { get; set; }

            /// <summary>
            /// <para>应用token ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>token_ndfxxigahelfne2y2hodehrxxxx</para>
            /// </summary>
            [NameInMap("ApplicationTokenId")]
            [Validation(Required=false)]
            public string ApplicationTokenId { get; set; }

            /// <summary>
            /// <para>应用token类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>bearer_token</para>
            /// </summary>
            [NameInMap("ApplicationTokenType")]
            [Validation(Required=false)]
            public string ApplicationTokenType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
