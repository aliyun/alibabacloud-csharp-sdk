// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricDataResponseBody : TeaModel {
        /// <summary>
        /// The monitoring data. The value includes the following fields:
        /// 
        /// *   `timestamp`: the timestamp when the alert was triggered.
        /// *   `userId`: the ID of the user for which the alert was triggered.
        /// *   `instanceId`: the ID of the instance for which the alert was triggered.
        /// *   `Minimum`, `Average`, and `Maximum`: the aggregation methods.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public string Datapoints { get; set; }

        /// <summary>
        /// For more information about common request parameters, see [Common parameters](~~199331~~).
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
