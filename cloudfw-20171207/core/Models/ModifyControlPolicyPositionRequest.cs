// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyControlPolicyPositionRequest : TeaModel {
        /// <summary>
        /// The direction of the traffic to which the IPv4 access control policy applies. Valid values:
        /// 
        /// *   in: inbound traffic
        /// *   out: outbound traffic
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The language of the content within the response. Valid values:
        /// 
        /// *   zh: Chinese (default)
        /// *   en: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The new priority of the IPv4 access control policy. You must specify a numeric value for this parameter. The value 1 indicates the highest priority. A larger value indicates a lower priority.
        /// 
        /// >  The new priority cannot exceed the priority range of the IPv4 access control policy. Otherwise, an error occurs when you call this operation. Before you call this operation, we recommend that you use the [DescribePolicyPriorUsed](https://help.aliyun.com/document_detail/138862.html) operation to query the priority range of the IPv4 access control policy in the specified direction.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NewOrder")]
        [Validation(Required=false)]
        public string NewOrder { get; set; }

        /// <summary>
        /// The original priority of the IPv4 access control policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OldOrder")]
        [Validation(Required=false)]
        public string OldOrder { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

    }

}
