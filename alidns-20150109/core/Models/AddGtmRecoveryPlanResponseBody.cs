// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddGtmRecoveryPlanResponseBody : TeaModel {
        /// <summary>
        /// The ID of the disaster recovery plan created.
        /// </summary>
        [NameInMap("RecoveryPlanId")]
        [Validation(Required=false)]
        public string RecoveryPlanId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
