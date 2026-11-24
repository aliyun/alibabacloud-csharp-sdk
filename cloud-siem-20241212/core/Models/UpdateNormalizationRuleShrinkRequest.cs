// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateNormalizationRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to pack non-standard fields into the extend_content field. Valid values:</para>
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
        /// <para>The storage mode of extension fields. Valid values: flat, pack, and reject.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flat</para>
        /// </summary>
        [NameInMap("ExtendFieldStoreMode")]
        [Validation(Required=false)]
        public string ExtendFieldStoreMode { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The normalization category to which the rule belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HOST_CATEGORY</para>
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
        /// <para>The ID of the normalization rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nr-z0b2ssjteut85uoh9nzp</para>
        /// </summary>
        [NameInMap("NormalizationRuleId")]
        [Validation(Required=false)]
        public string NormalizationRuleId { get; set; }

        /// <summary>
        /// <para>The IDs of the normalization rules.</para>
        /// </summary>
        [NameInMap("NormalizationRuleIds")]
        [Validation(Required=false)]
        public string NormalizationRuleIdsShrink { get; set; }

        /// <summary>
        /// <para>The mode of the normalization rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>both</description></item>
        /// <item><description>scan</description></item>
        /// <item><description>realtime</description></item>
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
        /// <para>The type of the normalization rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>predefined: Predefined normalization rule.</description></item>
        /// <item><description>custom: Custom normalization rule.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("NormalizationRuleType")]
        [Validation(Required=false)]
        public string NormalizationRuleType { get; set; }

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
        /// <para>The ID of the normalization security domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NETWORK_AND_WEB_SECURITY</para>
        /// </summary>
        [NameInMap("NormalizationSecurityDomainId")]
        [Validation(Required=false)]
        public string NormalizationSecurityDomainId { get; set; }

        /// <summary>
        /// <para>The field by which the rule list is sorted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GmtModified: Sorts by modification time.</description></item>
        /// <item><description>Id: Sorts by rule ID (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Id</para>
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// <para>The ID of the product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba_cloud_sas</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The region where the data management center of Threat Analysis is located. Select the region of the management center based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: The assets are located in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: The assets are located outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the user whose perspective the administrator switches to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The ID of the vendor that corresponds to the normalization rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba_cloud</para>
        /// </summary>
        [NameInMap("VendorId")]
        [Validation(Required=false)]
        public string VendorId { get; set; }

    }

}
