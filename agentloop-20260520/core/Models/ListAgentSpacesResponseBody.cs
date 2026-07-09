// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListAgentSpacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The AgentSpaces information.</para>
        /// </summary>
        [NameInMap("agentSpaces")]
        [Validation(Required=false)]
        public List<ListAgentSpacesResponseBodyAgentSpaces> AgentSpaces { get; set; }
        public class ListAgentSpacesResponseBodyAgentSpaces : TeaModel {
            /// <summary>
            /// <para>The AgentSpace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-agent-space</para>
            /// </summary>
            [NameInMap("agentSpace")]
            [Validation(Required=false)]
            public string AgentSpace { get; set; }

            /// <summary>
            /// <para>The CMS workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-cms-workspace</para>
            /// </summary>
            [NameInMap("cmsWorkspace")]
            [Validation(Required=false)]
            public string CmsWorkspace { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-23T04:06:06Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The MSE namespace.</para>
            /// </summary>
            [NameInMap("mseNamespace")]
            [Validation(Required=false)]
            public ListAgentSpacesResponseBodyAgentSpacesMseNamespace MseNamespace { get; set; }
            public class ListAgentSpacesResponseBodyAgentSpacesMseNamespace : TeaModel {
                /// <summary>
                /// <para>The MSE namespace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>phoenixcloud-raw-logs</para>
                /// </summary>
                [NameInMap("namespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// <para>The MSE namespace name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>terraform-alicloud-modules</para>
                /// </summary>
                [NameInMap("namespaceName")]
                [Validation(Required=false)]
                public string NamespaceName { get; set; }

            }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The Simple Log Service project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-cms-1152309027070167-cn-beijing</para>
            /// </summary>
            [NameInMap("slsProject")]
            [Validation(Required=false)]
            public string SlsProject { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-02-11T08:40:23Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of results returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. This parameter is empty if no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b5754ef15c784abc8696d82790d2985c</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E4AC775-2358-5B52-B6FB-171459D7B14B</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
