// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListPermissionApplyOrdersRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. You can query all the permissions request orders that have been submitted before the time. The parameter value is a UNIX timestamp. If you do not specify the parameter, all permission request orders that are submitted before the current time are queried.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The type of the compute engine with which the permission request order is associated. The parameter value is odps and cannot be changed. This value indicates that you can request permissions only on fields of tables in the MaxCompute compute engine.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// The status of the permission request order. Valid values:
        /// 
        /// *   1: to be processed
        /// *   2: approved and authorized
        /// *   3: approved but authorization failed
        /// *   4: rejected
        /// 
        /// Valid values:
        /// 
        /// *   0
        /// *   1
        /// *   2
        /// *   3
        /// *   4
        /// *   5
        /// </summary>
        [NameInMap("FlowStatus")]
        [Validation(Required=false)]
        public int? FlowStatus { get; set; }

        /// <summary>
        /// The name of the MaxCompute project with which the permission request order is associated. If you do not specify the parameter, the permission request orders of all MaxCompute projects are returned.
        /// </summary>
        [NameInMap("MaxComputeProjectName")]
        [Validation(Required=false)]
        public string MaxComputeProjectName { get; set; }

        /// <summary>
        /// The type of the permission request order. The parameter value is 1 and cannot be changed. This value indicates ACL-based authorization.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public int? OrderType { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10. Maximum value: 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The query type of the permission request order. Valid values:
        /// 
        /// *   0: The permission request orders you submitted.
        /// *   1: The permission request orders you approved.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public int? QueryType { get; set; }

        /// <summary>
        /// The beginning of the time range to query. You can query all the permissions request orders that have been submitted after the time. The parameter value is a UNIX timestamp. If you do not specify the parameter, all permission request orders are queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// The name of the table with which the permission request order is associated. If you do not specify the parameter, the permission request orders of all tables are returned.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace that is associated with the permission request order. If you do not specify the parameter, the permission request orders of all workspaces are returned. You can go to the Workspace page in the DataWorks console to obtain the workspace ID.
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public int? WorkspaceId { get; set; }

    }

}
