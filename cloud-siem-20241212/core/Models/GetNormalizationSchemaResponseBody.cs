// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetNormalizationSchemaResponseBody : TeaModel {
        /// <summary>
        /// <para>The normalization schema.</para>
        /// </summary>
        [NameInMap("NormalizationSchema")]
        [Validation(Required=false)]
        public GetNormalizationSchemaResponseBodyNormalizationSchema NormalizationSchema { get; set; }
        public class GetNormalizationSchemaResponseBodyNormalizationSchema : TeaModel {
            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the normalized rule category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NETWORK_CATEGORY</para>
            /// </summary>
            [NameInMap("NormalizationCategoryId")]
            [Validation(Required=false)]
            public string NormalizationCategoryId { get; set; }

            /// <summary>
            /// <para>The source of the field. Valid values: normalized: normalized field, native: native field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>native</para>
            /// </summary>
            [NameInMap("NormalizationFieldSource")]
            [Validation(Required=false)]
            public string NormalizationFieldSource { get; set; }

            /// <summary>
            /// <para>The list of normalization fields.</para>
            /// </summary>
            [NameInMap("NormalizationFields")]
            [Validation(Required=false)]
            public List<GetNormalizationSchemaResponseBodyNormalizationSchemaNormalizationFields> NormalizationFields { get; set; }
            public class GetNormalizationSchemaResponseBodyNormalizationSchemaNormalizationFields : TeaModel {
                /// <summary>
                /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1736386610000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the normalization field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_user</para>
                /// </summary>
                [NameInMap("NormalizationFieldDescription")]
                [Validation(Required=false)]
                public string NormalizationFieldDescription { get; set; }

                /// <summary>
                /// <para>The example of the normalization field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>173326*******</para>
                /// </summary>
                [NameInMap("NormalizationFieldExample")]
                [Validation(Required=false)]
                public string NormalizationFieldExample { get; set; }

                /// <summary>
                /// <para>The source of the normalization field. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>preset: built-in.</description></item>
                /// <item><description>custom: custom.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>preset</para>
                /// </summary>
                [NameInMap("NormalizationFieldFrom")]
                [Validation(Required=false)]
                public string NormalizationFieldFrom { get; set; }

                /// <summary>
                /// <para>Specifies whether indexes are created for all keys of a JSON normalization field.</para>
                /// </summary>
                [NameInMap("NormalizationFieldJsonIndexAll")]
                [Validation(Required=false)]
                public bool? NormalizationFieldJsonIndexAll { get; set; }

                /// <summary>
                /// <para>The list of keys for a JSON normalization field.</para>
                /// </summary>
                [NameInMap("NormalizationFieldJsonKeys")]
                [Validation(Required=false)]
                public List<GetNormalizationSchemaResponseBodyNormalizationSchemaNormalizationFieldsNormalizationFieldJsonKeys> NormalizationFieldJsonKeys { get; set; }
                public class GetNormalizationSchemaResponseBodyNormalizationSchemaNormalizationFieldsNormalizationFieldJsonKeys : TeaModel {
                    /// <summary>
                    /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1736386610000</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>The description of the key for a JSON normalization field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Cloud Provider Code</para>
                    /// </summary>
                    [NameInMap("NormalizationFieldDescription")]
                    [Validation(Required=false)]
                    public string NormalizationFieldDescription { get; set; }

                    /// <summary>
                    /// <para>The example of the key for a JSON normalization field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>alibaba_cloud</para>
                    /// </summary>
                    [NameInMap("NormalizationFieldExample")]
                    [Validation(Required=false)]
                    public string NormalizationFieldExample { get; set; }

                    /// <summary>
                    /// <para>The source of the key for a JSON normalization field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>preset</para>
                    /// </summary>
                    [NameInMap("NormalizationFieldFrom")]
                    [Validation(Required=false)]
                    public string NormalizationFieldFrom { get; set; }

                    /// <summary>
                    /// <para>The name of the key for a JSON normalization field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cloud_code</para>
                    /// </summary>
                    [NameInMap("NormalizationFieldName")]
                    [Validation(Required=false)]
                    public string NormalizationFieldName { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the key of a JSON normalization field is required.</para>
                    /// </summary>
                    [NameInMap("NormalizationFieldRequired")]
                    [Validation(Required=false)]
                    public bool? NormalizationFieldRequired { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the normalization field name is a system built-in name.</para>
                    /// </summary>
                    [NameInMap("NormalizationFieldReserved")]
                    [Validation(Required=false)]
                    public bool? NormalizationFieldReserved { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the key of a JSON normalization field is tokenized.</para>
                    /// </summary>
                    [NameInMap("NormalizationFieldTokenize")]
                    [Validation(Required=false)]
                    public bool? NormalizationFieldTokenize { get; set; }

                    /// <summary>
                    /// <para>The type of the key for a JSON normalization field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>varchar</para>
                    /// </summary>
                    [NameInMap("NormalizationFieldType")]
                    [Validation(Required=false)]
                    public string NormalizationFieldType { get; set; }

                    /// <summary>
                    /// <para>The update time. The value is a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1736386610000</para>
                    /// </summary>
                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                }

                /// <summary>
                /// <para>The name of the normalization field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_user</para>
                /// </summary>
                [NameInMap("NormalizationFieldName")]
                [Validation(Required=false)]
                public string NormalizationFieldName { get; set; }

                /// <summary>
                /// <para>Specifies whether the field is required.</para>
                /// </summary>
                [NameInMap("NormalizationFieldRequired")]
                [Validation(Required=false)]
                public bool? NormalizationFieldRequired { get; set; }

                /// <summary>
                /// <para>Specifies whether the normalization field is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("NormalizationFieldRequirement")]
                [Validation(Required=false)]
                public bool? NormalizationFieldRequirement { get; set; }

                /// <summary>
                /// <para>Specifies whether the normalization field is reserved.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("NormalizationFieldReserved")]
                [Validation(Required=false)]
                public bool? NormalizationFieldReserved { get; set; }

                /// <summary>
                /// <para>Specifies whether the normalization field is tokenized.</para>
                /// </summary>
                [NameInMap("NormalizationFieldTokenize")]
                [Validation(Required=false)]
                public bool? NormalizationFieldTokenize { get; set; }

                /// <summary>
                /// <para>The type of the normalization field. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>varchar</description></item>
                /// <item><description>bigint</description></item>
                /// <item><description>double</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>varchar</para>
                /// </summary>
                [NameInMap("NormalizationFieldType")]
                [Validation(Required=false)]
                public string NormalizationFieldType { get; set; }

                /// <summary>
                /// <para>The update time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1736386610000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The description of the normalization schema.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Network 5-Tuple Logs</para>
            /// </summary>
            [NameInMap("NormalizationSchemaDescription")]
            [Validation(Required=false)]
            public string NormalizationSchemaDescription { get; set; }

            /// <summary>
            /// <para>The source of the normalization schema. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>preset: predefined.</description></item>
            /// <item><description>custom: custom.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>preset</para>
            /// </summary>
            [NameInMap("NormalizationSchemaFrom")]
            [Validation(Required=false)]
            public string NormalizationSchemaFrom { get; set; }

            /// <summary>
            /// <para>The ID of the normalization schema.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP_ACTIVITY</para>
            /// </summary>
            [NameInMap("NormalizationSchemaId")]
            [Validation(Required=false)]
            public string NormalizationSchemaId { get; set; }

            /// <summary>
            /// <para>The name of the normalization schema.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normalization_rule_Z57np</para>
            /// </summary>
            [NameInMap("NormalizationSchemaName")]
            [Validation(Required=false)]
            public string NormalizationSchemaName { get; set; }

            /// <summary>
            /// <para>The list of normalization schema references.</para>
            /// </summary>
            [NameInMap("NormalizationSchemaReferences")]
            [Validation(Required=false)]
            public List<GetNormalizationSchemaResponseBodyNormalizationSchemaNormalizationSchemaReferences> NormalizationSchemaReferences { get; set; }
            public class GetNormalizationSchemaResponseBodyNormalizationSchemaNormalizationSchemaReferences : TeaModel {
                /// <summary>
                /// <para>The ID of the normalization rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alibaba_cloud_cfw_flow_rule</para>
                /// </summary>
                [NameInMap("NormalizationRuleId")]
                [Validation(Required=false)]
                public string NormalizationRuleId { get; set; }

            }

            /// <summary>
            /// <para>The type of the normalization schema. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>log</description></item>
            /// <item><description>entity</description></item>
            /// <item><description>incident</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>log</para>
            /// </summary>
            [NameInMap("NormalizationSchemaType")]
            [Validation(Required=false)]
            public string NormalizationSchemaType { get; set; }

            /// <summary>
            /// <para>The security domain ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DATA_SECURITY</para>
            /// </summary>
            [NameInMap("NormalizationSecurityDomainId")]
            [Validation(Required=false)]
            public string NormalizationSecurityDomainId { get; set; }

            /// <summary>
            /// <para>The product ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud_bastionhost</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The list of recommended entities.</para>
            /// </summary>
            [NameInMap("RecommendEntities")]
            [Validation(Required=false)]
            public List<string> RecommendEntities { get; set; }

            /// <summary>
            /// <para>The Simple Log Service Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>network-activity</para>
            /// </summary>
            [NameInMap("TargetLogStore")]
            [Validation(Required=false)]
            public string TargetLogStore { get; set; }

            /// <summary>
            /// <para>The Simple Log Service StoreView.</para>
            /// 
            /// <b>Example:</b>
            /// <para>network_activity</para>
            /// </summary>
            [NameInMap("TargetStoreView")]
            [Validation(Required=false)]
            public string TargetStoreView { get; set; }

            /// <summary>
            /// <para>The update time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The vendor ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud</para>
            /// </summary>
            [NameInMap("VendorId")]
            [Validation(Required=false)]
            public string VendorId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
