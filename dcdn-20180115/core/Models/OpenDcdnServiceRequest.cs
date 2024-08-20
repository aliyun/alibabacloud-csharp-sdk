// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class OpenDcdnServiceRequest : TeaModel {
        /// <summary>
        /// The metering method of DCDN. Valid values:
        /// 
        /// *   **PayByTraffic**: pay-by-traffic
        /// *   **PayByBandwidth**: pay-by-bandwidth
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BillType")]
        [Validation(Required=false)]
        public string BillType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The metering method of WebSocket. Valid values:
        /// 
        /// *   **websockettraffic**: pay-by-data-transfer
        /// *   **websocketbps**: pay-by-bandwidth
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WebsocketBillType")]
        [Validation(Required=false)]
        public string WebsocketBillType { get; set; }

    }

}
