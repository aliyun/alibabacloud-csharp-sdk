// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AttachVbrToVpconnRequest : TeaModel {
        /// <summary>
        /// Specifies whether to precheck the request only. Valid values:
        /// 
        /// *   **true**: only prechecks the request but does not associate the VBR with the hosted connection. The system prechecks the request syntax, instance status, and whether the required parameters are specified. An error message is returned if the request fails to pass the precheck. If the request passes the precheck, the system returns the ID of the request.
        /// *   **false** (default): sends the request. If the request passes the precheck, the VBR is associated with the hosted connection.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The region ID of the hosted connection.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// The client token must be unique among different requests. It can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// The ID of the VBR.
        /// </summary>
        [NameInMap("VbrId")]
        [Validation(Required=false)]
        public string VbrId { get; set; }

        /// <summary>
        /// The ID of the hosted connection.
        /// </summary>
        [NameInMap("VpconnId")]
        [Validation(Required=false)]
        public string VpconnId { get; set; }

    }

}
