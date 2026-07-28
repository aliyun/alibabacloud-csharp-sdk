// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListResourceTypesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Chinese.</description></item>
        /// <item><description>en-US: English.</description></item>
        /// </list>
        /// <para>Default value: zh-CN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("acceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The keyword for searching resource codes or names. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page. Valid values: 0 to 200. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tokenForNextPage</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The product code. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// <para>The order in which resource types are returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Normal (default): returned in normal order.</description></item>
        /// <item><description>Top: returned in order of popularity.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The status filter list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Available</description></item>
        /// <item><description>Deprecated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available,Deprecated</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The product subcategory in Terraform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>compute</para>
        /// </summary>
        [NameInMap("subcategory")]
        [Validation(Required=false)]
        public string Subcategory { get; set; }

        /// <summary>
        /// <para>Specifies whether Terraformer is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("supportTerraformer")]
        [Validation(Required=false)]
        public bool? SupportTerraformer { get; set; }

        /// <summary>
        /// <para>The Terraform provider version. If this parameter is left empty, the latest version is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.227.0</para>
        /// </summary>
        [NameInMap("terraformProviderVersion")]
        [Validation(Required=false)]
        public string TerraformProviderVersion { get; set; }

        /// <summary>
        /// <para>The Terraform resources.</para>
        /// </summary>
        [NameInMap("terraformResourceTypes")]
        [Validation(Required=false)]
        public string TerraformResourceTypesShrink { get; set; }

    }

}
