// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddVpcHoneyPotRequest : TeaModel {
        /// <summary>
        /// The ID of the virtual private cloud (VPC) in which you want to create a honeypot.
        /// 
        /// >  You can call the [DescribeVpcList](~~DescribeVpcList~~) operation to obtain the VPC ID. The VPC ID is the value of the InstanceId parameter.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
