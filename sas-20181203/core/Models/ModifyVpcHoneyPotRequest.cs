// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyVpcHoneyPotRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable or disable the honeypot. Valid values:
        /// 
        /// *   **disable**
        /// *   **enable**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("HoneyPotAction")]
        [Validation(Required=false)]
        public string HoneyPotAction { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) on which the honeypot is deployed.
        /// 
        /// >  You can call the [DescribeVpcHoneyPotList](~~DescribeVpcHoneyPotList~~) operation to query the IDs of VPCs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
