// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DisableCustomBlockRecordRequest : TeaModel {
        /// <summary>
        /// The IP address that is specified in the policy.
        /// 
        /// > You can call the [DescribeCustomBlockRecords](~~DescribeCustomBlockRecords~~) operation to query the IP address.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BlockIp")]
        [Validation(Required=false)]
        public string BlockIp { get; set; }

        /// <summary>
        /// The traffic direction that is specified in the policy. Valid values:
        /// 
        /// *   **in**: inbound
        /// *   **out**: outbound
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Bound")]
        [Validation(Required=false)]
        public string Bound { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
