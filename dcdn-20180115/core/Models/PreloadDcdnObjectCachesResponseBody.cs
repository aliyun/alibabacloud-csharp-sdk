// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class PreloadDcdnObjectCachesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the prefetch task. Multiple IDs are separated by commas (,).
        /// </summary>
        [NameInMap("PreloadTaskId")]
        [Validation(Required=false)]
        public string PreloadTaskId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
