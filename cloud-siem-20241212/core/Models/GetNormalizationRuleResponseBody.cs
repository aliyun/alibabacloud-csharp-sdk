// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetNormalizationRuleResponseBody : TeaModel {
        [NameInMap("NormalizationRule")]
        [Validation(Required=false)]
        public GetNormalizationRuleResponseBodyNormalizationRule NormalizationRule { get; set; }
        public class GetNormalizationRuleResponseBodyNormalizationRule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1733269771123。</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("ExtendContentPacked")]
            [Validation(Required=false)]
            public string ExtendContentPacked { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NETWORK_CATEGORY。</para>
            /// </summary>
            [NameInMap("NormalizationCategoryId")]
            [Validation(Required=false)]
            public string NormalizationCategoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>normalization_rule_Z57np。</para>
            /// </summary>
            [NameInMap("NormalizationRuleDescription")]
            [Validation(Required=false)]
            public string NormalizationRuleDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description>| pack-fields -include=\&quot;[\s\S]+\&quot; as extend_content。</description></item>
            /// </list>
            /// </summary>
            [NameInMap("NormalizationRuleExpression")]
            [Validation(Required=false)]
            public string NormalizationRuleExpression { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SPL。</para>
            /// </summary>
            [NameInMap("NormalizationRuleFormat")]
            [Validation(Required=false)]
            public string NormalizationRuleFormat { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>nr-z0b2ssjteut85uoh9nzp。</para>
            /// </summary>
            [NameInMap("NormalizationRuleId")]
            [Validation(Required=false)]
            public string NormalizationRuleId { get; set; }

            [NameInMap("NormalizationRuleIds")]
            [Validation(Required=false)]
            public List<string> NormalizationRuleIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>both。</para>
            /// </summary>
            [NameInMap("NormalizationRuleMode")]
            [Validation(Required=false)]
            public string NormalizationRuleMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>normalization_rule_Z57np。</para>
            /// </summary>
            [NameInMap("NormalizationRuleName")]
            [Validation(Required=false)]
            public string NormalizationRuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>started。</para>
            /// </summary>
            [NameInMap("NormalizationRuleStatus")]
            [Validation(Required=false)]
            public string NormalizationRuleStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>predefined。</para>
            /// </summary>
            [NameInMap("NormalizationRuleType")]
            [Validation(Required=false)]
            public string NormalizationRuleType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>V1。</para>
            /// </summary>
            [NameInMap("NormalizationRuleVersion")]
            [Validation(Required=false)]
            public int? NormalizationRuleVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HTTP_ACTIVITY。</para>
            /// </summary>
            [NameInMap("NormalizationSchemaId")]
            [Validation(Required=false)]
            public string NormalizationSchemaId { get; set; }

            [NameInMap("OrderField")]
            [Validation(Required=false)]
            public string OrderField { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alibaba_cloud_sas。</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1733269771123。</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alibaba_cloud。</para>
            /// </summary>
            [NameInMap("VendorId")]
            [Validation(Required=false)]
            public string VendorId { get; set; }

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
