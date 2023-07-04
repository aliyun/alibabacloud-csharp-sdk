// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnCrossAccountAuthorizationsResponseBody : TeaModel {
        /// <summary>
        /// The cross-account authorization information about the IPsec-VPN connection.
        /// </summary>
        [NameInMap("CrossAccountAuthorizations")]
        [Validation(Required=false)]
        public List<DescribeVpnCrossAccountAuthorizationsResponseBodyCrossAccountAuthorizations> CrossAccountAuthorizations { get; set; }
        public class DescribeVpnCrossAccountAuthorizationsResponseBodyCrossAccountAuthorizations : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account to which the IPsec-VPN connection belongs.
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// The ID of the CEN instance.
            /// </summary>
            [NameInMap("BindInstance")]
            [Validation(Required=false)]
            public string BindInstance { get; set; }

            /// <summary>
            /// The resource type of the authorization.
            /// 
            /// The value is set to **CEN**, which indicates that the IPsec-VPN connection can be associated with a transit router of a Cloud Enterprise Network (CEN) instance that belongs to another Alibaba Cloud account.
            /// </summary>
            [NameInMap("BindProduct")]
            [Validation(Required=false)]
            public string BindProduct { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account whose resource the IPsec-VPN connection can be associated with.
            /// </summary>
            [NameInMap("BindUid")]
            [Validation(Required=false)]
            public long? BindUid { get; set; }

            /// <summary>
            /// The timestamp when the authorization for the IPsec-VPN connection was created.
            /// 
            /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// The ID of the IPsec-VPN connection.
            /// </summary>
            [NameInMap("VpnConnectionId")]
            [Validation(Required=false)]
            public string VpnConnectionId { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
