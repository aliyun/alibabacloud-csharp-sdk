// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteSyntheticTaskResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the specified tasks are deleted.
        /// 
        /// *   `true`: The tasks are deleted.
        /// *   `false`: The tasks fail to be deleted.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

    }

}
