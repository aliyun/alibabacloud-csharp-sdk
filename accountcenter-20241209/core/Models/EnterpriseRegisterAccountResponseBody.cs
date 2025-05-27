// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AccountCenter20241209.Models
{
    public class EnterpriseRegisterAccountResponseBody : TeaModel {
        [NameInMap("AccountInfo")]
        [Validation(Required=false)]
        public EnterpriseRegisterAccountResponseBodyAccountInfo AccountInfo { get; set; }
        public class EnterpriseRegisterAccountResponseBodyAccountInfo : TeaModel {
            [NameInMap("EnterpriseLicenseNo")]
            [Validation(Required=false)]
            public string EnterpriseLicenseNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>海南屿可网络科技有限公司</para>
            /// </summary>
            [NameInMap("EnterpriseName")]
            [Validation(Required=false)]
            public string EnterpriseName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>195529</para>
            /// </summary>
            [NameInMap("LoginId")]
            [Validation(Required=false)]
            public string LoginId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5190216604405754</para>
            /// </summary>
            [NameInMap("Pk")]
            [Validation(Required=false)]
            public string Pk { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The operation is not allowed. Channel state (RELEASED) does not meet expectations (ANSWERED).</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BDFCF081-7BCD-52D5-9D82-0F58D96EFD92</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
