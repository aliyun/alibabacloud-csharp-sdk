// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateCustomFieldRequest : TeaModel {
        /// <summary>
        /// <para>The default value of the field. If the field has configuration items, the default value must be one of the enabled configuration items. The default value can be up to 1024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string</para>
        /// </summary>
        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// <para>The description of the field. The description can be up to 512 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Field test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether to encrypt the field value. If you set this parameter to true, the system encrypts the data value before storing it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// <para>The entity to which the field belongs. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>user: an account.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The configuration items of the field value.</para>
        /// </summary>
        [NameInMap("FieldDataConfig")]
        [Validation(Required=false)]
        public CreateCustomFieldRequestFieldDataConfig FieldDataConfig { get; set; }
        public class CreateCustomFieldRequestFieldDataConfig : TeaModel {
            /// <summary>
            /// <para>A list of field configuration items. The list can contain up to 100 items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<CreateCustomFieldRequestFieldDataConfigItems> Items { get; set; }
            public class CreateCustomFieldRequestFieldDataConfigItems : TeaModel {
                /// <summary>
                /// <para>The display name of the configuration item. The display name can be up to 128 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The status of the configuration item. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>enabled: The configuration item is enabled.</para>
                /// </description></item>
                /// <item><description><para>disabled: The configuration item is disabled.</para>
                /// </description></item>
                /// </list>
                /// <para>If a configuration item is disabled, it is unavailable when you create or update the field value for an entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The value of the configuration item. The value can be up to 64 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The data type of the field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>string: a string.</para>
        /// </description></item>
        /// <item><description><para>number: a number. The number can be up to 32 digits in length and can be a positive integer or a decimal.</para>
        /// </description></item>
        /// <item><description><para>boolean: a Boolean value.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string</para>
        /// </summary>
        [NameInMap("FieldDataType")]
        [Validation(Required=false)]
        public string FieldDataType { get; set; }

        /// <summary>
        /// <para>The display name of the field. The display name can be up to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name_001</para>
        /// </summary>
        [NameInMap("FieldDisplayName")]
        [Validation(Required=false)]
        public string FieldDisplayName { get; set; }

        /// <summary>
        /// <para>The display type of the field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>input: a text box. This display type supports the string and number data types.</para>
        /// </description></item>
        /// <item><description><para>select: a drop-down list. This display type supports the string and Boolean data types.</para>
        /// </description></item>
        /// <item><description><para>checkbox: a check box. This display type supports the string data type.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>input</para>
        /// </summary>
        [NameInMap("FieldDisplayType")]
        [Validation(Required=false)]
        public string FieldDisplayType { get; set; }

        /// <summary>
        /// <para>The name of the field. The name can be up to 40 characters in length and can contain lowercase letters and underscores (<em>). It cannot start with an underscore (</em>).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>field_001</para>
        /// </summary>
        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

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
        /// <para>Indicates whether the field is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Required")]
        [Validation(Required=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// <para>Indicates whether the field value is unique. If you set this parameter to true, the value of this field must be unique for the specified entity type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Unique")]
        [Validation(Required=false)]
        public bool? Unique { get; set; }

        /// <summary>
        /// <para>The permission on the field in the portal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>hide: The field is not visible in the portal.</para>
        /// </description></item>
        /// <item><description><para>read_only: The field is visible but cannot be modified in the portal.</para>
        /// </description></item>
        /// <item><description><para>read_write: The field is visible and can be modified in the portal.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UserPermission")]
        [Validation(Required=false)]
        public string UserPermission { get; set; }

    }

}
