// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GenerateOnceTaskResponseBody : TeaModel {
        /// <summary>
        /// The number of scan tasks that are complete.
        /// </summary>
        [NameInMap("CanCreate")]
        [Validation(Required=false)]
        public bool? CanCreate { get; set; }

        [NameInMap("CollectTime")]
        [Validation(Required=false)]
        public long? CollectTime { get; set; }

        [NameInMap("FinishCount")]
        [Validation(Required=false)]
        public int? FinishCount { get; set; }

        [NameInMap("LastTask")]
        [Validation(Required=false)]
        public string LastTask { get; set; }

        /// <summary>
        /// The ID of the scan task.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
