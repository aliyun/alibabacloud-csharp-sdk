// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateNormalizationRuleRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to package non-standard fields into the extend_content extension field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>enabled: The feature is enabled.</para>
        /// </description></item>
        /// <item><description><para>disabled: The feature is disabled.</para>
        /// </description></item>
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
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The normalization category.</para>
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
        /// <para>The list of normalization rule IDs.</para>
        /// </summary>
        [NameInMap("NormalizationRuleIds")]
        [Validation(Required=false)]
        public List<string> NormalizationRuleIds { get; set; }

        /// <summary>
        /// <para>The mode of the normalization rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>both</para>
        /// </description></item>
        /// <item><description><para>scan</para>
        /// </description></item>
        /// <item><description><para>realtime</para>
        /// </description></item>
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
        /// <item><description><para>predefined: predefined normalization rule.</para>
        /// </description></item>
        /// <item><description><para>custom: custom normalization rule.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("NormalizationRuleType")]
        [Validation(Required=false)]
        public string NormalizationRuleType { get; set; }

        /// <summary>
        /// <para>The ID of the normalization structure.</para>
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
        /// <para>The field to use for sorting the rule list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>GmtModified: Sorts by modification time.</para>
        /// </description></item>
        /// <item><description><para>Id: Sorts by rule ID (default).</para>
        /// </description></item>
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
        /// <para>The region where the Data Management center of threat analysis is located. Select a region based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: an asset in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: an asset outside the Chinese mainland.</para>
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
        /// <para>The user ID of a member. This parameter is used when an administrator switches to the perspective of the member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The vendor ID that corresponds to the normalization rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba_cloud</para>
        /// </summary>
        [NameInMap("VendorId")]
        [Validation(Required=false)]
        public string VendorId { get; set; }

    }

}
