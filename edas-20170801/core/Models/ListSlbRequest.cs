// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListSlbRequest : TeaModel {
        /// <summary>
        /// The type of the IP addresses. Valid values:
        /// 
        /// *   Internet: Users can connect to the SLB instance over the Internet.
        /// *   Intranet: Users can connect to the SLB instance over the internal network.
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// The type of the SLB instance. Valid values:
        /// 
        /// *   clb: Classic Load Balancer (CLB)
        /// *   alb: Application Load Balancer (ALB)
        /// </summary>
        [NameInMap("SlbType")]
        [Validation(Required=false)]
        public string SlbType { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC).
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
