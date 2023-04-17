// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class GetInstanceScreenshotResponseBody : TeaModel {
        /// <summary>
        /// The ID of the instance
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The JPG-formatted instance screenshot, which is encoded in Base64.
        /// </summary>
        [NameInMap("Screenshot")]
        [Validation(Required=false)]
        public string Screenshot { get; set; }

    }

}
