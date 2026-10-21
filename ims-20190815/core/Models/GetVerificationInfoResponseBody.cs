// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetVerificationInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B182C041-8C64-5F2F-A07B-FC67FAF89CF9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The security email address information.</para>
        /// </summary>
        [NameInMap("SecurityEmailDevice")]
        [Validation(Required=false)]
        public GetVerificationInfoResponseBodySecurityEmailDevice SecurityEmailDevice { get; set; }
        public class GetVerificationInfoResponseBodySecurityEmailDevice : TeaModel {
            /// <summary>
            /// <para>The security email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The status of the security email address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>active: Activated.</description></item>
            /// <item><description>pending: Pending activation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The secure phone information.</para>
        /// </summary>
        [NameInMap("SecurityPhoneDevice")]
        [Validation(Required=false)]
        public GetVerificationInfoResponseBodySecurityPhoneDevice SecurityPhoneDevice { get; set; }
        public class GetVerificationInfoResponseBodySecurityPhoneDevice : TeaModel {
            /// <summary>
            /// <para>The area code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86</para>
            /// </summary>
            [NameInMap("AreaCode")]
            [Validation(Required=false)]
            public string AreaCode { get; set; }

            /// <summary>
            /// <para>The phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13900001234</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <para>The status of the secure phone. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>active: Activated.</description></item>
            /// <item><description>pending: Pending activation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
