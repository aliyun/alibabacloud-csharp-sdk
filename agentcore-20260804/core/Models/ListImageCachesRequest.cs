// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListImageCachesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the source ACR Enterprise instance. The match must be exact. Empty strings (strings containing no characters) are invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-example</para>
        /// </summary>
        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>The image digest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sha256:aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</para>
        /// </summary>
        [NameInMap("digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// <para>Performs a case-insensitive literal substring search on the full source image reference in the registry/repository:tag format. The repository already includes the namespace. If the value is empty after trimming leading and trailing whitespace, it is treated as not provided. Percent signs, underscores, and backslashes are treated as literal characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>team/app</para>
        /// </summary>
        [NameInMap("imageRefContains")]
        [Validation(Required=false)]
        public string ImageRefContains { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return. Default value: 20. If explicitly specified, the value must be an integer from 1 to 100. Otherwise, an InvalidMaxResults error is returned. When paginating, this value must remain the same as the previous page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The source namespace. The match is case-sensitive and exact. Empty strings are invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>team</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>Omit this parameter for the first request. For subsequent requests, pass the nextToken from the previous response as is. When paginating, you must keep the filter conditions and maxResults consistent. If you change any of these, you must query the first page again.</para>
        /// 
        /// <b>Example:</b>
        /// <para>opaque-token</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The product entry region. This parameter is passed as a query parameter and must match the selected region endpoint and the workspace region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The domain name of the source registry. The match is exact and case-insensitive. Do not include the protocol, path, or tag. Public network and VPC domain names are not considered equal. Empty strings are invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-registry.cn-hangzhou.cr.aliyuncs.com</para>
        /// </summary>
        [NameInMap("registry")]
        [Validation(Required=false)]
        public string Registry { get; set; }

        /// <summary>
        /// <para>The repository name under the namespace. The match is case-sensitive and exact. Do not include the namespace. If this parameter is specified, the namespace parameter must also be provided. Empty strings are invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app</para>
        /// </summary>
        [NameInMap("repository")]
        [Validation(Required=false)]
        public string Repository { get; set; }

        /// <summary>
        /// <para>Filters by a single cache status. Omit this parameter to query all statuses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The source image tag. The match is case-sensitive and exact. The latest tag is not inferred. Empty strings are invalid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-example</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
