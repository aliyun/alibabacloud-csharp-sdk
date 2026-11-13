// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreatePluginWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>The gateway type. If you do not specify this parameter, the server uses API as the default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI</para>
        /// </summary>
        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>The Codeup organization ID, which is the Yunxiao DevOps organization ID. The frontend obtains this ID by parsing ListPluginRepositories or after creating an organization.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>664f1e2xxxx</para>
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// <para>The repository name, which also serves as the English ID of the plugin. The backend does not validate the format. The frontend restricts the format to the regular expression /^(?![-.])[a-z0-9.-]{1,20}(?&lt;![-.])$/, which allows 1 to 20 lowercase letters, digits, periods, or hyphens, and cannot start or end with a period or a hyphen.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-custom-plugin</para>
        /// </summary>
        [NameInMap("repoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The workspace name, which is the Chinese name of the plugin. Note: This parameter is actually required. If it is omitted, the API returns a 400 InvalidParameter.IsEmpty error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-plugin</para>
        /// </summary>
        [NameInMap("workspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
