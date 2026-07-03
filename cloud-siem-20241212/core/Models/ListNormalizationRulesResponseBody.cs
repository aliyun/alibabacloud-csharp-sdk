// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListNormalizationRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query. Leave this parameter empty for the first query or if no more results exist. If more results exist, set this parameter to the NextToken value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of normalization rules.</para>
        /// </summary>
        [NameInMap("NormalizationRules")]
        [Validation(Required=false)]
        public List<ListNormalizationRulesResponseBodyNormalizationRules> NormalizationRules { get; set; }
        public class ListNormalizationRulesResponseBodyNormalizationRules : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Specifies whether non-standard fields are packed into the extend_content field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: Enabled.</description></item>
            /// <item><description>disabled: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("ExtendContentPacked")]
            [Validation(Required=false)]
            public string ExtendContentPacked { get; set; }

            /// <summary>
            /// <para>The storage mode for extended fields. Valid values: flat (ingest as-is), reject (do not ingest), and pack (pack into the extend_content field).</para>
            /// 
            /// <b>Example:</b>
            /// <para>flat</para>
            /// </summary>
            [NameInMap("ExtendFieldStoreMode")]
            [Validation(Required=false)]
            public string ExtendFieldStoreMode { get; set; }

            /// <summary>
            /// <para>The category ID of the normalization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NETWORK_CATEGORY</para>
            /// </summary>
            [NameInMap("NormalizationCategoryId")]
            [Validation(Required=false)]
            public string NormalizationCategoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>normalized</para>
            /// </summary>
            [NameInMap("NormalizationFieldSource")]
            [Validation(Required=false)]
            public string NormalizationFieldSource { get; set; }

            /// <summary>
            /// <para>The description of the normalization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normalization_rule_Z57np</para>
            /// </summary>
            [NameInMap("NormalizationRuleDescription")]
            [Validation(Required=false)]
            public string NormalizationRuleDescription { get; set; }

            /// <summary>
            /// <para>The expression of the normalization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description>| pack-fields -include=\&quot;[\s\S]+\&quot; as extend_content</description></item>
            /// </list>
            /// </summary>
            [NameInMap("NormalizationRuleExpression")]
            [Validation(Required=false)]
            public string NormalizationRuleExpression { get; set; }

            /// <summary>
            /// <para>The format of the normalization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SPL</para>
            /// </summary>
            [NameInMap("NormalizationRuleFormat")]
            [Validation(Required=false)]
            public string NormalizationRuleFormat { get; set; }

            /// <summary>
            /// <para>The normalization rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nr-z0b2ssjteut85uoh9nzp</para>
            /// </summary>
            [NameInMap("NormalizationRuleId")]
            [Validation(Required=false)]
            public string NormalizationRuleId { get; set; }

            /// <summary>
            /// <para>The mode of the normalization rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>both</description></item>
            /// <item><description>scan</description></item>
            /// <item><description>realtime.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>both</para>
            /// </summary>
            [NameInMap("NormalizationRuleMode")]
            [Validation(Required=false)]
            public string NormalizationRuleMode { get; set; }

            /// <summary>
            /// <para>The name of the normalization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normalization_rule_Z57np</para>
            /// </summary>
            [NameInMap("NormalizationRuleName")]
            [Validation(Required=false)]
            public string NormalizationRuleName { get; set; }

            /// <summary>
            /// <para>The list of associated ingestion policies.</para>
            /// </summary>
            [NameInMap("NormalizationRuleReferences")]
            [Validation(Required=false)]
            public List<ListNormalizationRulesResponseBodyNormalizationRulesNormalizationRuleReferences> NormalizationRuleReferences { get; set; }
            public class ListNormalizationRulesResponseBodyNormalizationRulesNormalizationRuleReferences : TeaModel {
                /// <summary>
                /// <para>The data ingestion ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alibaba_cloud_bot_flow_ingestion_173326*******</para>
                /// </summary>
                [NameInMap("DataIngestionId")]
                [Validation(Required=false)]
                public string DataIngestionId { get; set; }

            }

            /// <summary>
            /// <para>The status of the normalization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>started</para>
            /// </summary>
            [NameInMap("NormalizationRuleStatus")]
            [Validation(Required=false)]
            public string NormalizationRuleStatus { get; set; }

            /// <summary>
            /// <para>The type of the normalization rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>predefined: predefined normalization rule.</description></item>
            /// <item><description>custom: custom normalization rule.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>predefined</para>
            /// </summary>
            [NameInMap("NormalizationRuleType")]
            [Validation(Required=false)]
            public string NormalizationRuleType { get; set; }

            /// <summary>
            /// <para>The current version of the normalization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>V1</para>
            /// </summary>
            [NameInMap("NormalizationRuleVersion")]
            [Validation(Required=false)]
            public string NormalizationRuleVersion { get; set; }

            /// <summary>
            /// <para>The normalization schema ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP_ACTIVITY</para>
            /// </summary>
            [NameInMap("NormalizationSchemaId")]
            [Validation(Required=false)]
            public string NormalizationSchemaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NETWORK_AND_WEB_SECURITY</para>
            /// </summary>
            [NameInMap("NormalizationSecurityDomainId")]
            [Validation(Required=false)]
            public string NormalizationSecurityDomainId { get; set; }

            /// <summary>
            /// <para>The product ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud_sas</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The vendor ID associated with the normalization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud</para>
            /// </summary>
            [NameInMap("VendorId")]
            [Validation(Required=false)]
            public string VendorId { get; set; }

        }

        /// <summary>
        /// <para>The page number of the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
