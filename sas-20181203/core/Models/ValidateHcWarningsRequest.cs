// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ValidateHcWarningsRequest : TeaModel {
        /// <summary>
        /// The IDs of risk items that you want to verify. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("RiskIds")]
        [Validation(Required=false)]
        public string RiskIds { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The UUIDs of servers on which you want to verify risk items.
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
