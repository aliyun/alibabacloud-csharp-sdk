// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyPushAllTaskRequest : TeaModel {
        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The UUIDs of servers on which you want to perform security check tasks. Separate multiple UUIDs with commas (,).
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public string Tasks { get; set; }

        /// <summary>
        /// The message that describes the security check failure.
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
