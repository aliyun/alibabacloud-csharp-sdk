// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetIntervalLimitOfSLAResponseBody : TeaModel {
        /// <summary>
        /// GetIntervalLimitOfSLA
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("IntervalLimit")]
        [Validation(Required=false)]
        public int? IntervalLimit { get; set; }

        /// <summary>
        /// Queries the minimum scheduling cycle of a task flow when a service level agreement (SLA) timeout rule is configured for the task flow.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
