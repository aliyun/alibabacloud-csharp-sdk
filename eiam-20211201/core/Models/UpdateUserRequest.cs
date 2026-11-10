// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateUserRequest : TeaModel {
        /// <summary>
        /// <para>The list of extended field objects.</para>
        /// </summary>
        [NameInMap("CustomFields")]
        [Validation(Required=false)]
        public List<UpdateUserRequestCustomFields> CustomFields { get; set; }
        public class UpdateUserRequestCustomFields : TeaModel {
            /// <summary>
            /// <para>The identifier of the extended field. You must create the extended field in advance. For more information, see the Extended Fields module in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nick_name</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>The value of the extended field. The value must comply with the attribute limits of the corresponding extended field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_value</para>
            /// </summary>
            [NameInMap("FieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            /// <summary>
            /// <para>The operation type of the extended field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>add: adds a value for the extended field of the account.</description></item>
            /// <item><description>replace: replaces an existing value of the extended field. If the value does not exist, the operation is converted to add.</description></item>
            /// <item><description>remove: removes the value of the extended field from the account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>add</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

        }

        /// <summary>
        /// <para>The display name of the account. The maximum length is 256 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The email address. The prefix can contain uppercase letters, lowercase letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:example@example.com">example@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>Specifies whether the email address is verified. If the email address is specified, this parameter is required. Set this parameter to true unless otherwise specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EmailVerified")]
        [Validation(Required=false)]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The phone number. It must be 6 to 15 digits in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>156xxxxxxxxx</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>Specifies whether the phone number is verified. If the phone number is specified, this parameter is required. Set this parameter to true unless otherwise specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PhoneNumberVerified")]
        [Validation(Required=false)]
        public bool? PhoneNumberVerified { get; set; }

        /// <summary>
        /// <para>The phone region code. For example, the region code for the Chinese mainland is 86. Do not include 00 or +. This parameter is required if the phone number is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86</para>
        /// </summary>
        [NameInMap("PhoneRegion")]
        [Validation(Required=false)]
        public string PhoneRegion { get; set; }

        /// <summary>
        /// <para>The account ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_d6sbsuumeta4h66ec3il7yxxxx</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The username. It can contain letters, digits, and the following special characters: underscores (_), periods (.), at signs (@), and hyphens (-). The maximum length is 256 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>username_test</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
