// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListPrometheusVirtualInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance information.</para>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<ListPrometheusVirtualInstancesResponseBodyInstances> Instances { get; set; }
        public class ListPrometheusVirtualInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1750315319946</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The HTTP API URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxxxxxxx">http://xxxxxxxx</a></para>
            /// </summary>
            [NameInMap("httpApiUrl")]
            [Validation(Required=false)]
            public string HttpApiUrl { get; set; }

            /// <summary>
            /// <para>The applicable data source type: PROMETHEUS_DS.</para>
            /// <para>The Prometheus instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rw-b8cfbbe94194ac37fe83f3d2d16a</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The applicable query type: CMS_BASIC_QUERY.</para>
            /// <para>The namespace of the metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arms-prom</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-cloudspe</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17073812345</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of instances to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The next token for the next page. It is empty when all results are returned.</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>264C3E89-XXXX-XXXX-XXXX-CE9C2196C7DC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of instances returned.</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
