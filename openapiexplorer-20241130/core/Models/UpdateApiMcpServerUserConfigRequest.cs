// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class UpdateApiMcpServerUserConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable public network access for all API MCP Servers in your account, including the system MCP Server. By default, public network access is enabled. If you disable it, you can only access the servers through their VPC domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enablePublicAccess")]
        [Validation(Required=false)]
        public bool? EnablePublicAccess { get; set; }

        /// <summary>
        /// <para>The VPC whitelist. After disabling public network access, use this parameter to specify allowed source VPCs. If you do not set this parameter or leave it empty, all source VPCs are allowed.</para>
        /// </summary>
        [NameInMap("vpcWhitelists")]
        [Validation(Required=false)]
        public List<string> VpcWhitelists { get; set; }

    }

}
