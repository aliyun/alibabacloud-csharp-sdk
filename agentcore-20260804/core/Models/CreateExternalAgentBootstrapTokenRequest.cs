// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateExternalAgentBootstrapTokenRequest : TeaModel {
        /// <summary>
        /// <para>The network type for onboarding. Valid values: INTRANET (internal network) and INTERNET (Internet).</para>
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
