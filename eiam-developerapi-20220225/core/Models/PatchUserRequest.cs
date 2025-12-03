// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class PatchUserRequest : TeaModel {
        /// <summary>
        /// <para>The extended fields of the account.</para>
        /// </summary>
        [NameInMap("customFields")]
        [Validation(Required=false)]
        public List<PatchUserRequestCustomFields> CustomFields { get; set; }
        public class PatchUserRequestCustomFields : TeaModel {
            /// <summary>
            /// <para>The name of the extended field. For more information about the type and valid values of the extended field, see the detailed description of the extended field in the IDaaS console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>age</para>
            /// </summary>
            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>The value of the extended field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_value</para>
            /// </summary>
            [NameInMap("fieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            /// <summary>
            /// <para>The operation to be performed on the field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>add</description></item>
            /// <item><description>replace If you leave the value of the extended field empty, the replace operation is converted to an add operation.</description></item>
            /// <item><description>remove</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>replace</para>
            /// </summary>
            [NameInMap("operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The type of the operation. This parameter is deprecated. Replace it with operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>replace</para>
            /// </summary>
            [NameInMap("operator")]
            [Validation(Required=false)]
            [Obsolete]
            public string Operator { get; set; }

        }

        /// <summary>
        /// <para>The display name of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>display_name001</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The email address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:example@example.com">example@example.com</a></para>
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>Specifies whether the email address is verified. This field is required if an email address is specified. If you have no special requirement, set this parameter to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("emailVerified")]
        [Validation(Required=false)]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// <para>The mobile number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>156xxxxxxx</para>
        /// </summary>
        [NameInMap("phoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>Specifies whether the mobile number is verified. This field is required if a mobile number is specified. If you have no special requirement, set this parameter to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("phoneNumberVerified")]
        [Validation(Required=false)]
        public bool? PhoneNumberVerified { get; set; }

        /// <summary>
        /// <para>The country code of the mobile number. For example, the country code of China is 86 without 00 or +. This parameter is required if a mobile number is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("phoneRegion")]
        [Validation(Required=false)]
        public string PhoneRegion { get; set; }

        /// <summary>
        /// <para>The name of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name001</para>
        /// </summary>
        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
