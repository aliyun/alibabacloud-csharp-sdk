// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListChunksRequest : TeaModel {
        /// <summary>
        /// <para>The asset ID. This parameter is optional. If specified, only chunks in the current published generation of the asset are queried. If omitted, the entire knowledge base is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asset-001</para>
        /// </summary>
        [NameInMap("assetId")]
        [Validation(Required=false)]
        public string AssetId { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter by enabled status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Queries only enabled chunks.</description></item>
        /// <item><description>false: Queries only disabled chunks.
        /// If this parameter is omitted, chunks are not filtered by enabled status.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The keyword used to filter chunk content. The maximum length is 1,024 characters. This parameter is allowed only when assetId is specified. Otherwise, an InvalidParameter error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Product documentation</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per page. Valid values: 0 to 100. If this parameter is omitted or set to 0, the default value 20 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token returned in the previous response for pagination. The token is bound to the tenant, workspace, knowledge base, filter conditions, and sorting, and cannot be reused across different scopes. If assetId is specified, the token is also bound to the current publish result. A VersionConflict (409) error is returned if the publish result changes. Cross-asset pagination is sorted by assetId and chunkSeq, and a full-base snapshot is not guaranteed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>opaque-next-token</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
