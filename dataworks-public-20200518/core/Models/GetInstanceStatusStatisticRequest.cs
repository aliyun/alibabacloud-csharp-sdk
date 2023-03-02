// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceStatusStatisticRequest : TeaModel {
        /// <summary>
        /// The date on which the numbers of instances in different states are obtained. Specify the date in the yyyy-MM-dd format.
        /// </summary>
        [NameInMap("BizDate")]
        [Validation(Required=false)]
        public string BizDate { get; set; }

        /// <summary>
        /// The type of the directed acyclic graph (DAG). Valid values:
        /// 
        /// *   MANUAL: DAG for a manually triggered workflow
        /// *   SMOKE_TEST: DAG for a smoke testing workflow
        /// *   SUPPLY_DATA: DAG for a data backfill instance
        /// *   BUSINESS_PROCESS_DAG: DAG for a one-time workflow
        /// </summary>
        [NameInMap("DagType")]
        [Validation(Required=false)]
        public string DagType { get; set; }

        /// <summary>
        /// The environment of the workspace. Valid values: PROD and DEV. The value PROD indicates the production environment. The value DEV indicates the development environment.
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace. You can log on to the DataWorks console and go to the Workspace Management page to obtain the workspace ID.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The scheduling type of the node. Valid values:
        /// 
        /// *   NORMAL: auto triggered node
        /// *   MANUAL: manually triggered node
        /// *   PAUSE: paused node
        /// *   SKIP: dry-run node
        /// </summary>
        [NameInMap("SchedulerType")]
        [Validation(Required=false)]
        public string SchedulerType { get; set; }

    }

}
