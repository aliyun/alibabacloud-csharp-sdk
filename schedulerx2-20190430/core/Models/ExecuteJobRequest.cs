// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ExecuteJobRequest : TeaModel {
        [NameInMap("CheckJobStatus")]
        [Validation(Required=false)]
        public bool? CheckJobStatus { get; set; }

        /// <summary>
        /// 指定机器类型：1.workerAddr; 2. label
        /// </summary>
        [NameInMap("DesignateType")]
        [Validation(Required=false)]
        public int? DesignateType { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("InstanceParameters")]
        [Validation(Required=false)]
        public string InstanceParameters { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// 指定机器的标签
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("NamespaceSource")]
        [Validation(Required=false)]
        public string NamespaceSource { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 指定机器的workerAddr
        /// </summary>
        [NameInMap("Worker")]
        [Validation(Required=false)]
        public string Worker { get; set; }

    }

}
