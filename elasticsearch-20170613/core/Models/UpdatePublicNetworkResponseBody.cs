// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdatePublicNetworkResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The return results.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdatePublicNetworkResponseBodyResult Result { get; set; }
        public class UpdatePublicNetworkResponseBodyResult : TeaModel {
            /// <summary>
            /// The status of the public network access switch.
            /// </summary>
            [NameInMap("enablePublic")]
            [Validation(Required=false)]
            public bool? EnablePublic { get; set; }

        }

    }

}
