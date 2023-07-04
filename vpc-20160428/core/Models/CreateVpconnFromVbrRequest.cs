// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpconnFromVbrRequest : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("OrderMode")]
        [Validation(Required=false)]
        public string OrderMode { get; set; }

        /// <summary>
        /// The ID of the shared Express Connect circuit.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The region ID of the shared Express Connect circuit.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// Specifies whether to only precheck the request. Valid values:
        /// 
        /// *   **true**: checks the API request. If the request passes the precheck, the operation is not performed. Check items include the request format, instance status, and whether the required parameters are specified. If the request fails the precheck, the system returns an error. If the request passes the precheck, the system returns the ID of the request.
        /// *   **false** (default): sends the API request. If the request passes the precheck, the operation is performed.
        /// </summary>
        [NameInMap("VbrId")]
        [Validation(Required=false)]
        public string VbrId { get; set; }

    }

}
