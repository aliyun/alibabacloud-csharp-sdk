// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AgentAccessConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable AI request logging. Default value if omitted: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("aiRequestLogEnabled")]
        [Validation(Required=false)]
        public bool? AiRequestLogEnabled { get; set; }

        /// <summary>
        /// <para>The consumer authorization configuration for Agent access. If omitted, consumer authorization is not enabled.</para>
        /// </summary>
        [NameInMap("authorization")]
        [Validation(Required=false)]
        public AgentAccessConfigAuthorization Authorization { get; set; }
        public class AgentAccessConfigAuthorization : TeaModel {
            /// <summary>
            /// <para>The authentication type of the Agent access entry. Specify this parameter only when enabled is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Apikey</para>
            /// </summary>
            [NameInMap("authType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable consumer authorization. If set to true, authType must be specified and at least one principal must be provided. If set to false, no principals can be specified.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The list of consumers or consumer groups that are granted Agent access permissions. At least one principal must be specified when enabled is set to true.</para>
            /// </summary>
            [NameInMap("principals")]
            [Validation(Required=false)]
            public List<AgentAuthorizationPrincipal> Principals { get; set; }

        }

        /// <summary>
        /// <para>The base path of the Agent access entry. The path must start with a forward slash (/).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/agent</para>
        /// </summary>
        [NameInMap("basePath")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        /// <summary>
        /// <para>The list of domain name IDs bound to the Agent access entry. At least one domain name must be specified.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("domainIds")]
        [Validation(Required=false)]
        public List<string> DomainIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to remove the base path when forwarding requests to the backend. Default value if omitted: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("removeBasePathOnForward")]
        [Validation(Required=false)]
        public bool? RemoveBasePathOnForward { get; set; }

    }

}
