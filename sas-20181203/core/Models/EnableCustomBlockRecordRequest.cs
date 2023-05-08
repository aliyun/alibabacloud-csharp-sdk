// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class EnableCustomBlockRecordRequest : TeaModel {
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

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
