// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AddDeviceInternetPortRequest : TeaModel {
        /// <summary>
        /// The Internet service provider (ISP). If you leave this parameter empty, the system automatically allows a random ISP. Valid values:
        /// 
        /// *   telecom: China Telecom
        /// *   cmcc: China Mobile
        /// *   unicom: China Unicom
        /// *   cbn: China Broadcasting Network (CBN)
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// The ID of the instance. You can specify the ID of the server or container.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The internal IP address of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InternalIp")]
        [Validation(Required=false)]
        public string InternalIp { get; set; }

        /// <summary>
        /// The internal port number. Specify this parameter in the following format: first port/last port. Separate multiple port number groups with commas (,). Example: 1026/2001,2005/2005. This parameter is required if you set NatType to DNAT. If you set NatType to SNAT, the value of this parameter is invalid.
        /// </summary>
        [NameInMap("InternalPort")]
        [Validation(Required=false)]
        public string InternalPort { get; set; }

        /// <summary>
        /// The type of the NAT gateway. The value of this parameter is of the enumerated data type. Valid values:
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
        /// The ID of the Edge Node Service (ENS) node.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
