// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ExportImageResponseBody : TeaModel {
        /// <summary>
        /// The URL that points to the exported image.
        /// </summary>
        [NameInMap("ExportedImageURL")]
        [Validation(Required=false)]
        public string ExportedImageURL { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
