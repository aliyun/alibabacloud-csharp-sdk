// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetVerificationInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>B182C041-8C64-5F2F-A07B-FC67FAF89CF9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityEmailDevice")]
        [Validation(Required=false)]
        public GetVerificationInfoResponseBodySecurityEmailDevice SecurityEmailDevice { get; set; }
        public class GetVerificationInfoResponseBodySecurityEmailDevice : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("SecurityPhoneDevice")]
        [Validation(Required=false)]
        public GetVerificationInfoResponseBodySecurityPhoneDevice SecurityPhoneDevice { get; set; }
        public class GetVerificationInfoResponseBodySecurityPhoneDevice : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>86</para>
            /// </summary>
            [NameInMap("AreaCode")]
            [Validation(Required=false)]
            public string AreaCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13900001234</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
