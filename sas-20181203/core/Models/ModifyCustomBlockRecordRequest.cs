// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyCustomBlockRecordRequest : TeaModel {
        /// <summary>
        /// The IP address that you want to specify in the policy.
        /// </summary>
        [NameInMap("BlockIp")]
        [Validation(Required=false)]
        public string BlockIp { get; set; }

        /// <summary>
        /// The traffic direction that you want to specify in the policy. Valid values:
        /// 
        /// *   **in**: inbound
        /// *   **out**: outbound
        /// </summary>
        [NameInMap("Bound")]
        [Validation(Required=false)]
        public string Bound { get; set; }

        /// <summary>
        /// The expiration time of the policy.
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The UUIDs of servers.
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
