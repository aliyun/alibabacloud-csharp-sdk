// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteTableLevelResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the table level was deleted.
        /// </summary>
        [NameInMap("DeleteResult")]
        [Validation(Required=false)]
        public bool? DeleteResult { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
