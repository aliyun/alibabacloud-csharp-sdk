// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetNormalizationSchemaResponseBody : TeaModel {
        [NameInMap("NormalizationSchema")]
        [Validation(Required=false)]
        public GetNormalizationSchemaResponseBodyNormalizationSchema NormalizationSchema { get; set; }
        public class GetNormalizationSchemaResponseBodyNormalizationSchema : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NETWORK_CATEGORY。</para>
            /// </summary>
            [NameInMap("NormalizationCategoryId")]
            [Validation(Required=false)]
            public string NormalizationCategoryId { get; set; }

            [NameInMap("NormalizationFields")]
            [Validation(Required=false)]
            public List<GetNormalizationSchemaResponseBodyNormalizationSchemaNormalizationFields> NormalizationFields { get; set; }
            public class GetNormalizationSchemaResponseBodyNormalizationSchemaNormalizationFields : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1736386610000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cloud_user。</para>
                /// </summary>
                [NameInMap("NormalizationFieldDescription")]
                [Validation(Required=false)]
                public string NormalizationFieldDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>173326*******。</para>
                /// </summary>
                [NameInMap("NormalizationFieldExample")]
                [Validation(Required=false)]
                public string NormalizationFieldExample { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>preset</para>
                /// </summary>
                [NameInMap("NormalizationFieldFrom")]
                [Validation(Required=false)]
                public string NormalizationFieldFrom { get; set; }

                [NameInMap("NormalizationFieldJsonIndexAll")]
                [Validation(Required=false)]
                public bool? NormalizationFieldJsonIndexAll { get; set; }

                [NameInMap("NormalizationFieldJsonKeys")]
                [Validation(Required=false)]
                public List<GetNormalizationSchemaResponseBodyNormalizationSchemaNormalizationFieldsNormalizationFieldJsonKeys> NormalizationFieldJsonKeys { get; set; }
                public class GetNormalizationSchemaResponseBodyNormalizationSchemaNormalizationFieldsNormalizationFieldJsonKeys : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1736386610000</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>云code，枚举值：\n<br>● alibaba_cloud\n<br>● huawei_cloud\n<br>● tencent_cloud</para>
                    /// </summary>
                    [NameInMap("NormalizationFieldDescription")]
                    [Validation(Required=false)]
                    public string NormalizationFieldDescription { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>alibaba_cloud</para>
                    /// </summary>
                    [NameInMap("NormalizationFieldExample")]
                    [Validation(Required=false)]
                    public string NormalizationFieldExample { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>preset</para>
                    /// </summary>
                    [NameInMap("NormalizationFieldFrom")]
                    [Validation(Required=false)]
                    public string NormalizationFieldFrom { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cloud_code</para>
                    /// </summary>
                    [NameInMap("NormalizationFieldName")]
                    [Validation(Required=false)]
                    public string NormalizationFieldName { get; set; }

                    [NameInMap("NormalizationFieldRequired")]
                    [Validation(Required=false)]
                    public bool? NormalizationFieldRequired { get; set; }

                    [NameInMap("NormalizationFieldReserved")]
                    [Validation(Required=false)]
                    public bool? NormalizationFieldReserved { get; set; }

                    [NameInMap("NormalizationFieldTokenize")]
                    [Validation(Required=false)]
                    public bool? NormalizationFieldTokenize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>varchar</para>
                    /// </summary>
                    [NameInMap("NormalizationFieldType")]
                    [Validation(Required=false)]
                    public string NormalizationFieldType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1736386610000</para>
                    /// </summary>
                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cloud_user。</para>
                /// </summary>
                [NameInMap("NormalizationFieldName")]
                [Validation(Required=false)]
                public string NormalizationFieldName { get; set; }

                [NameInMap("NormalizationFieldRequired")]
                [Validation(Required=false)]
                public bool? NormalizationFieldRequired { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true。</para>
                /// </summary>
                [NameInMap("NormalizationFieldRequirement")]
                [Validation(Required=false)]
                public bool? NormalizationFieldRequirement { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true。</para>
                /// </summary>
                [NameInMap("NormalizationFieldReserved")]
                [Validation(Required=false)]
                public bool? NormalizationFieldReserved { get; set; }

                [NameInMap("NormalizationFieldTokenize")]
                [Validation(Required=false)]
                public bool? NormalizationFieldTokenize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>varchar。</para>
                /// </summary>
                [NameInMap("NormalizationFieldType")]
                [Validation(Required=false)]
                public string NormalizationFieldType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1736386610000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>网络五元组日志</para>
            /// </summary>
            [NameInMap("NormalizationSchemaDescription")]
            [Validation(Required=false)]
            public string NormalizationSchemaDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>preset</para>
            /// </summary>
            [NameInMap("NormalizationSchemaFrom")]
            [Validation(Required=false)]
            public string NormalizationSchemaFrom { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HTTP_ACTIVITY。</para>
            /// </summary>
            [NameInMap("NormalizationSchemaId")]
            [Validation(Required=false)]
            public string NormalizationSchemaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>normalization_rule_Z57np。</para>
            /// </summary>
            [NameInMap("NormalizationSchemaName")]
            [Validation(Required=false)]
            public string NormalizationSchemaName { get; set; }

            [NameInMap("NormalizationSchemaReferences")]
            [Validation(Required=false)]
            public List<GetNormalizationSchemaResponseBodyNormalizationSchemaNormalizationSchemaReferences> NormalizationSchemaReferences { get; set; }
            public class GetNormalizationSchemaResponseBodyNormalizationSchemaNormalizationSchemaReferences : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>alibaba_cloud_cfw_flow_rule</para>
                /// </summary>
                [NameInMap("NormalizationRuleId")]
                [Validation(Required=false)]
                public string NormalizationRuleId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>preset</para>
            /// </summary>
            [NameInMap("NormalizationSchemaType")]
            [Validation(Required=false)]
            public string NormalizationSchemaType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>network-activity。</para>
            /// </summary>
            [NameInMap("TargetLogStore")]
            [Validation(Required=false)]
            public string TargetLogStore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>network_activity。</para>
            /// </summary>
            [NameInMap("TargetStoreView")]
            [Validation(Required=false)]
            public string TargetStoreView { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****。</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
