// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class GetResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned. Return result of the List operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists. Return result of the List operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The specified resource. Return result of the Get operation.</para>
        /// </summary>
        [NameInMap("resource")]
        [Validation(Required=false)]
        public GetResourcesResponseBodyResource Resource { get; set; }
        public class GetResourcesResponseBodyResource : TeaModel {
            /// <summary>
            /// <para>The resource properties in the JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Status&quot;:&quot;Available&quot;,&quot;Description&quot;:&quot;&quot;,&quot;AccountPrivilege&quot;:&quot;RoleReadWrite&quot;,&quot;InstanceId&quot;:&quot;r-8vbf5abe31c9c4d4&quot;,&quot;RegionId&quot;:&quot;cn-zhangjiakou&quot;,&quot;AccountType&quot;:&quot;Normal&quot;,&quot;TypeInfo&quot;:{},&quot;AccountName&quot;:&quot;cctest&quot;}</para>
            /// </summary>
            [NameInMap("resourceAttributes")]
            [Validation(Required=false)]
            public Dictionary<string, object> ResourceAttributes { get; set; }

            /// <summary>
            /// <para>The ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cctest</para>
            /// </summary>
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

        }

        /// <summary>
        /// <para>The resource list. Return result of the List operation.</para>
        /// </summary>
        [NameInMap("resources")]
        [Validation(Required=false)]
        public List<GetResourcesResponseBodyResources> Resources { get; set; }
        public class GetResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The resource properties in the JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Status&quot;:&quot;Available&quot;,&quot;Description&quot;:&quot;&quot;,&quot;AccountPrivilege&quot;:&quot;RoleReadWrite&quot;,&quot;InstanceId&quot;:&quot;r-8vbf5abe31c9c4d4&quot;,&quot;RegionId&quot;:&quot;cn-zhangjiakou&quot;,&quot;AccountType&quot;:&quot;Normal&quot;,&quot;TypeInfo&quot;:{},&quot;AccountName&quot;:&quot;cctest&quot;}</para>
            /// </summary>
            [NameInMap("resourceAttributes")]
            [Validation(Required=false)]
            public Dictionary<string, object> ResourceAttributes { get; set; }

            /// <summary>
            /// <para>The ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cctest</para>
            /// </summary>
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned. Return result of the List operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
