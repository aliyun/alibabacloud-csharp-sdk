// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class VerifyWorkspaceAcrRamAuthorizationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ACR Enterprise instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-1234567890abcdef</para>
        /// </summary>
        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>The target ACR namespace, which corresponds to artifact.container.namespace of the agent. This is not a Kubernetes namespace. It determines the authorization scope together with the instance and repository.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The target repository name, which corresponds to artifact.container.repo of the agent. It does not include tags, namespaces, or path separators. Wildcards are not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-image</para>
        /// </summary>
        [NameInMap("repository")]
        [Validation(Required=false)]
        public string Repository { get; set; }

    }

}
