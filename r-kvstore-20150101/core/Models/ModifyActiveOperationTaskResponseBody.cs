// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyActiveOperationTaskResponseBody : TeaModel {
        /// <summary>
        /// The ID of the O\\&M task. IDs are separated by commas (,).
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
