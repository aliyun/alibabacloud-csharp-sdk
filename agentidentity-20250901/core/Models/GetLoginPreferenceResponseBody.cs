// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetLoginPreferenceResponseBody : TeaModel {
        /// <summary>
        /// <para>The logon preference configuration.</para>
        /// </summary>
        [NameInMap("LoginPreference")]
        [Validation(Required=false)]
        public GetLoginPreferenceResponseBodyLoginPreference LoginPreference { get; set; }
        public class GetLoginPreferenceResponseBodyLoginPreference : TeaModel {
            /// <summary>
            /// <para>Indicates whether password logon is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnablePasswordLogin")]
            [Validation(Required=false)]
            public bool? EnablePasswordLogin { get; set; }

        }

        /// <summary>
        /// <para>The password policy configuration.</para>
        /// </summary>
        [NameInMap("PasswordPolicy")]
        [Validation(Required=false)]
        public GetLoginPreferenceResponseBodyPasswordPolicy PasswordPolicy { get; set; }
        public class GetLoginPreferenceResponseBodyPasswordPolicy : TeaModel {
            /// <summary>
            /// <para>Indicates whether logon is prohibited after a password expires. A value of true indicates that the password must be reset by an administrator before the user can log on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HardExpire")]
            [Validation(Required=false)]
            public bool? HardExpire { get; set; }

            /// <summary>
            /// <para>The maximum number of consecutive logon failures. Default value: 5. This value cannot be modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MaxLoginAttempts")]
            [Validation(Required=false)]
            public long? MaxLoginAttempts { get; set; }

            /// <summary>
            /// <para>The maximum validity period of a password in days. Default value: 7. This value cannot be modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("MaxPasswordAge")]
            [Validation(Required=false)]
            public long? MaxPasswordAge { get; set; }

            /// <summary>
            /// <para>The maximum length of the password. Fixed value: 32.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("MaxPasswordLength")]
            [Validation(Required=false)]
            public int? MaxPasswordLength { get; set; }

            /// <summary>
            /// <para>The minimum length of the password. Fixed value: 8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("MinPasswordLength")]
            [Validation(Required=false)]
            public int? MinPasswordLength { get; set; }

            /// <summary>
            /// <para>Indicates whether the password must not contain the username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PasswordNotContainUserName")]
            [Validation(Required=false)]
            public bool? PasswordNotContainUserName { get; set; }

            /// <summary>
            /// <para>Indicates whether lowercase letters are required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RequireLowerCaseChars")]
            [Validation(Required=false)]
            public bool? RequireLowerCaseChars { get; set; }

            /// <summary>
            /// <para>Indicates whether numbers are required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RequireNumbers")]
            [Validation(Required=false)]
            public bool? RequireNumbers { get; set; }

            /// <summary>
            /// <para>Indicates whether special characters are required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RequireSymbols")]
            [Validation(Required=false)]
            public bool? RequireSymbols { get; set; }

            /// <summary>
            /// <para>Indicates whether uppercase letters are required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RequireUpperCaseChars")]
            [Validation(Required=false)]
            public bool? RequireUpperCaseChars { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AABD6E03-4B3A-5687-88FF-72232670ED0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
