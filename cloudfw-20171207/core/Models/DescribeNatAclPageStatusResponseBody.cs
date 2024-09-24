// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatAclPageStatusResponseBody : TeaModel {
        /// <summary>
        /// Extra error information.
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// Indicates whether pagination for access control policies for NAT firewalls is supported.
        /// </summary>
        [NameInMap("NatAclPageEnable")]
        [Validation(Required=false)]
        public bool? NatAclPageEnable { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
