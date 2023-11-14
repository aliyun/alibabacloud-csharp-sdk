// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyImageFixCycleConfigResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the configurations of the scheduled image fix are modified.
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
