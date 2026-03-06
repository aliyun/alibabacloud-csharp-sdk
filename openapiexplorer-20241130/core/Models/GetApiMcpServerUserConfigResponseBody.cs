// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class GetApiMcpServerUserConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of your Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>162302724684579*</para>
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable public network access for all API MCP Servers, including system MCP Servers, under your account. By default, this feature is enabled. If you disable it, you can access the servers only through VPC domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enablePublicAccess")]
        [Validation(Required=false)]
        public bool? EnablePublicAccess { get; set; }

        /// <summary>
        /// <para>The time when the configuration was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-11-10T06:58:39Z</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The time when the configuration was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-11-10T06:58:39Z</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A707AFA8-1A4C-5B2A-A165-8436C1EA38DB</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The whitelist of source VPCs that are allowed to send requests after public network access is disabled. If you do not set this parameter or leave it empty, requests from all sources are allowed.</para>
        /// </summary>
        [NameInMap("vpcWhitelists")]
        [Validation(Required=false)]
        public List<string> VpcWhitelists { get; set; }

    }

}
