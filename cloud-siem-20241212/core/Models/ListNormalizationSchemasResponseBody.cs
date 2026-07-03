// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListNormalizationSchemasResponseBody : TeaModel {
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
        /// <para>The list of normalization schemas.</para>
        /// </summary>
        [NameInMap("NormalizationSchemas")]
        [Validation(Required=false)]
        public List<ListNormalizationSchemasResponseBodyNormalizationSchemas> NormalizationSchemas { get; set; }
        public class ListNormalizationSchemasResponseBodyNormalizationSchemas : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1736386610000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the normalization rule category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NETWORK_CATEGORY</para>
            /// </summary>
            [NameInMap("NormalizationCategoryId")]
            [Validation(Required=false)]
            public string NormalizationCategoryId { get; set; }

            /// <summary>
            /// <para>The field source. Valid values:
            /// normalized: normalized field.
            /// native: native field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normalized</para>
            /// </summary>
            [NameInMap("NormalizationFieldSource")]
            [Validation(Required=false)]
            public string NormalizationFieldSource { get; set; }

            /// <summary>
            /// <para>The description of the normalization schema.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Network flow log</para>
            /// </summary>
            [NameInMap("NormalizationSchemaDescription")]
            [Validation(Required=false)]
            public string NormalizationSchemaDescription { get; set; }

            /// <summary>
            /// <para>The source of the normalization schema. Valid values: preset (predefined) and custom (user-defined).</para>
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
            /// <para>The LogStore to which the normalization output is written.</para>
            /// 
            /// <b>Example:</b>
            /// <para>network-activity</para>
            /// </summary>
            [NameInMap("NormalizationSchemaTargetLogStore")]
            [Validation(Required=false)]
            public string NormalizationSchemaTargetLogStore { get; set; }

            /// <summary>
            /// <para>The normalization schema type.</para>
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
            /// <para>NETWORK_AND_WEB_SECURITY</para>
            /// </summary>
            [NameInMap("NormalizationSecurityDomainId")]
            [Validation(Required=false)]
            public string NormalizationSecurityDomainId { get; set; }

            /// <summary>
            /// <para>The product ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            [NameInMap("RecommendEntities")]
            [Validation(Required=false)]
            public List<string> RecommendEntities { get; set; }

            /// <summary>
            /// <para>The Simple Log Service LogStore.</para>
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
            /// <para>network-activity</para>
            /// </summary>
            [NameInMap("TargetStoreView")]
            [Validation(Required=false)]
            public string TargetStoreView { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1736386610000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The vendor ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba</para>
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

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
