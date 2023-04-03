// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ExecuteGtmRecoveryPlanRequest : TeaModel {
        /// <summary>
        /// The language used by the user.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the disaster recovery plan that you want to executed.
        /// </summary>
        [NameInMap("RecoveryPlanId")]
        [Validation(Required=false)]
        public long? RecoveryPlanId { get; set; }

    }

}
