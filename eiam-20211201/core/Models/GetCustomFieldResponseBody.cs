// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetCustomFieldResponseBody : TeaModel {
        [NameInMap("CustomField")]
        [Validation(Required=false)]
        public GetCustomFieldResponseBodyCustomField CustomField { get; set; }
        public class GetCustomFieldResponseBodyCustomField : TeaModel {
            /// <summary>
            /// <para>扩展字段创建时间，Unix时间戳格式，单位为毫秒</para>
            /// 
            /// <b>Example:</b>
            /// <para>17642960730</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>字段默认值</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// <para>扩展字段描述</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
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
            /// <para>字段所属实体类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// <para>字段值配置项</para>
            /// </summary>
            [NameInMap("FieldDataConfig")]
            [Validation(Required=false)]
            public GetCustomFieldResponseBodyCustomFieldFieldDataConfig FieldDataConfig { get; set; }
            public class GetCustomFieldResponseBodyCustomFieldFieldDataConfig : TeaModel {
                /// <summary>
                /// <para>字段配置项列表，displayName、value、status</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetCustomFieldResponseBodyCustomFieldFieldDataConfigItems> Items { get; set; }
                public class GetCustomFieldResponseBodyCustomFieldFieldDataConfigItems : TeaModel {
                    /// <summary>
                    /// <para>配置项展示名</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hobby</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>配置项状态, 枚举值，enabled、disabled</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>enabled</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>配置项值</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>game</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>数据类型，枚举值：string、number、boolean</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("FieldDataType")]
            [Validation(Required=false)]
            public string FieldDataType { get; set; }

            /// <summary>
            /// <para>字段展示名</para>
            /// 
            /// <b>Example:</b>
            /// <para>userId</para>
            /// </summary>
            [NameInMap("FieldDisplayName")]
            [Validation(Required=false)]
            public string FieldDisplayName { get; set; }

            /// <summary>
            /// <para>字段展示类型，枚举值，select、checkbox、input、number</para>
            /// 
            /// <b>Example:</b>
            /// <para>input</para>
            /// </summary>
            [NameInMap("FieldDisplayType")]
            [Validation(Required=false)]
            public string FieldDisplayType { get; set; }

            /// <summary>
            /// <para>字段ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>ufd_ncvy5trszg3zajaal5iofauy2q</para>
            /// </summary>
            [NameInMap("FieldId")]
            [Validation(Required=false)]
            public string FieldId { get; set; }

            /// <summary>
            /// <para>字段标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>userId</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>实例ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_z4pwq7v5ankdimdelzo2zbmzo4</para>
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
            /// <para>扩展字段状态, 枚举类型：enabled，disabled</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
            /// <para>扩展字段最近一次更新时间, Unix时间戳格式，单位为毫秒</para>
            /// 
            /// <b>Example:</b>
            /// <para>17642960730</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>用户端(portal侧)权限，hide、read_only、read_write，默认read_only</para>
            /// 
            /// <b>Example:</b>
            /// <para>read_only</para>
            /// </summary>
            [NameInMap("UserPermission")]
            [Validation(Required=false)]
            public string UserPermission { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
