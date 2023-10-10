// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescirbeWorkflowResponseBody : TeaModel {
        /// <summary>
        /// The time when the workflow was created.
        /// </summary>
        [NameInMap("create_time")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The duration of the workflow.
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// The end time of the task.
        /// </summary>
        [NameInMap("finish_time")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// The size of the input data.
        /// </summary>
        [NameInMap("input_data_size")]
        [Validation(Required=false)]
        public string InputDataSize { get; set; }

        /// <summary>
        /// The name of the workflow.
        /// </summary>
        [NameInMap("job_name")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// The namespace to which the workflow belongs.
        /// </summary>
        [NameInMap("job_namespace")]
        [Validation(Required=false)]
        public string JobNamespace { get; set; }

        /// <summary>
        /// The size of the output data.
        /// </summary>
        [NameInMap("output_data_size")]
        [Validation(Required=false)]
        public string OutputDataSize { get; set; }

        /// <summary>
        /// The current state of the workflow.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The number of base pairs.
        /// </summary>
        [NameInMap("total_bases")]
        [Validation(Required=false)]
        public string TotalBases { get; set; }

        /// <summary>
        /// The number of reads.
        /// </summary>
        [NameInMap("total_reads")]
        [Validation(Required=false)]
        public string TotalReads { get; set; }

        /// <summary>
        /// The user input parameters.
        /// </summary>
        [NameInMap("user_input_data")]
        [Validation(Required=false)]
        public string UserInputData { get; set; }

    }

}
