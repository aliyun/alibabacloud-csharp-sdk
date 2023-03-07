// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetJobLogRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The node on which the job runs.
        /// 
        /// *   If the job is completed, you do not need to specify the parameter.
        /// *   If the job is running, you must specify the parameter.
        /// </summary>
        [NameInMap("ExecHost")]
        [Validation(Required=false)]
        public string ExecHost { get; set; }

        /// <summary>
        /// The ID of the job.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// The position where logs start to be read.
        /// 
        /// Unit: bits
        /// 
        /// Default value: 0
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        /// <summary>
        /// The maximum size of logs that you can read in a single request.
        /// 
        /// Unit: bits
        /// 
        /// Default value: 1024
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
