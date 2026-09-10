// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class GetResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of records returned for the current request. This parameter is returned by the List operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The position where the current call finished reading. An empty value indicates that all data has been read. This parameter is returned by the List operation.</para>
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
        /// <para>The specified resource. This parameter is returned by the Get operation.</para>
        /// </summary>
        [NameInMap("resource")]
        [Validation(Required=false)]
        public GetResourcesResponseBodyResource Resource { get; set; }
        public class GetResourcesResponseBodyResource : TeaModel {
            /// <summary>
            /// <para>The resource properties in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Status&quot;:&quot;Available&quot;,&quot;Description&quot;:&quot;&quot;,&quot;AccountPrivilege&quot;:&quot;RoleReadWrite&quot;,&quot;InstanceId&quot;:&quot;r-2ze8v41uei31lo****&quot;,&quot;RegionId&quot;:&quot;cn-zhangjiakou&quot;,&quot;AccountType&quot;:&quot;Normal&quot;,&quot;TypeInfo&quot;:{},&quot;AccountName&quot;:&quot;cctest&quot;}</para>
            /// </summary>
            [NameInMap("resourceAttributes")]
            [Validation(Required=false)]
            public Dictionary<string, object> ResourceAttributes { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cctest</para>
            /// </summary>
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

        }

        /// <summary>
        /// <para>A list of resources. This parameter is returned by the List operation.</para>
        /// </summary>
        [NameInMap("resources")]
        [Validation(Required=false)]
        public List<GetResourcesResponseBodyResources> Resources { get; set; }
        public class GetResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The resource properties in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Status&quot;:&quot;Available&quot;,&quot;Description&quot;:&quot;&quot;,&quot;AccountPrivilege&quot;:&quot;RoleReadWrite&quot;,&quot;InstanceId&quot;:&quot;r-2ze8v41uei31lo****&quot;,&quot;RegionId&quot;:&quot;cn-zhangjiakou&quot;,&quot;AccountType&quot;:&quot;Normal&quot;,&quot;TypeInfo&quot;:{},&quot;AccountName&quot;:&quot;cctest&quot;}</para>
            /// </summary>
            [NameInMap("resourceAttributes")]
            [Validation(Required=false)]
            public Dictionary<string, object> ResourceAttributes { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cctest</para>
            /// </summary>
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries that match the query conditions. This parameter is returned by the List operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
