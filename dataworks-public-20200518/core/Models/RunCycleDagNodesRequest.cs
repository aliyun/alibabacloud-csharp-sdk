// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RunCycleDagNodesRequest : TeaModel {
        /// <summary>
        /// The alert notification method. Valid values:
        /// 
        /// *   SMS
        /// *   MAIL
        /// *   SMS_MAIL
        /// </summary>
        [NameInMap("AlertNoticeType")]
        [Validation(Required=false)]
        public string AlertNoticeType { get; set; }

        /// <summary>
        /// The alert type. Valid values:
        /// 
        /// *   SUCCESS: An alert is generated when data backfill succeeds.
        /// *   FAILURE: An alert is generated when data backfill fails.
        /// *   SUCCESS_FAILURE: An alert is generated regardless of whether data backfill succeeds or fails.
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        /// <summary>
        /// The time when the node starts to run. This parameter is required only for auto triggered nodes that are scheduled by hour. Specify the value in the HH:mm:ss format. Valid values: 00:00:00 to 23:59:59.
        /// </summary>
        [NameInMap("BizBeginTime")]
        [Validation(Required=false)]
        public string BizBeginTime { get; set; }

        /// <summary>
        /// The time when the node stops running. This parameter is required only for auto triggered nodes that are scheduled by hour. Specify the value in the HH:mm:ss format. Valid values: 00:00:00 to 23:59:59.
        /// </summary>
        [NameInMap("BizEndTime")]
        [Validation(Required=false)]
        public string BizEndTime { get; set; }

        /// <summary>
        /// The number of nodes that can run in parallel. Valid values: 2 to 10.
        /// </summary>
        [NameInMap("ConcurrentRuns")]
        [Validation(Required=false)]
        public int? ConcurrentRuns { get; set; }

        /// <summary>
        /// The data timestamp at which data is no longer backfilled. Specify the value in the yyyy-MM-dd 00:00:00 format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndBizDate")]
        [Validation(Required=false)]
        public string EndBizDate { get; set; }

        /// <summary>
        /// The IDs of the nodes for which no data needs to be backfilled. The system generates dry-run instances for all these nodes. After these dry-run instances are scheduled, the statuses of these instances are directly set to successful, but the script is not run.
        /// </summary>
        [NameInMap("ExcludeNodeIds")]
        [Validation(Required=false)]
        public string ExcludeNodeIds { get; set; }

        /// <summary>
        /// The ID of the node for which you want to backfill data. If you want to backfill data for multiple nodes, separate the IDs of the nodes with commas (,). You can call the [ListNodes](https://help.aliyun.com/document_detail/173979.html) operation to obtain the node ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IncludeNodeIds")]
        [Validation(Required=false)]
        public string IncludeNodeIds { get; set; }

        /// <summary>
        /// The name of the workflow.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The parameters that need to be configured for the node. Set this parameter to a JSON string. The key indicates the ID of the node, and the value indicates the actual values of the parameters.
        /// </summary>
        [NameInMap("NodeParams")]
        [Validation(Required=false)]
        public string NodeParams { get; set; }

        /// <summary>
        /// Specifies whether data can be backfilled for multiple nodes at the same time.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Parallelism")]
        [Validation(Required=false)]
        public bool? Parallelism { get; set; }

        /// <summary>
        /// The environment of the workspace. Valid values: PROD and DEV. The value PROD indicates the production environment, and the value DEV indicates the development environment.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        /// <summary>
        /// The ID of the node for which data is first backfilled. You can call the [ListNodes](https://help.aliyun.com/document_detail/173979.html) operation to obtain the node ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RootNodeId")]
        [Validation(Required=false)]
        public long? RootNodeId { get; set; }

        /// <summary>
        /// The data timestamp at which data starts to be backfilled. Specify the value in the yyyy-MM-dd 00:00:00 format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartBizDate")]
        [Validation(Required=false)]
        public string StartBizDate { get; set; }

        /// <summary>
        /// Specifies whether to immediately run an instance that is scheduled to run in the future. If you set this parameter to true, the instance that is scheduled to run in the future is run immediately. Otherwise, the instance is run as scheduled.
        /// </summary>
        [NameInMap("StartFutureInstanceImmediately")]
        [Validation(Required=false)]
        public bool? StartFutureInstanceImmediately { get; set; }

    }

}
