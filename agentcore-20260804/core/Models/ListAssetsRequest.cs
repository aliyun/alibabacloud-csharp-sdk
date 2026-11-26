// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListAssetsRequest : TeaModel {
        /// <summary>
        /// <para>Filters assets by the original file name prefix. The maximum length is 255 characters. If this parameter is omitted or left empty, no filtering is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>guide</para>
        /// </summary>
        [NameInMap("fileNamePrefix")]
        [Validation(Required=false)]
        public string FileNamePrefix { get; set; }

        /// <summary>
        /// <para>The maximum number of assets to return per page. Maximum value: 100. If this parameter is omitted or set to 0, the default value 20 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The opaque pagination token returned in the previous response. It is a composite cursor based on the upload time and assetId, and is bound to the resource scope and filter conditions. Do not specify this parameter for the first request. If you change the resource or filter conditions, start from the first page. Do not parse or modify the token. If a legacy or cross-scope token is used, an InvalidParameter error is returned. In this case, clear the token and query again. Overwrite uploads change the sorting position, so pagination does not guarantee consistent snapshots across pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>opaque-next-token</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Filters assets by their current processing status. If this parameter is omitted, no filtering is applied. Deleted assets are not included in the list. If you set this parameter to DELETED, an empty list is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETED</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
