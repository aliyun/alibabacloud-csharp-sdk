// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class TriggerPlaybookResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The running UUID of the playbook. This parameter is used to query the running result of the playbook.
        /// </summary>
        [NameInMap("TriggerUuid")]
        [Validation(Required=false)]
        public string TriggerUuid { get; set; }

    }

}
