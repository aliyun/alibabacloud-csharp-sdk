// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListCatalogsResponseBody : TeaModel {
        [NameInMap("catalogs")]
        [Validation(Required=false)]
        public List<ListCatalogsResponseBodyCatalogs> Catalogs { get; set; }
        public class ListCatalogsResponseBodyCatalogs : TeaModel {
            /// <summary>
            /// <para>regionId。</para>
            /// 
            /// <b>Example:</b>
            /// <para>15097**********</para>
            /// </summary>
            [NameInMap("catalogId")]
            [Validation(Required=false)]
            public string CatalogId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HMS</para>
            /// </summary>
            [NameInMap("catalogProvider")]
            [Validation(Required=false)]
            public string CatalogProvider { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default_catalog</para>
            /// </summary>
            [NameInMap("catalogType")]
            [Validation(Required=false)]
            public string CatalogType { get; set; }

            [NameInMap("environments")]
            [Validation(Required=false)]
            public List<string> Environments { get; set; }

            [NameInMap("extras")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extras { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1760604889</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1760604889</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15097**********</para>
            /// </summary>
            [NameInMap("resourceOwnerId")]
            [Validation(Required=false)]
            public string ResourceOwnerId { get; set; }

            /// <summary>
            /// <para>工作空间id。</para>
            /// 
            /// <b>Example:</b>
            /// <para>w-d2d82aa09155****</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>一次获取的最大记录数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>下一页TOKEN。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>记录总数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
