// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ExecuteJobRequest : TeaModel {
        /// <summary>
        /// Specifies whether to check the job status. Valid values: -**true**: The job can be run only if the job is enabled. -**false**: The job can be run even if the job is disabled.
        /// </summary>
        [NameInMap("CheckJobStatus")]
        [Validation(Required=false)]
        public bool? CheckJobStatus { get; set; }

        /// <summary>
        /// The type of the designated machine. Valid values: -**1**: worker. -**2**: label.
        /// </summary>
        [NameInMap("DesignateType")]
        [Validation(Required=false)]
        public int? DesignateType { get; set; }

        /// <summary>
        /// The application ID. You can obtain the application ID on the Application Management page in the SchedulerX console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The parameters that are passed to trigger the job to run. The input value can be a random string. The parameters that are passed are obtained by calling the `context.getInstanceParameters()` class in the `processor` code. The parameters are different from custom parameters for creating jobs.
        /// </summary>
        [NameInMap("InstanceParameters")]
        [Validation(Required=false)]
        public string InstanceParameters { get; set; }

        /// <summary>
        /// The job ID. You can obtain the job ID on the Task Management page in the SchedulerX console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// The label of the worker.
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// The namespace ID. You can obtain the namespace ID on the Namespace page in the SchedulerX console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The source of the namespace. This parameter is required only for a special third party.
        /// </summary>
        [NameInMap("NamespaceSource")]
        [Validation(Required=false)]
        public string NamespaceSource { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The worker address of the application. To query the worker address, call the GetWokerList operation.
        /// </summary>
        [NameInMap("Worker")]
        [Validation(Required=false)]
        public string Worker { get; set; }

    }

}
