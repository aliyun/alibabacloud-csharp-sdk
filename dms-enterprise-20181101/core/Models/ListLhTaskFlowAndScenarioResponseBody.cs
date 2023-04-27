// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListLhTaskFlowAndScenarioResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The extended field. No meaning is specified for this field.
        /// </summary>
        [NameInMap("RawDAGList")]
        [Validation(Required=false)]
        public ListLhTaskFlowAndScenarioResponseBodyRawDAGList RawDAGList { get; set; }
        public class ListLhTaskFlowAndScenarioResponseBodyRawDAGList : TeaModel {
            [NameInMap("Dag")]
            [Validation(Required=false)]
            public List<ListLhTaskFlowAndScenarioResponseBodyRawDAGListDag> Dag { get; set; }
            public class ListLhTaskFlowAndScenarioResponseBodyRawDAGListDag : TeaModel {
                /// <summary>
                /// Indicates whether the task flow is deleted. Valid values:
                /// 
                /// *   **true**: deleted
                /// *   **false**: not deleted
                /// </summary>
                [NameInMap("CanEdit")]
                [Validation(Required=false)]
                public bool? CanEdit { get; set; }

                /// <summary>
                /// The ID of the workspace.
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// The status of the latest execution. Valid values:
                /// 
                /// *   **0**: invalid
                /// *   **1**: scheduling disabled
                /// *   **2**: waiting to be scheduled
                /// </summary>
                [NameInMap("CreatorNickName")]
                [Validation(Required=false)]
                public string CreatorNickName { get; set; }

                [NameInMap("DagName")]
                [Validation(Required=false)]
                public string DagName { get; set; }

                [NameInMap("DagOwnerId")]
                [Validation(Required=false)]
                public string DagOwnerId { get; set; }

                /// <summary>
                /// The ID of the latest deployment record.
                /// </summary>
                [NameInMap("DagOwnerNickName")]
                [Validation(Required=false)]
                public string DagOwnerNickName { get; set; }

                /// <summary>
                /// The name of the task flow owner.
                /// </summary>
                [NameInMap("DataFlowId")]
                [Validation(Required=false)]
                public long? DataFlowId { get; set; }

                /// <summary>
                /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) or [ListUserTenants](~~198074~~) operation to obtain the tenant ID.
                /// </summary>
                [NameInMap("DemoId")]
                [Validation(Required=false)]
                public string DemoId { get; set; }

                /// <summary>
                /// The ID of the business scenario.
                /// </summary>
                [NameInMap("DeployId")]
                [Validation(Required=false)]
                public long? DeployId { get; set; }

                /// <summary>
                /// The status of the task flow. Valid values:
                /// 
                /// *   **0**: invalid
                /// *   **1**: scheduling disabled
                /// *   **2**: waiting to be scheduled
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The ID of the user. You can call the [ListUsers](~~141938~~) or [GetUser](~~147098~~) operation to obtain the user ID.
                /// </summary>
                [NameInMap("IsDeleted")]
                [Validation(Required=false)]
                public bool? IsDeleted { get; set; }

                /// <summary>
                /// The name of the task flow.
                /// </summary>
                [NameInMap("LatestInstanceStatus")]
                [Validation(Required=false)]
                public int? LatestInstanceStatus { get; set; }

                /// <summary>
                /// Queries the task flows corresponding to a specific business scenario in a workspace in Data Management (DMS).
                /// </summary>
                [NameInMap("LatestInstanceTime")]
                [Validation(Required=false)]
                public int? LatestInstanceTime { get; set; }

                /// <summary>
                /// The task flows in the default business scenario.
                /// </summary>
                [NameInMap("ScenarioId")]
                [Validation(Required=false)]
                public long? ScenarioId { get; set; }

                /// <summary>
                /// The extended field. No meaning is specified for this field.
                /// </summary>
                [NameInMap("SpaceId")]
                [Validation(Required=false)]
                public long? SpaceId { get; set; }

                /// <summary>
                /// The ID of the task flow.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScenarioDAGList")]
        [Validation(Required=false)]
        public ListLhTaskFlowAndScenarioResponseBodyScenarioDAGList ScenarioDAGList { get; set; }
        public class ListLhTaskFlowAndScenarioResponseBodyScenarioDAGList : TeaModel {
            [NameInMap("ScenarioDAG")]
            [Validation(Required=false)]
            public List<ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListScenarioDAG> ScenarioDAG { get; set; }
            public class ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListScenarioDAG : TeaModel {
                [NameInMap("DagList")]
                [Validation(Required=false)]
                public ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListScenarioDAGDagList DagList { get; set; }
                public class ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListScenarioDAGDagList : TeaModel {
                    [NameInMap("Dag")]
                    [Validation(Required=false)]
                    public List<ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListScenarioDAGDagListDag> Dag { get; set; }
                    public class ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListScenarioDAGDagListDag : TeaModel {
                        [NameInMap("CanEdit")]
                        [Validation(Required=false)]
                        public bool? CanEdit { get; set; }

                        [NameInMap("CreatorId")]
                        [Validation(Required=false)]
                        public string CreatorId { get; set; }

                        [NameInMap("CreatorNickName")]
                        [Validation(Required=false)]
                        public string CreatorNickName { get; set; }

                        [NameInMap("DagName")]
                        [Validation(Required=false)]
                        public string DagName { get; set; }

                        [NameInMap("DagOwnerId")]
                        [Validation(Required=false)]
                        public string DagOwnerId { get; set; }

                        [NameInMap("DagOwnerNickName")]
                        [Validation(Required=false)]
                        public string DagOwnerNickName { get; set; }

                        [NameInMap("DataFlowId")]
                        [Validation(Required=false)]
                        public long? DataFlowId { get; set; }

                        [NameInMap("DemoId")]
                        [Validation(Required=false)]
                        public string DemoId { get; set; }

                        [NameInMap("DeployId")]
                        [Validation(Required=false)]
                        public long? DeployId { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        [NameInMap("IsDeleted")]
                        [Validation(Required=false)]
                        public bool? IsDeleted { get; set; }

                        [NameInMap("LatestInstanceStatus")]
                        [Validation(Required=false)]
                        public int? LatestInstanceStatus { get; set; }

                        [NameInMap("LatestInstanceTime")]
                        [Validation(Required=false)]
                        public int? LatestInstanceTime { get; set; }

                        [NameInMap("ScenarioId")]
                        [Validation(Required=false)]
                        public long? ScenarioId { get; set; }

                        [NameInMap("SpaceId")]
                        [Validation(Required=false)]
                        public long? SpaceId { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public int? Status { get; set; }

                    }

                }

                [NameInMap("Scenario")]
                [Validation(Required=false)]
                public ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListScenarioDAGScenario Scenario { get; set; }
                public class ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListScenarioDAGScenario : TeaModel {
                    [NameInMap("CreatorId")]
                    [Validation(Required=false)]
                    public string CreatorId { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("ScenarioName")]
                    [Validation(Required=false)]
                    public string ScenarioName { get; set; }

                }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
