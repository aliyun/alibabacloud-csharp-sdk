// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class VerifyAtiAgentRegisterInfoAcmeChallengeRecordRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2074753647748672512</para>
        /// </summary>
        [NameInMap("AgentRegisterInfoId")]
        [Validation(Required=false)]
        public string AgentRegisterInfoId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJhbGciOiJIUzI1NiIsInR5cC.....</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
