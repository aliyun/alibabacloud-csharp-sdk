// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateRemediationResponseBody : TeaModel {
        /// <summary>
        /// The ID of the remediation template.
        /// </summary>
        [NameInMap("RemediationId")]
        [Validation(Required=false)]
        public string RemediationId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
