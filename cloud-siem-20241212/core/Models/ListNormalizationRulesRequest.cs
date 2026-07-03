// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListNormalizationRulesRequest : TeaModel {
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
        /// <para>The maximum number of entries to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
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
        /// <para>The category ID of the normalization rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NETWORK_CATEGORY</para>
        /// </summary>
        [NameInMap("NormalizationCategoryId")]
        [Validation(Required=false)]
        public string NormalizationCategoryId { get; set; }

        /// <summary>
        /// <para>The list of normalization rule IDs.</para>
        /// </summary>
        [NameInMap("NormalizationRuleIds")]
        [Validation(Required=false)]
        public List<string> NormalizationRuleIds { get; set; }

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
        /// <para>predefined</para>
        /// </summary>
        [NameInMap("NormalizationRuleType")]
        [Validation(Required=false)]
        public string NormalizationRuleType { get; set; }

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
        /// <para>The field used for sorting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UpdateTime</para>
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>desc</description></item>
        /// <item><description>asc.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The page number of the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The region where the data management center of the threat analysis feature resides. Specify this parameter based on the region where your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of the member to which the administrator switches the view.</para>
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
