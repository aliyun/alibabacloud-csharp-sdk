// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateCustomFieldRequest : TeaModel {
        /// <summary>
        /// <para>字段默认值，必须与数据类型一致</para>
        /// 
        /// <b>Example:</b>
        /// <para>string</para>
        /// </summary>
        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// <para>对字段的描述信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>字段测试</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>是否加密，默认false</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// <para>字段归属实体。实体包括账户、组、组织</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>字段值配置项，必须与数据类型一致</para>
        /// </summary>
        [NameInMap("FieldDataConfig")]
        [Validation(Required=false)]
        public CreateCustomFieldRequestFieldDataConfig FieldDataConfig { get; set; }
        public class CreateCustomFieldRequestFieldDataConfig : TeaModel {
            /// <summary>
            /// <para>字段值配置项，必须与数据类型一致，只能新增数据项，不可删除，项字段：displayName、value、status</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<CreateCustomFieldRequestFieldDataConfigItems> Items { get; set; }
            public class CreateCustomFieldRequestFieldDataConfigItems : TeaModel {
                /// <summary>
                /// <para>配置项展示名</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>配置项状态，枚举值，enabled、disabled</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>配置项展示值</para>
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
        /// <para>数据类型，枚举值：string、number、boolean</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string</para>
        /// </summary>
        [NameInMap("FieldDataType")]
        [Validation(Required=false)]
        public string FieldDataType { get; set; }

        /// <summary>
        /// <para>字段展示名，长度不超过128字符</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name_001</para>
        /// </summary>
        [NameInMap("FieldDisplayName")]
        [Validation(Required=false)]
        public string FieldDisplayName { get; set; }

        /// <summary>
        /// <para>字段展示类型，枚举值，select、checkbox、input</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>input</para>
        /// </summary>
        [NameInMap("FieldDisplayType")]
        [Validation(Required=false)]
        public string FieldDisplayType { get; set; }

        /// <summary>
        /// <para>字段标识，英文字母、下划线</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>field_001</para>
        /// </summary>
        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// <para>IDaaS EIAM实例的ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>是否必填，默认false</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Required")]
        [Validation(Required=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// <para>是否唯一，默认false</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Unique")]
        [Validation(Required=false)]
        public bool? Unique { get; set; }

        /// <summary>
        /// <para>用户端(portal侧)权限，hide、read_only、read_write，默认read_only</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UserPermission")]
        [Validation(Required=false)]
        public string UserPermission { get; set; }

    }

}
