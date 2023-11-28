// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ValidateShrinkNodesRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<ValidateShrinkNodesRequestBody> Body { get; set; }
        public class ValidateShrinkNodesRequestBody : TeaModel {
            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("hostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("nodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("ignoreStatus")]
        [Validation(Required=false)]
        public bool? IgnoreStatus { get; set; }

        /// <summary>
        /// Returned results:
        /// 
        /// *   true: can be scaled in
        /// *   false: cannot be scaled in.
        /// </summary>
        [NameInMap("nodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

    }

}
