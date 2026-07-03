// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CreateNormalizationRuleRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to pack non-standard fields into the extension field extend_content. Valid values:</para>
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
        /// <para>The storage mode for extension fields. Valid values: flat, pack, and reject.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flat</para>
        /// </summary>
        [NameInMap("ExtendFieldStoreMode")]
        [Validation(Required=false)]
        public string ExtendFieldStoreMode { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
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
        /// <para>The category ID of the normalization rule.</para>
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
        /// <para>The list of normalization rule IDs.</para>
        /// </summary>
        [NameInMap("NormalizationRuleIds")]
        [Validation(Required=false)]
        public List<string> NormalizationRuleIds { get; set; }

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
        /// <para>The type of the normalization rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>predefined: predefined normalization rule.</description></item>
        /// <item><description>custom: custom normalization rule.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("NormalizationRuleType")]
        [Validation(Required=false)]
        public string NormalizationRuleType { get; set; }

        /// <summary>
        /// <para>The version of the normalization rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NormalizationRuleVersion")]
        [Validation(Required=false)]
        public int? NormalizationRuleVersion { get; set; }

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
        /// <para>The field used to sort the rule list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GmtModified: sorted by modification time.</description></item>
        /// <item><description>Id: sorted by rule ID (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Id</para>
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

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
        /// <para>The region in which the data management center of the threat analysis feature resides. Specify this parameter based on the region where your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets reside in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: Your assets reside outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the member accounts in the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

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

}
