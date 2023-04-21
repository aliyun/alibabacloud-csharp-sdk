// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class VerifyCenResponseBody : TeaModel {
        /// <summary>
        /// The three random IPv4 CIDR blocks that are recommended. If the returned value of the Status parameter is Conflict, this parameter is returned.
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
        /// The information about the routes of the CEN instance.
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
            /// The ID of the network instance that is attached to the route.
            /// </summary>
            [NameInMap("NextHopInstanceId")]
            [Validation(Required=false)]
            public string NextHopInstanceId { get; set; }

            /// <summary>
            /// The ID of the region where the route resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The verification result for a route. Valid values:
            /// 
            /// *   Access: The route verification succeeds.
            /// *   Conflict: A CIDR block conflict exists.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The verification result. Valid values:
        /// 
        /// *   Access: The route verification succeeds. If the verification result for all routes succeeds, Access is returned for this parameter.
        /// *   Conflict: A CIDR block conflict exists. If the verification result of at least one route is Conflict, Conflict is returned for this parameter.
        /// *   InvalidCen.ParameterCenInstanceId: The ID of the CEN instance and the ID of the Alibaba Cloud account are invalid. The CEN instance does not belong to the Alibaba Cloud account.
        /// *   InvalidCen.CenUidInvalid: The ID of the Alibaba Cloud account is invalid or the Alibaba Cloud account is not granted the required permissions to access Elastic Desktop Service (EDS).
        /// *   VerifyCode.InvalidTokenCode: The verification code is invalid.
        /// *   VerifyCode.ReachTokenRetryTime: The retries of entering the verification code reaches the upper limit.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
