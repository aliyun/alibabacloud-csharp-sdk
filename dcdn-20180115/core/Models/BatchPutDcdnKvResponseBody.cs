// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchPutDcdnKvResponseBody : TeaModel {
        /// <summary>
        /// The keys that failed to be written.
        /// </summary>
        [NameInMap("FailKeys")]
        [Validation(Required=false)]
        public List<string> FailKeys { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The keys that were written.
        /// </summary>
        [NameInMap("SuccessKeys")]
        [Validation(Required=false)]
        public List<string> SuccessKeys { get; set; }

    }

}
