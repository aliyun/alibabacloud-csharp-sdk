// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class QueryTreeDataResponseBody : TeaModel {
        /// <summary>
        /// The returned information about the playbook. The value is a JSON string.
        /// </summary>
        [NameInMap("Playbooks")]
        [Validation(Required=false)]
        public string Playbooks { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
