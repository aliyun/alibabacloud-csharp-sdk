// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CheckSecurityEventIdRequest : TeaModel {
        /// <summary>
        /// The IDs of alert events. You can specify up to 100 IDs. If you do not specify this parameter, the value of the response parameter **Data** is **false**. The value false indicates that no alert events are generated on the server.
        /// 
        /// > You can call the [DescribeSuspEvents](~~DescribeSuspEvents~~) operation to query the IDs of alert events.
        /// </summary>
        [NameInMap("SecurityEventIds")]
        [Validation(Required=false)]
        public List<string> SecurityEventIds { get; set; }

        /// <summary>
        /// The UUID of the server.
        /// 
        /// > You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
