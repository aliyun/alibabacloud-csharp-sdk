// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateLogstashDescriptionResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result returned.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateLogstashDescriptionResponseBodyResult Result { get; set; }
        public class UpdateLogstashDescriptionResponseBodyResult : TeaModel {
            /// <summary>
            /// The name of the cluster.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

    }

}
