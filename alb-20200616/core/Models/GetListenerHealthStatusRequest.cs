// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class GetListenerHealthStatusRequest : TeaModel {
        /// <summary>
        /// Specifies whether to return the health check results of forwarding rules. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("IncludeRule")]
        [Validation(Required=false)]
        public bool? IncludeRule { get; set; }

        /// <summary>
        /// The listener ID.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **1** to **30**. Default value: **20**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the query. Valid values:
        /// 
        /// *   If this is your first query or no next queries are to be sent, ignore this parameter.
        /// *   If a next query is to be sent, set the value to the value of **NextToken** that is returned from the last call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
