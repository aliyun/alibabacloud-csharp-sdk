// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListLhTaskFlowAndScenarioResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request fails.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The task flows in the default business scenario.
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
                /// Indicates whether the task flow can be modified. Valid values:
                /// 
                /// *   **true**: The task flow can be modified.
                /// *   **false**: The task flow cannot be modified.
                /// </summary>
                [NameInMap("CanEdit")]
                [Validation(Required=false)]
                public bool? CanEdit { get; set; }

                /// <summary>
                /// The ID of the user who creates the task flow.
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// The name of the user who creates the workspace.
                /// </summary>
                [NameInMap("CreatorNickName")]
                [Validation(Required=false)]
                public string CreatorNickName { get; set; }

                /// <summary>
                /// The name of the task flow.
                /// </summary>
                [NameInMap("DagName")]
                [Validation(Required=false)]
                public string DagName { get; set; }

                /// <summary>
                /// The user ID of the task flow owner.
                /// </summary>
                [NameInMap("DagOwnerId")]
                [Validation(Required=false)]
                public string DagOwnerId { get; set; }

                /// <summary>
                /// The name of the task flow owner.
                /// </summary>
                [NameInMap("DagOwnerNickName")]
                [Validation(Required=false)]
                public string DagOwnerNickName { get; set; }

                /// <summary>
                /// The extended field. No meaning is specified for this field.
                /// </summary>
                [NameInMap("DataFlowId")]
                [Validation(Required=false)]
                public long? DataFlowId { get; set; }

                /// <summary>
                /// The extended field. No meaning is specified for this field.
                /// </summary>
                [NameInMap("DemoId")]
                [Validation(Required=false)]
                public string DemoId { get; set; }

                /// <summary>
                /// The ID of the latest deployment record.
                /// </summary>
                [NameInMap("DeployId")]
                [Validation(Required=false)]
                public long? DeployId { get; set; }

                /// <summary>
                /// The ID of the task flow.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// Indicates whether the task flow is deleted. Valid values:
                /// 
                /// *   **true**: deleted
                /// *   **false**: not deleted
                /// </summary>
                [NameInMap("IsDeleted")]
                [Validation(Required=false)]
                public bool? IsDeleted { get; set; }

                /// <summary>
                /// The status of the latest execution. Valid values:
                /// 
                /// *   **0**: invalid
                /// *   **1**: scheduling disabled
                /// *   **2**: waiting to be scheduled
                /// </summary>
                [NameInMap("LatestInstanceStatus")]
                [Validation(Required=false)]
                public int? LatestInstanceStatus { get; set; }

                /// <summary>
                /// The time when the latest execution record was generated.
                /// </summary>
                [NameInMap("LatestInstanceTime")]
                [Validation(Required=false)]
                public int? LatestInstanceTime { get; set; }

                /// <summary>
                /// The ID of the business scenario.
                /// </summary>
                [NameInMap("ScenarioId")]
                [Validation(Required=false)]
                public long? ScenarioId { get; set; }

                /// <summary>
                /// The ID of the workspace.
                /// </summary>
                [NameInMap("SpaceId")]
                [Validation(Required=false)]
                public long? SpaceId { get; set; }

                /// <summary>
                /// The status of the task flow. Valid values:
                /// 
                /// *   **0**: invalid
                /// *   **1**: scheduling disabled
                /// *   **2**: waiting to be scheduled
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The task flows in other business scenarios.
        /// </summary>
        [NameInMap("ScenarioDAGList")]
        [Validation(Required=false)]
        public ListLhTaskFlowAndScenarioResponseBodyScenarioDAGList ScenarioDAGList { get; set; }
        public class ListLhTaskFlowAndScenarioResponseBodyScenarioDAGList : TeaModel {
            [NameInMap("ScenarioDAG")]
            [Validation(Required=false)]
            public List<ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListScenarioDAG> ScenarioDAG { get; set; }
            public class ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListScenarioDAG : TeaModel {
                /// <summary>
                /// The list of task flows.
                /// </summary>
                [NameInMap("DagList")]
                [Validation(Required=false)]
                public ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListScenarioDAGDagList DagList { get; set; }
                public class ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListScenarioDAGDagList : TeaModel {
                    [NameInMap("Dag")]
                    [Validation(Required=false)]
                    public List<ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListScenarioDAGDagListDag> Dag { get; set; }
                    public class ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListScenarioDAGDagListDag : TeaModel {
                        /// <summary>
                        /// Indicates whether the task flow can be modified. Valid values:
                        /// 
                        /// - **true**: The task flow can be modified.
                        /// - **false**: The task flow cannot be modified.
                        /// </summary>
                        [NameInMap("CanEdit")]
                        [Validation(Required=false)]
                        public bool? CanEdit { get; set; }

                        /// <summary>
                        /// The ID of the user who creates the task flow.
                        /// </summary>
                        [NameInMap("CreatorId")]
                        [Validation(Required=false)]
                        public string CreatorId { get; set; }

                        /// <summary>
                        /// The name of the user who creates the workspace.
                        /// </summary>
                        [NameInMap("CreatorNickName")]
                        [Validation(Required=false)]
                        public string CreatorNickName { get; set; }

                        /// <summary>
                        /// The name of the task flow.
                        /// </summary>
                        [NameInMap("DagName")]
                        [Validation(Required=false)]
                        public string DagName { get; set; }

                        /// <summary>
                        /// The user ID of the task flow owner.
                        /// </summary>
                        [NameInMap("DagOwnerId")]
                        [Validation(Required=false)]
                        public string DagOwnerId { get; set; }

                        /// <summary>
                        /// The name of the task flow owner.
                        /// </summary>
                        [NameInMap("DagOwnerNickName")]
                        [Validation(Required=false)]
                        public string DagOwnerNickName { get; set; }

                        /// <summary>
                        /// The extended field. No meaning is specified for this field.
                        /// </summary>
                        [NameInMap("DataFlowId")]
                        [Validation(Required=false)]
                        public long? DataFlowId { get; set; }

                        /// <summary>
                        /// The extended field. No meaning is specified for this field.
                        /// </summary>
                        [NameInMap("DemoId")]
                        [Validation(Required=false)]
                        public string DemoId { get; set; }

                        /// <summary>
                        /// The ID of the latest deployment record.
                        /// </summary>
                        [NameInMap("DeployId")]
                        [Validation(Required=false)]
                        public long? DeployId { get; set; }

                        /// <summary>
                        /// The ID of the task flow.
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// Indicates whether the task flow is deleted. Valid values:
                        /// 
                        /// - **true**: deleted
                        /// - **false**: not deleted
                        /// </summary>
                        [NameInMap("IsDeleted")]
                        [Validation(Required=false)]
                        public bool? IsDeleted { get; set; }

                        /// <summary>
                        /// The status of the latest execution. Valid values:
                        /// 
                        /// - 0: invalid
                        /// - 1: scheduling disabled
                        /// - 2: waiting to be scheduled
                        /// </summary>
                        [NameInMap("LatestInstanceStatus")]
                        [Validation(Required=false)]
                        public int? LatestInstanceStatus { get; set; }

                        /// <summary>
                        /// The time when the latest execution record was generated.
                        /// </summary>
                        [NameInMap("LatestInstanceTime")]
                        [Validation(Required=false)]
                        public int? LatestInstanceTime { get; set; }

                        /// <summary>
                        /// The ID of the business scenario.
                        /// </summary>
                        [NameInMap("ScenarioId")]
                        [Validation(Required=false)]
                        public long? ScenarioId { get; set; }

                        /// <summary>
                        /// The ID of the workspace.
                        /// </summary>
                        [NameInMap("SpaceId")]
                        [Validation(Required=false)]
                        public long? SpaceId { get; set; }

                        /// <summary>
                        /// The status of the task flow. Valid values:
                        /// 
                        /// - **0**: invalid
                        /// - **1**: scheduling disabled
                        /// - **2**: waiting to be scheduled
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public int? Status { get; set; }

                    }

                }

                /// <summary>
                /// The information about the business scenario.
                /// </summary>
                [NameInMap("Scenario")]
                [Validation(Required=false)]
                public ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListScenarioDAGScenario Scenario { get; set; }
                public class ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListScenarioDAGScenario : TeaModel {
                    /// <summary>
                    /// The ID of the user who creates the business scenario.
                    /// </summary>
                    [NameInMap("CreatorId")]
                    [Validation(Required=false)]
                    public string CreatorId { get; set; }

                    /// <summary>
                    /// The description of the business scenario.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the business scenario.
                    /// </summary>
                    [NameInMap("ScenarioName")]
                    [Validation(Required=false)]
                    public string ScenarioName { get; set; }

                }

            }

        }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// - **true**: The request is successful.
        /// - **false**: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
