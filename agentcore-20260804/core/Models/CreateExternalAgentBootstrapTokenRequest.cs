// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateExternalAgentBootstrapTokenRequest : TeaModel {
        /// <summary>
        /// <para>The network type for connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INTERNET: public network</description></item>
        /// <item><description>INTRANET: internal network</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INTERNET</para>
        /// </summary>
        [NameInMap("networkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

    }

}
