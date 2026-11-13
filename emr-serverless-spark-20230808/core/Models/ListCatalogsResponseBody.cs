// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListCatalogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The data catalogs.</para>
        /// </summary>
        [NameInMap("catalogs")]
        [Validation(Required=false)]
        public List<ListCatalogsResponseBodyCatalogs> Catalogs { get; set; }
        public class ListCatalogsResponseBodyCatalogs : TeaModel {
            /// <summary>
            /// <para>alias</para>
            /// 
            /// <b>Example:</b>
            /// <para>alias</para>
            /// </summary>
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The data catalog ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15097**********</para>
            /// </summary>
            [NameInMap("catalogId")]
            [Validation(Required=false)]
            public string CatalogId { get; set; }

            /// <summary>
            /// <para>The data catalog type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HMS</para>
            /// </summary>
            [NameInMap("catalogProvider")]
            [Validation(Required=false)]
            public string CatalogProvider { get; set; }

            /// <summary>
            /// <para>Indicates whether the data catalog is the default data catalog.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default_catalog</para>
            /// </summary>
            [NameInMap("catalogType")]
            [Validation(Required=false)]
            public string CatalogType { get; set; }

            /// <summary>
            /// <para>The environment type.</para>
            /// </summary>
            [NameInMap("environments")]
            [Validation(Required=false)]
            public List<string> Environments { get; set; }

            /// <summary>
            /// <para>The extra information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;networkName&quot;:&quot;hms&quot;,&quot;metastoreUrl&quot;:&quot;thrift://metastore.example.com:9083&quot;}</para>
            /// </summary>
            [NameInMap("extras")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extras { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1760604889</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1760604889</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The resource owner ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15097**********</para>
            /// </summary>
            [NameInMap("resourceOwnerId")]
            [Validation(Required=false)]
            public string ResourceOwnerId { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>w-d2d82aa09155****</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records to return per request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The next page token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
