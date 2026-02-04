// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CreateNormalizationRuleShrinkRequest : TeaModel {
        [NameInMap("ExtendContentPacked")]
        [Validation(Required=false)]
        public string ExtendContentPacked { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>flat</para>
        /// </summary>
        [NameInMap("ExtendFieldStoreMode")]
        [Validation(Required=false)]
        public string ExtendFieldStoreMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh。</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

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

        [NameInMap("NormalizationRuleIds")]
        [Validation(Required=false)]
        public string NormalizationRuleIdsShrink { get; set; }

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

        [NameInMap("NormalizationRuleType")]
        [Validation(Required=false)]
        public string NormalizationRuleType { get; set; }

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
        /// <para>cn-hangzhou。</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>173326*******。</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alibaba_cloud。</para>
        /// </summary>
        [NameInMap("VendorId")]
        [Validation(Required=false)]
        public string VendorId { get; set; }

    }

}
