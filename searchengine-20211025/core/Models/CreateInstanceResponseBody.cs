// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class CreateInstanceResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result returned
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateInstanceResponseBodyResult Result { get; set; }
        public class CreateInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// The ID of the instance
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

    }

}
