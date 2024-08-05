// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeAlertConfigurationResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the scaling activities that trigger text message, internal message, or email-based notifications.
        /// </summary>
        [NameInMap("ScaleStatuses")]
        [Validation(Required=false)]
        public List<string> ScaleStatuses { get; set; }

    }

}
