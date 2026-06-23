// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetCustomFieldResponseBody : TeaModel {
        /// <summary>
        /// <para>The custom field information.</para>
        /// </summary>
        [NameInMap("CustomField")]
        [Validation(Required=false)]
        public GetCustomFieldResponseBodyCustomField CustomField { get; set; }
        public class GetCustomFieldResponseBodyCustomField : TeaModel {
            /// <summary>
            /// <para>The time when the extended field was created, in UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17642960730</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The default value of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// <para>The description of the extended field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the field is encrypted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public bool? Encrypted { get; set; }

            /// <summary>
            /// <para>The entity type to which the field belongs.</para>
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
            public GetCustomFieldResponseBodyCustomFieldFieldDataConfig FieldDataConfig { get; set; }
            public class GetCustomFieldResponseBodyCustomFieldFieldDataConfig : TeaModel {
                /// <summary>
                /// <para>The list of field configuration items.</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<GetCustomFieldResponseBodyCustomFieldFieldDataConfigItems> Items { get; set; }
                public class GetCustomFieldResponseBodyCustomFieldFieldDataConfigItems : TeaModel {
                    /// <summary>
                    /// <para>The display name of the configuration item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hobby</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>The status of the configuration item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>enabled</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The value of the configuration item.</para>
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
            /// <para>The data type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("FieldDataType")]
            [Validation(Required=false)]
            public string FieldDataType { get; set; }

            /// <summary>
            /// <para>The display name of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>userId</para>
            /// </summary>
            [NameInMap("FieldDisplayName")]
            [Validation(Required=false)]
            public string FieldDisplayName { get; set; }

            /// <summary>
            /// <para>The display type of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>input</para>
            /// </summary>
            [NameInMap("FieldDisplayType")]
            [Validation(Required=false)]
            public string FieldDisplayType { get; set; }

            /// <summary>
            /// <para>The field ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ufd_ncvy5trszg3zajaal5iofauy2q</para>
            /// </summary>
            [NameInMap("FieldId")]
            [Validation(Required=false)]
            public string FieldId { get; set; }

            /// <summary>
            /// <para>The field identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>userId</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_z4pwq7v5ankdimdelzo2zbmzo4</para>
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
            /// <para>The status of the extended field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Indicates whether the field is unique.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Unique")]
            [Validation(Required=false)]
            public bool? Unique { get; set; }

            /// <summary>
            /// <para>The time when the extended field was last updated, in UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17642960730</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The user-side (portal-side) permission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>read_only</para>
            /// </summary>
            [NameInMap("UserPermission")]
            [Validation(Required=false)]
            public string UserPermission { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
