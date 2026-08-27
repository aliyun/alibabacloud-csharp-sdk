// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreatePluginWorkspaceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>AI</para>
        /// </summary>
        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>664f1e2xxxx</para>
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-custom-plugin</para>
        /// </summary>
        [NameInMap("repoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-plugin</para>
        /// </summary>
        [NameInMap("workspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
