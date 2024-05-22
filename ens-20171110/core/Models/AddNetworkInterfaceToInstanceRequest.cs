// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AddNetworkInterfaceToInstanceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to specify the instance.
        /// </summary>
        [NameInMap("AutoStart")]
        [Validation(Required=false)]
        public bool? AutoStart { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The network. The value is a JSON string. Only IPv6 is supported. Sample code of an IPv6 network: [{ "ipType": "public", "ipAddressType": "ipv6" }]
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Networks")]
        [Validation(Required=false)]
        public string Networks { get; set; }

    }

}
