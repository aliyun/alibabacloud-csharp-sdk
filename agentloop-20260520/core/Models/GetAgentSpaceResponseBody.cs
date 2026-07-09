// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetAgentSpaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the AgentSpace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-agent-space</para>
        /// </summary>
        [NameInMap("agentSpace")]
        [Validation(Required=false)]
        public string AgentSpace { get; set; }

        /// <summary>
        /// <para>The CloudMonitor workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-cms-workspace</para>
        /// </summary>
        [NameInMap("cmsWorkspace")]
        [Validation(Required=false)]
        public string CmsWorkspace { get; set; }

        /// <summary>
        /// <para>The binding type of the CloudMonitor 2.0 workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AutoCreated</para>
        /// </summary>
        [NameInMap("cmsWorkspaceBindType")]
        [Validation(Required=false)]
        public string CmsWorkspaceBindType { get; set; }

        /// <summary>
        /// <para>The time when the AgentSpace was created.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-05-05T12:39:36Z</para>
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
        /// <para>The Microservices Engine (MSE) namespace.</para>
        /// </summary>
        [NameInMap("mseNamespace")]
        [Validation(Required=false)]
        public GetAgentSpaceResponseBodyMseNamespace MseNamespace { get; set; }
        public class GetAgentSpaceResponseBodyMseNamespace : TeaModel {
            /// <summary>
            /// <para>The ID of the MSE namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>emr-dataware</para>
            /// </summary>
            [NameInMap("namespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The name of the MSE namespace.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0173835-9E0F-508F-8BFA-9F556E59C302</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The name of the Simple Log Service project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-cms-1837787111545040-cn-beijing</para>
        /// </summary>
        [NameInMap("slsProject")]
        [Validation(Required=false)]
        public string SlsProject { get; set; }

        /// <summary>
        /// <para>The time when the AgentSpace was last updated.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-20T02:28:14Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
