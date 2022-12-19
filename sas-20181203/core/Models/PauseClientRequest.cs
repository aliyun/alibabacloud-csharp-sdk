// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class PauseClientRequest : TeaModel {
        /// <summary>
        /// The list of servers for which you want to enable or disable the Security Center agent.
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

        /// <summary>
        /// The status of the Security Center agent. Valid values:
        /// - **0**: disabled
        /// - **1**: enabled
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
