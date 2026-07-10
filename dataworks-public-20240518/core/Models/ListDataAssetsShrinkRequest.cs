// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataAssetsShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("AssetDomainId")]
        [Validation(Required=false)]
        public long? AssetDomainId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cate-xxxxxxxx</para>
        /// </summary>
        [NameInMap("CategoryUuid")]
        [Validation(Required=false)]
        public string CategoryUuid { get; set; }

        /// <summary>
        /// <para>The list of unique data asset IDs.</para>
        /// </summary>
        [NameInMap("DataAssetIds")]
        [Validation(Required=false)]
        public string DataAssetIdsShrink { get; set; }

        /// <summary>
        /// <para>The Asset Type of the data asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ACS::DataWorks::Table: table.</para>
        /// </description></item>
        /// <item><description><para>ACS::DataWorks::Task: scheduling node.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::DataWorks::Task</para>
        /// </summary>
        [NameInMap("DataAssetType")]
        [Validation(Required=false)]
        public string DataAssetType { get; set; }

        /// <summary>
        /// <para>The workspace environment to which the data asset belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Dev: development environment.</description></item>
        /// <item><description>Prod: production environment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>资产域名称</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The list of tags associated with data assets. Tags are used as query filters:</para>
        /// <list type="bullet">
        /// <item><description>Multiple values have an OR relationship. For example, <c>[&quot;key1:v1&quot;, &quot;key2:v1&quot;, &quot;key3:v1&quot;]</c> queries data assets that contain any of the specified tags.</description></item>
        /// <item><description>If this parameter is not specified or is left empty, no tag-based filtering is applied.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
