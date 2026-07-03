// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListNormalizationSchemasRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
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
        /// <para>The ID of the normalization rule category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NETWORK_CATEGORY</para>
        /// </summary>
        [NameInMap("NormalizationCategoryId")]
        [Validation(Required=false)]
        public string NormalizationCategoryId { get; set; }

        /// <summary>
        /// <para>The field source filter. Valid values: normalized / native.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normalized</para>
        /// </summary>
        [NameInMap("NormalizationFieldSource")]
        [Validation(Required=false)]
        public string NormalizationFieldSource { get; set; }

        /// <summary>
        /// <para>The normalization schema type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>log: log.</description></item>
        /// <item><description>entity: entity.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>entity</para>
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
        /// <para>The region where the threat analysis data management center is located. Specify the management center based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: the asset is in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: the asset is outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID that the administrator switches to when viewing as another member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
