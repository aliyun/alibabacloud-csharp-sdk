// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AgentAccessConfig : TeaModel {
        [NameInMap("aiRequestLogEnabled")]
        [Validation(Required=false)]
        public bool? AiRequestLogEnabled { get; set; }

        [NameInMap("authorization")]
        [Validation(Required=false)]
        public AgentAccessConfigAuthorization Authorization { get; set; }
        public class AgentAccessConfigAuthorization : TeaModel {
            [NameInMap("authType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("principals")]
            [Validation(Required=false)]
            public List<AgentAuthorizationPrincipal> Principals { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("basePath")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("domainIds")]
        [Validation(Required=false)]
        public List<string> DomainIds { get; set; }

        [NameInMap("removeBasePathOnForward")]
        [Validation(Required=false)]
        public bool? RemoveBasePathOnForward { get; set; }

    }

}
