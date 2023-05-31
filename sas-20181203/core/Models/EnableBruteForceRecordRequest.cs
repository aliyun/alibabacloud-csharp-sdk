// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class EnableBruteForceRecordRequest : TeaModel {
        /// <summary>
        /// The IP address that is specified in the policy.
        /// </summary>
        [NameInMap("BlockIp")]
        [Validation(Required=false)]
        public string BlockIp { get; set; }

        /// <summary>
        /// The traffic direction that is specified in the policy. Valid values:
        /// 
        /// *   **in**: inbound
        /// *   **out**: outbound
        /// </summary>
        [NameInMap("Bound")]
        [Validation(Required=false)]
        public string Bound { get; set; }

        /// <summary>
        /// The ID of the policy that you want to enable.
        /// 
        /// > You can call the [DescribeBruteForceRecords](~~DescribeBruteForceRecords~~) operation to query the IDs of policies.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The port number.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The UUID of the server.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
