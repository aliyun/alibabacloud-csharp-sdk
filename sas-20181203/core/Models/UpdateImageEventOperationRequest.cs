// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateImageEventOperationRequest : TeaModel {
        /// <summary>
        /// The ID of the alert handling rule.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The application scope of the rule. The value is in the JSON format. Valid values:
        /// 
        /// *   **type**
        /// *   **value**
        /// </summary>
        [NameInMap("Scenarios")]
        [Validation(Required=false)]
        public string Scenarios { get; set; }

    }

}
