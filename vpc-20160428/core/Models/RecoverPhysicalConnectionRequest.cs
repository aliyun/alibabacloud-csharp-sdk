// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class RecoverPhysicalConnectionRequest : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Specifies whether to precheck the request only. Valid values:
        /// 
        /// *   **true**: only prechecks the request but does not resume the Express Connect circuit. The system prechecks the request syntax, instance status, and whether the required parameters are specified. An error message is returned if the request fails to pass the precheck. If the request passes the precheck, the system returns the ID of the request.
        /// *   **false** (default): sends the request. If the request passes the precheck, the Express Connect circuit is resumed.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The region ID of the Express Connect circuit.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
