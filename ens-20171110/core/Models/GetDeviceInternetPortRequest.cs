// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetDeviceInternetPortRequest : TeaModel {
        /// <summary>
        /// The ID of the instance. You can specify the ID of the server or container. You can specify only one ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The type of the NAT gateway. The value must be of the enumerated data type. Valid values:
        /// 
        /// *   SNAT
        /// *   DNAT
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NatType")]
        [Validation(Required=false)]
        public string NatType { get; set; }

        /// <summary>
        /// The ID of the rule. If you leave this parameter empty, all rules are queried.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

    }

}
