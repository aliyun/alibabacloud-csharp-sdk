// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribeNetworkRuleResponseBody : TeaModel {
        /// <summary>
        /// The ARN of the access control rule.
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// The description.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The private IP address or private CIDR block.
        /// </summary>
        [NameInMap("SourcePrivateIp")]
        [Validation(Required=false)]
        public string SourcePrivateIp { get; set; }

        /// <summary>
        /// The network type. Only private IP addresses are supported. The value is fixed as Private.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
