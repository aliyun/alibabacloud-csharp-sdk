// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetNormalizationRuleVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The version of the normalization rule.</para>
        /// </summary>
        [NameInMap("NormalizationRuleVersion")]
        [Validation(Required=false)]
        public GetNormalizationRuleVersionResponseBodyNormalizationRuleVersion NormalizationRuleVersion { get; set; }
        public class GetNormalizationRuleVersionResponseBodyNormalizationRuleVersion : TeaModel {
            /// <summary>
            /// <para>The time when the rule version was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
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
            /// <para>The description of the normalization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normalization_rule_Z57np</para>
            /// </summary>
            [NameInMap("NormalizationRuleDescription")]
            [Validation(Required=false)]
            public string NormalizationRuleDescription { get; set; }

            /// <summary>
            /// <para>The expression for the normalization rule.</para>
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
            /// <para>The ID of the normalization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nr-z0b2ssjteut85uoh9nzp</para>
            /// </summary>
            [NameInMap("NormalizationRuleId")]
            [Validation(Required=false)]
            public string NormalizationRuleId { get; set; }

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
            /// <item><description><para>predefined: a predefined rule.</para>
            /// </description></item>
            /// <item><description><para>custom: a custom rule.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>predefined</para>
            /// </summary>
            [NameInMap("NormalizationRuleType")]
            [Validation(Required=false)]
            public string NormalizationRuleType { get; set; }

            /// <summary>
            /// <para>The version of the normalization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>V1</para>
            /// </summary>
            [NameInMap("NormalizationRuleVersion")]
            [Validation(Required=false)]
            public int? NormalizationRuleVersion { get; set; }

            /// <summary>
            /// <para>The name of the normalization rule version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("NormalizationRuleVersionName")]
            [Validation(Required=false)]
            public string NormalizationRuleVersionName { get; set; }

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
            /// <para>The product ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud_sas</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The region where the Data Management center for Threat Analysis is located. Select a region for the management center based on the region where your assets are located. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>cn-hangzhou: Your assets are in the Chinese mainland.</para>
            /// </description></item>
            /// <item><description><para>ap-southeast-1: Your assets are in a region outside China.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The time when the rule version was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the vendor for the normalization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud</para>
            /// </summary>
            [NameInMap("VendorId")]
            [Validation(Required=false)]
            public string VendorId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
