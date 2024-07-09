// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class VerifyCenResponseBody : TeaModel {
        /// <summary>
        /// The recommended IPv4 CIDR blocks. Three CIDR blocks are randomly recommended. This parameter is returned when the `Status` value is `Conflict`.
        /// </summary>
        [NameInMap("CidrBlocks")]
        [Validation(Required=false)]
        public List<string> CidrBlocks { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The routes provided by the CEN instance.
        /// </summary>
        [NameInMap("RouteEntries")]
        [Validation(Required=false)]
        public List<VerifyCenResponseBodyRouteEntries> RouteEntries { get; set; }
        public class VerifyCenResponseBodyRouteEntries : TeaModel {
            /// <summary>
            /// The CIDR block of the route.
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// The ID of the instance corresponding to the route.
            /// </summary>
            [NameInMap("NextHopInstanceId")]
            [Validation(Required=false)]
            public string NextHopInstanceId { get; set; }

            /// <summary>
            /// The region ID of the route.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The verification result of the route.
            /// 
            /// Valid values:
            /// 
            /// *   Conflict: A CIDR block conflict exists.
            /// *   Access: The verification is passed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The check result of CIDR block conflict.
        /// 
        /// Valid values:
        /// 
        /// *   InvalidCen.CenUidInvalid: The Alibaba Cloud account is invalid or the Alibaba Cloud account does not have the permission to access Elastic Desktop Service.
        /// *   VerifyCode.InvalidTokenCode: The verification code is invalid.
        /// *   VerifyCode.ReachTokenRetryTime: The maximum number of times for entering a verification code reaches the limit.
        /// *   Conflict: A CIDR block conflict exists. If the verification result of at least one route is Conflict, Conflict is returned for this parameter.
        /// *   Access: The verification is passed. If the verification result for all routes is Access, Access is returned for this parameter.
        /// *   InvalidCen.ParameterCenInstanceId: The Alibaba Cloud account does not own the CEN instance.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
