// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeBlackListClientsResponseBody : TeaModel {
        /// <summary>
        /// The IDs of clients and the status of each client. This parameter contains a JSON object, for example, {"client1": "EVICTING","client2":"EVICTED"}.
        /// 
        /// Available client statuses include:
        /// 
        /// *   EVICTING indicates that a client is being removed
        /// *   EVICTED indicates that a client is removed
        /// *   ACCEPTING indicates that the write access to the file system is being granted to a client
        /// *   ACCEPTABLE indicates that the write access to the file system is granted to a client
        /// </summary>
        [NameInMap("Clients")]
        [Validation(Required=false)]
        public string Clients { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
