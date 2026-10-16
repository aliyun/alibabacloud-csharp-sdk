// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class DownloadAgentSpecViaOssRequest : TeaModel {
        /// <summary>
        /// <para>The version number. If you do not specify this parameter, the version associated with the latest tag is downloaded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("agentSpecVersion")]
        [Validation(Required=false)]
        public string AgentSpecVersion { get; set; }

    }

}
