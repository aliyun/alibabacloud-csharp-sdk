// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QueryPublicModelEngineResponseBody : TeaModel {
        /// <summary>
        /// The unique ID of the request. You can troubleshoot errors based on the ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the data modeling engine that is returned.
        /// </summary>
        [NameInMap("ReturnValue")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> ReturnValue { get; set; }

    }

}
