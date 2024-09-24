// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyObjectGroupOperationRequest : TeaModel {
        /// <summary>
        /// The remarks of the operation.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The direction of the traffic to which the access control policy applies.
        /// 
        /// Valid values:
        /// 
        /// *   **in**: inbound.
        /// *   **out**: outbound.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The language of the content within the response. Valid values:
        /// 
        /// *   **zh** (default)
        /// *   **en**
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The operation objects.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ObjectList")]
        [Validation(Required=false)]
        public List<string> ObjectList { get; set; }

        /// <summary>
        /// The operation. Valid values:
        /// 
        /// *   **ignore**: adds the operation object to the whitelist.
        /// *   **cancelIgnore**: removes the operation object from the whitelist.
        /// *   **subscribe**: follows the operation object.
        /// *   **unsubscribe**: unfollows the operation object.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ObjectOperation")]
        [Validation(Required=false)]
        public string ObjectOperation { get; set; }

        /// <summary>
        /// The type of the operation object.
        /// 
        /// Valid values:
        /// 
        /// *   **assetsIp**: the asset IP address.
        /// *   **destinationIp**: the destination IP address.
        /// *   **destinationPort**: the destination port.
        /// *   **destinationDomain**: the destination domain name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
