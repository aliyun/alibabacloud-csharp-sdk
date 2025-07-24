// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListServicesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2-ba4d-4b9f-aa24-dcb067a30f1c</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0CEC5375-C554-562B-A65F-9A629907C1F0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("services")]
        [Validation(Required=false)]
        public List<ListServicesResponseBodyServices> Services { get; set; }
        public class ListServicesResponseBodyServices : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;language&quot;:&quot;java&quot;}</para>
            /// </summary>
            [NameInMap("attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-07-01T02:23:59Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>workspace api monitor test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>kgcsf@192197e828d51aa</para>
            /// </summary>
            [NameInMap("pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>jm2pl0yoqf@d4905cb11a4f218dfb0a8</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo-app</para>
            /// </summary>
            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("serviceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TRACE</para>
            /// </summary>
            [NameInMap("serviceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default-cms-1192928460540589-cn-hangzhou</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>66</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
