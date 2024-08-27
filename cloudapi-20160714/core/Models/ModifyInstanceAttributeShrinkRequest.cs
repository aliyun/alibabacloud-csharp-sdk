// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyInstanceAttributeShrinkRequest : TeaModel {
        [NameInMap("DeleteVpcIpBlock")]
        [Validation(Required=false)]
        public string DeleteVpcIpBlock { get; set; }

        [NameInMap("EgressIpv6Enable")]
        [Validation(Required=false)]
        public string EgressIpv6Enable { get; set; }

        [NameInMap("HttpsPolicy")]
        [Validation(Required=false)]
        public string HttpsPolicy { get; set; }

        [NameInMap("IPV6Enabled")]
        [Validation(Required=false)]
        public string IPV6Enabled { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("IntranetSegments")]
        [Validation(Required=false)]
        public string IntranetSegments { get; set; }

        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        /// <summary>
        /// The information about the CIDR block that API Gateway can use to access the virtual private cloud (VPC) of the backend service.
        /// </summary>
        [NameInMap("ToConnectVpcIpBlock")]
        [Validation(Required=false)]
        public string ToConnectVpcIpBlockShrink { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        [NameInMap("VpcSlbIntranetEnable")]
        [Validation(Required=false)]
        public string VpcSlbIntranetEnable { get; set; }

    }

}
