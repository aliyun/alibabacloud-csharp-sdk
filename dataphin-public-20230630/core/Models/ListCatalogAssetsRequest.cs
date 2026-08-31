// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListCatalogAssetsRequest : TeaModel {
        /// <summary>
        /// <para>The query parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListCatalogAssetsQuery")]
        [Validation(Required=false)]
        public ListCatalogAssetsRequestListCatalogAssetsQuery ListCatalogAssetsQuery { get; set; }
        public class ListCatalogAssetsRequestListCatalogAssetsQuery : TeaModel {
            /// <summary>
            /// <para>The asset type. Default value: TABLE. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TABLE: tables, including views and materialized views.</description></item>
            /// <item><description>INDEX: technical metrics.</description></item>
            /// <item><description>BIZ_INDEX: business metrics.</description></item>
            /// <item><description>API</description></item>
            /// <item><description>PAGE: dashboards.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TABLE</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            /// <summary>
            /// <para>The search keyword. Used when queryMode is set to ASSET_SEARCH. Supports keyword matching against the asset full name, asset name, asset display name, and asset description. If not specified, all assets are returned by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>The asset name. Used when queryMode is set to EXACT_MATCH. If not specified, all assets are returned by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The page number. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The page size. Default value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The query type. Determines whether to use name for exact match or keyword for fuzzy search. Default value: EXACT_MATCH. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>EXACT_MATCH: exact match.</description></item>
            /// <item><description>ASSET_SEARCH: fuzzy search.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EXACT_MATCH</para>
            /// </summary>
            [NameInMap("QueryMode")]
            [Validation(Required=false)]
            public string QueryMode { get; set; }

            /// <summary>
            /// <para>The list of folder IDs to which the assets belong. Multiple folders are matched with OR logic. Only the specified folders are matched, and subfolders are not included.</para>
            /// </summary>
            [NameInMap("ShelveDirectoryIds")]
            [Validation(Required=false)]
            public List<long?> ShelveDirectoryIds { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
