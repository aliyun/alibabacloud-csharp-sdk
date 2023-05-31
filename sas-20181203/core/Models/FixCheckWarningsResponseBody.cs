// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class FixCheckWarningsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the baseline risk item that has been fixed by using the Batch Repair feature.
        /// </summary>
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public long? BatchId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
