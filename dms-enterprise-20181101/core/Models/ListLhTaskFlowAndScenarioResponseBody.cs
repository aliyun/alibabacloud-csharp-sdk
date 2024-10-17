// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListLhTaskFlowAndScenarioResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The task flows in the default business scenario.</para>
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
                /// <para>Indicates whether the task flow can be modified. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The task flow can be modified.</description></item>
                /// <item><description><b>false</b>: The task flow cannot be modified.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CanEdit")]
                [Validation(Required=false)]
                public bool? CanEdit { get; set; }

                /// <summary>
                /// <para>The ID of the user who creates the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>51****</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The name of the user who creates the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Creator_Name</para>
                /// </summary>
                [NameInMap("CreatorNickName")]
                [Validation(Required=false)]
                public string CreatorNickName { get; set; }

                /// <summary>
                /// <para>The name of the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Dag_Name</para>
                /// </summary>
                [NameInMap("DagName")]
                [Validation(Required=false)]
                public string DagName { get; set; }

                /// <summary>
                /// <para>The user ID of the task flow owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>51****</para>
                /// </summary>
                [NameInMap("DagOwnerId")]
                [Validation(Required=false)]
                public string DagOwnerId { get; set; }

                /// <summary>
                /// <para>The name of the task flow owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Owner_Name</para>
                /// </summary>
                [NameInMap("DagOwnerNickName")]
                [Validation(Required=false)]
                public string DagOwnerNickName { get; set; }

                /// <summary>
                /// <para>The extended field. No meaning is specified for this field.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("DataFlowId")]
                [Validation(Required=false)]
                public long? DataFlowId { get; set; }

                /// <summary>
                /// <para>The extended field. No meaning is specified for this field.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("DemoId")]
                [Validation(Required=false)]
                public string DemoId { get; set; }

                /// <summary>
                /// <para>The ID of the latest deployment record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12**</para>
                /// </summary>
                [NameInMap("DeployId")]
                [Validation(Required=false)]
                public long? DeployId { get; set; }

                /// <summary>
                /// <para>The ID of the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>134137****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Indicates whether the task flow is deleted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: deleted</description></item>
                /// <item><description><b>false</b>: not deleted</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsDeleted")]
                [Validation(Required=false)]
                public bool? IsDeleted { get; set; }

                /// <summary>
                /// <para>The status of the latest execution. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: invalid</description></item>
                /// <item><description><b>1</b>: scheduling disabled</description></item>
                /// <item><description><b>2</b>: waiting to be scheduled</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LatestInstanceStatus")]
                [Validation(Required=false)]
                public int? LatestInstanceStatus { get; set; }

                /// <summary>
                /// <para>The time when the latest execution record was generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-14</para>
                /// </summary>
                [NameInMap("LatestInstanceTime")]
                [Validation(Required=false)]
                public int? LatestInstanceTime { get; set; }

                /// <summary>
                /// <para>The ID of the business scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2**</para>
                /// </summary>
                [NameInMap("ScenarioId")]
                [Validation(Required=false)]
                public long? ScenarioId { get; set; }

                /// <summary>
                /// <para>The ID of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SpaceId")]
                [Validation(Required=false)]
                public long? SpaceId { get; set; }

                /// <summary>
                /// <para>The status of the task flow. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: invalid</description></item>
                /// <item><description><b>1</b>: scheduling disabled</description></item>
                /// <item><description><b>2</b>: waiting to be scheduled</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48602B78-0DDF-414C-8688-70CAB6070115</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task flows in other business scenarios.</para>
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
                /// <para>The list of task flows.</para>
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
                        /// <para>Indicates whether the task flow can be modified. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>true</b>: The task flow can be modified.</description></item>
                        /// <item><description><b>false</b>: The task flow cannot be modified.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("CanEdit")]
                        [Validation(Required=false)]
                        public bool? CanEdit { get; set; }

                        /// <summary>
                        /// <para>The ID of the user who creates the task flow.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>51****</para>
                        /// </summary>
                        [NameInMap("CreatorId")]
                        [Validation(Required=false)]
                        public string CreatorId { get; set; }

                        /// <summary>
                        /// <para>The name of the user who creates the workspace.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Creator_Name</para>
                        /// </summary>
                        [NameInMap("CreatorNickName")]
                        [Validation(Required=false)]
                        public string CreatorNickName { get; set; }

                        /// <summary>
                        /// <para>The name of the task flow.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Dag_Name</para>
                        /// </summary>
                        [NameInMap("DagName")]
                        [Validation(Required=false)]
                        public string DagName { get; set; }

                        /// <summary>
                        /// <para>The user ID of the task flow owner.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>51****</para>
                        /// </summary>
                        [NameInMap("DagOwnerId")]
                        [Validation(Required=false)]
                        public string DagOwnerId { get; set; }

                        /// <summary>
                        /// <para>The name of the task flow owner.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Owner_Name</para>
                        /// </summary>
                        [NameInMap("DagOwnerNickName")]
                        [Validation(Required=false)]
                        public string DagOwnerNickName { get; set; }

                        /// <summary>
                        /// <para>The extended field. No meaning is specified for this field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <list type="bullet">
                        /// <item><description></description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("DataFlowId")]
                        [Validation(Required=false)]
                        public long? DataFlowId { get; set; }

                        /// <summary>
                        /// <para>The extended field. No meaning is specified for this field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <list type="bullet">
                        /// <item><description></description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("DemoId")]
                        [Validation(Required=false)]
                        public string DemoId { get; set; }

                        /// <summary>
                        /// <para>The ID of the latest deployment record.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12**</para>
                        /// </summary>
                        [NameInMap("DeployId")]
                        [Validation(Required=false)]
                        public long? DeployId { get; set; }

                        /// <summary>
                        /// <para>The ID of the task flow.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9***</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the task flow is deleted. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>true</b>: deleted</description></item>
                        /// <item><description><b>false</b>: not deleted</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("IsDeleted")]
                        [Validation(Required=false)]
                        public bool? IsDeleted { get; set; }

                        /// <summary>
                        /// <para>The status of the latest execution. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>0: invalid</description></item>
                        /// <item><description>1: scheduling disabled</description></item>
                        /// <item><description>2: waiting to be scheduled</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("LatestInstanceStatus")]
                        [Validation(Required=false)]
                        public int? LatestInstanceStatus { get; set; }

                        /// <summary>
                        /// <para>The time when the latest execution record was generated.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2022-04-14</para>
                        /// </summary>
                        [NameInMap("LatestInstanceTime")]
                        [Validation(Required=false)]
                        public int? LatestInstanceTime { get; set; }

                        /// <summary>
                        /// <para>The ID of the business scenario.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2**</para>
                        /// </summary>
                        [NameInMap("ScenarioId")]
                        [Validation(Required=false)]
                        public long? ScenarioId { get; set; }

                        /// <summary>
                        /// <para>The ID of the workspace.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("SpaceId")]
                        [Validation(Required=false)]
                        public long? SpaceId { get; set; }

                        /// <summary>
                        /// <para>The status of the task flow. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>0</b>: invalid</description></item>
                        /// <item><description><b>1</b>: scheduling disabled</description></item>
                        /// <item><description><b>2</b>: waiting to be scheduled</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public int? Status { get; set; }

                    }

                }

                /// <summary>
                /// <para>The information about the business scenario.</para>
                /// </summary>
                [NameInMap("Scenario")]
                [Validation(Required=false)]
                public ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListScenarioDAGScenario Scenario { get; set; }
                public class ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListScenarioDAGScenario : TeaModel {
                    /// <summary>
                    /// <para>The ID of the user who creates the business scenario.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>51****</para>
                    /// </summary>
                    [NameInMap("CreatorId")]
                    [Validation(Required=false)]
                    public string CreatorId { get; set; }

                    /// <summary>
                    /// <para>The description of the business scenario.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the business scenario.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Scenario_2</para>
                    /// </summary>
                    [NameInMap("ScenarioName")]
                    [Validation(Required=false)]
                    public string ScenarioName { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
