// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20240430.Models
{
    public class DescribeManualTaskInstanceResponseBody : TeaModel {
        [NameInMap("EmrClusterId")]
        [Validation(Required=false)]
        public string EmrClusterId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("ExternalAppId")]
        [Validation(Required=false)]
        public string ExternalAppId { get; set; }

        [NameInMap("ManualTaskInstanceId")]
        [Validation(Required=false)]
        public string ManualTaskInstanceId { get; set; }

        [NameInMap("ManualTaskInstanceName")]
        [Validation(Required=false)]
        public string ManualTaskInstanceName { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SubmitTime")]
        [Validation(Required=false)]
        public string SubmitTime { get; set; }

        [NameInMap("TaskParams")]
        [Validation(Required=false)]
        public string TaskParams { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
