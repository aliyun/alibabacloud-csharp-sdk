// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class RerunJobRequest : TeaModel {
        /// <summary>
        /// The data timestamp of the job. Specify a string in the HH:mm:ss format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataTime")]
        [Validation(Required=false)]
        public string DataTime { get; set; }

        /// <summary>
        /// The time when the job stops running. Specify a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// The application group ID. You can obtain the application group ID on the Application Management page in the SchedulerX console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The job ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

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
        /// The time when the job starts to rerun. Specify a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

    }

}
