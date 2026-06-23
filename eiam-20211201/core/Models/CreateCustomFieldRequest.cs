// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateCustomFieldRequest : TeaModel {
        /// <summary>
        /// <para>The default value of the field.
        /// If configuration items exist for the type, the default value must be one of the configuration items and must be in the enabled state. Maximum length: 1024 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string</para>
        /// </summary>
        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// <para>The field description.
        /// Maximum length: 512 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Field test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to encrypt the field.
        /// If this parameter is set to true, the data value is encrypted at the storage layer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// <para>The entity to which the field belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>user: account.</description></item>
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
        /// <para>The field value configuration items.</para>
        /// </summary>
        [NameInMap("FieldDataConfig")]
        [Validation(Required=false)]
        public CreateCustomFieldRequestFieldDataConfig FieldDataConfig { get; set; }
        public class CreateCustomFieldRequestFieldDataConfig : TeaModel {
            /// <summary>
            /// <para>The list of field configuration items. Maximum number of items: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<CreateCustomFieldRequestFieldDataConfigItems> Items { get; set; }
            public class CreateCustomFieldRequestFieldDataConfigItems : TeaModel {
                /// <summary>
                /// <para>The display name of the configuration item.
                /// Maximum length: 128 characters.</para>
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
                /// <item><description>enabled: Enabled.</description></item>
                /// <item><description>disabled: Disabled.</description></item>
                /// </list>
                /// <para>If a configuration item is disabled, it cannot be used when creating or updating entity field values.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The display value of the configuration item.
                /// Maximum length: 64 characters.</para>
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
        /// <item><description>string: string.</description></item>
        /// <item><description>number: number. Maximum length: 32 characters. Positive integers and decimals are supported.</description></item>
        /// <item><description>boolean: Boolean.</description></item>
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
        /// <para>The field display name.
        /// Maximum length: 64 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name_001</para>
        /// </summary>
        [NameInMap("FieldDisplayName")]
        [Validation(Required=false)]
        public string FieldDisplayName { get; set; }

        /// <summary>
        /// <para>The field display type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>input: text input box. Supported data types: string and number.</description></item>
        /// <item><description>select: drop-down list. Supported data types: string and boolean.</description></item>
        /// <item><description>checkbox: multi-select box. Supported data types: string.</description></item>
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
        /// <para>The field identifier.
        /// Maximum length: 40 characters. The value can contain lowercase letters and underscores, and cannot start with an underscore.</para>
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
        /// <para>Specifies whether the field is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Required")]
        [Validation(Required=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// <para>Specifies whether the field value is unique.
        /// If this parameter is set to true, the field value must be unique within the corresponding entity type and cannot be duplicated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Unique")]
        [Validation(Required=false)]
        public bool? Unique { get; set; }

        /// <summary>
        /// <para>The field permission on the portal side. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>hide: Not visible on the portal side.</description></item>
        /// <item><description>read_only: Visible on the portal side but cannot be edited or updated.</description></item>
        /// <item><description>read_write: Visible and editable on the portal side.</description></item>
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
