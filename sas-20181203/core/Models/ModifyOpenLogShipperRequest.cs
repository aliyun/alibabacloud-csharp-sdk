// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyOpenLogShipperRequest : TeaModel {
        /// <summary>
        /// The ID of the request source. Default value: **aegis**. Valid values:
        /// 
        /// *   **aegis**: Server Guard
        /// *   **sas**: Security Center
        /// 
        /// >  If you use Server Guard, set the value to **aegis**. If you use Security Center, set the value to **sas**.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// The Alibaba Cloud account ID of the member in the resource directory.
        /// 
        /// >  You can call the [DescribeMonitorAccounts](~~DescribeMonitorAccounts~~) operation to obtain the IDs.
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

    }

}
