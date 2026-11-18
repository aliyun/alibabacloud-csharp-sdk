// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateCustomFieldRequest : TeaModel {
        /// <summary>
        /// <para>The default value of the field. If the data type has configuration items, the default value must be one of the enabled configuration items. The maximum length is 1,024 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string</para>
        /// </summary>
        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// <para>The description of the field. The maximum length is 512 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test field</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the field is encrypted. If you set this parameter to true, the underlying system encrypts and stores the data value.</para>
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
        /// <para>The configuration items for the field value.</para>
        /// </summary>
        [NameInMap("FieldDataConfig")]
        [Validation(Required=false)]
        public CreateCustomFieldRequestFieldDataConfig FieldDataConfig { get; set; }
        public class CreateCustomFieldRequestFieldDataConfig : TeaModel {
            /// <summary>
            /// <para>The list of field configuration items. The maximum number of items is 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;DisplayName&quot;:&quot;Option 1&quot;,&quot;Value&quot;:&quot;option1&quot;,&quot;Status&quot;:&quot;enabled&quot;}]</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<CreateCustomFieldRequestFieldDataConfigItems> Items { get; set; }
            public class CreateCustomFieldRequestFieldDataConfigItems : TeaModel {
                /// <summary>
                /// <para>The display name of the configuration item. The maximum length is 128 characters.</para>
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
                /// <item><description>enabled: enabled.</description></item>
                /// <item><description>disabled: disabled.</description></item>
                /// </list>
                /// <para>If a configuration item is disabled, it is unavailable when you create or update the field value of the entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The value of the configuration item. The maximum length is 64 characters.</para>
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
        /// <item><description>number: number. The maximum length is 32 characters. Positive integers and decimals are supported.</description></item>
        /// <item><description>boolean: Boolean value.</description></item>
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
        /// <para>The field display name. The maximum length is 64 characters.</para>
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
        /// <item><description>input: text box. The supported data types are string and number.</description></item>
        /// <item><description>select: drop-down list. The supported data types are string and boolean.</description></item>
        /// <item><description>checkbox: check box. The supported data type is string.</description></item>
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
        /// <para>The field identifier. The maximum length is 40 characters. The value can contain lowercase English letters and underscores, and cannot start with an underscore.</para>
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
        /// <para>Specifies whether the field value is unique. If you set this parameter to true, the value of this field must be unique within the corresponding entity type and cannot be duplicated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Unique")]
        [Validation(Required=false)]
        public bool? Unique { get; set; }

        /// <summary>
        /// <para>The field permissions on the user portal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>hide: invisible on the user portal</description></item>
        /// <item><description>read_only: visible but not editable on the user portal</description></item>
        /// <item><description>read_write: visible and editable on the user portal</description></item>
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
