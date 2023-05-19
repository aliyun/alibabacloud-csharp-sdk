// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateSecurityIpGroupResponseBody : TeaModel {
        /// <summary>
        /// The IP addresses or CIDR blocks in the IP address whitelist group.   
        /// The return values of SecurityIps are strings that are separated with commas (,).
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The operation that you want to perform.   
        /// Set the value to **CreateSecurityIpGroup**.
        /// </summary>
        [NameInMap("SecurityIpGroup")]
        [Validation(Required=false)]
        public CreateSecurityIpGroupResponseBodySecurityIpGroup SecurityIpGroup { get; set; }
        public class CreateSecurityIpGroupResponseBodySecurityIpGroup : TeaModel {
            /// <summary>
            /// ```
            /// http(s)://[Endpoint]/?Action=CreateSecurityIpGroup
            /// &InstanceId=ob317v4uif****
            /// &SecurityIps=192.168.1.1,192.168.0.0.1/8
            /// &SecurityIpGroupName=pay_online
            /// &Common request parameters
            /// ```
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// You can call this operation to create an IP address whitelist group.
            /// </summary>
            [NameInMap("SecurityIpGroupName")]
            [Validation(Required=false)]
            public string SecurityIpGroupName { get; set; }

            [NameInMap("SecurityIps")]
            [Validation(Required=false)]
            public string SecurityIps { get; set; }

        }

    }

}
