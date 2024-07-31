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
        /// 
        /// This parameter is required.
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
        /// 
        /// <!---->
        /// 
        /// *   DAILY
        /// *   MANUAL
        /// *   SMOKE_TEST
        /// *   SUPPLY_DATA
        /// *   BUSINESS_PROCESS_DAG
        /// </summary>
        [NameInMap("DagType")]
        [Validation(Required=false)]
        public string DagType { get; set; }

        /// <summary>
        /// The runtime environment. Valid values: PROD and DEV.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        /// <summary>
        /// The DataWorks workspace ID. You can log on to the DataWorks console and go to the Workspace page to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The scheduling cycle. Valid values:
        /// 
        /// *   MINUTE
        /// *   HOUR
        /// *   DAY
        /// *   WEEK
        /// *   MONTH
        /// </summary>
        [NameInMap("SchedulerPeriod")]
        [Validation(Required=false)]
        public string SchedulerPeriod { get; set; }

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
