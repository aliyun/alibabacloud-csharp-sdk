// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class MigrateImageProtocolResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the images whose protocols failed to be updated.
        /// </summary>
        [NameInMap("FailedIds")]
        [Validation(Required=false)]
        public List<string> FailedIds { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
