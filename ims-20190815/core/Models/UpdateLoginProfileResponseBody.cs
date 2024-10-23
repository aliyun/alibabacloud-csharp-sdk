// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateLoginProfileResponseBody : TeaModel {
        /// <summary>
        /// <para>The logon information.</para>
        /// </summary>
        [NameInMap("LoginProfile")]
        [Validation(Required=false)]
        public UpdateLoginProfileResponseBodyLoginProfile LoginProfile { get; set; }
        public class UpdateLoginProfileResponseBodyLoginProfile : TeaModel {
            /// <summary>
            /// <para>Indicates whether MFA must be enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("MFABindRequired")]
            [Validation(Required=false)]
            public bool? MFABindRequired { get; set; }

            /// <summary>
            /// <para>Indicates whether the RAM user must reset the password at the next logon.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PasswordResetRequired")]
            [Validation(Required=false)]
            public bool? PasswordResetRequired { get; set; }

            /// <summary>
            /// <para>The status of password-based logon.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-14T07:48:41Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

            /// <summary>
            /// <para>The logon name of the RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@example11.onaliyun.com">test@example11.onaliyun.com</a></para>
            /// </summary>
            [NameInMap("UserPrincipalName")]
            [Validation(Required=false)]
            public string UserPrincipalName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BCDB6A7F-2199-41D9-B577-4FA536A5ADE1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
