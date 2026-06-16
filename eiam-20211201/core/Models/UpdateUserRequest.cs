// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateUserRequest : TeaModel {
        /// <summary>
        /// <para>A list of custom field objects.</para>
        /// </summary>
        [NameInMap("CustomFields")]
        [Validation(Required=false)]
        public List<UpdateUserRequestCustomFields> CustomFields { get; set; }
        public class UpdateUserRequestCustomFields : TeaModel {
            /// <summary>
            /// <para>The custom field name. You must create the custom field in the console before using it. For more information, see the custom fields module in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nick_name</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>The custom field value. The value must comply with the constraints of the custom field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_value</para>
            /// </summary>
            [NameInMap("FieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            /// <summary>
            /// <para>The operation type for the custom field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>add</c>: Adds a value to the custom field.</para>
            /// </description></item>
            /// <item><description><para><c>replace</c>: Replaces the existing value of the custom field. If the field has no existing value, this operation adds the value instead.</para>
            /// </description></item>
            /// <item><description><para><c>remove</c>: Removes a value from the custom field.</para>
            /// </description></item>
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
        /// <para>The display name. It can be a maximum of 256 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The email address. The local-part can contain uppercase letters, lowercase letters, digits, dots (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:example@example.com">example@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>Indicates whether the email address is verified. This parameter is required when specifying an email address. In most cases, set this to <c>true</c>.</para>
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
        /// <para>The mobile phone number. It must be between 6 and 15 digits long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>156xxxxxxxxx</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>Indicates whether the mobile phone number is verified. This parameter is required when specifying a mobile phone number. In most cases, set this to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PhoneNumberVerified")]
        [Validation(Required=false)]
        public bool? PhoneNumberVerified { get; set; }

        /// <summary>
        /// <para>The country code for the mobile phone number. Example: 86 for Chinese mainland. Do not include <c>00</c> or <c>+</c>. This parameter is required if you specify a mobile phone number.</para>
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
        /// <para>The username. It must be no more than 256 characters and can contain letters, digits, and the special characters: _, ., @, and -.</para>
        /// 
        /// <b>Example:</b>
        /// <para>username_test</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
