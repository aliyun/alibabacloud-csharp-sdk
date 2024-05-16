// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the node. You can call the [ListNodes](https://help.aliyun.com/document_detail/173979.html) operation to query the ID of the node.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInstancesResponseBodyData Data { get; set; }
        public class ListInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the node. You can call the [ListNodes](https://help.aliyun.com/document_detail/173979.html) operation to query the name of the node.
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyDataInstances> Instances { get; set; }
            public class ListInstancesResponseBodyDataInstances : TeaModel {
                /// <summary>
                /// The type of the workflow. Valid values:
                /// 
                /// *   DAILY: The workflow is used to run auto triggered nodes.
                /// *   MANUAL: The workflow is used to run manually triggered nodes.
                /// *   SMOKE_TEST: The workflow is used to perform smoke testing.
                /// *   SUPPLY_DATA: The workflow is used to backfill data.
                /// </summary>
                [NameInMap("BaselineId")]
                [Validation(Required=false)]
                public long? BaselineId { get; set; }

                /// <summary>
                /// The time when the instance started to run.
                /// </summary>
                [NameInMap("BeginRunningTime")]
                [Validation(Required=false)]
                public long? BeginRunningTime { get; set; }

                /// <summary>
                /// The time when the node stopped running.
                /// </summary>
                [NameInMap("BeginWaitResTime")]
                [Validation(Required=false)]
                public long? BeginWaitResTime { get; set; }

                /// <summary>
                /// The ID of the request. You can use the ID to locate logs and troubleshoot issues.
                /// </summary>
                [NameInMap("BeginWaitTimeTime")]
                [Validation(Required=false)]
                public long? BeginWaitTimeTime { get; set; }

                /// <summary>
                /// The number of entries to return on each page. Default value: 10. Maximum value: 100.
                /// 
                /// You cannot specify the sorting method for the instances to be returned by this operation. By default, the instances are sorted in descending order of the time when the instances were created.
                /// </summary>
                [NameInMap("Bizdate")]
                [Validation(Required=false)]
                public long? Bizdate { get; set; }

                /// <summary>
                /// The ID of the workflow to which the node belongs.
                /// </summary>
                [NameInMap("BusinessId")]
                [Validation(Required=false)]
                public long? BusinessId { get; set; }

                /// <summary>
                /// The number of times the node can be rerun. The value of this parameter can be empty or an integer that is greater than or equal to 0.
                /// 
                /// *   If the value of this parameter is empty, the number of times that the node can be rerun is not specified.
                /// *   If the value of this parameter is 0, the node cannot be rerun.
                /// *   If the value of this parameter is a positive integer such as n, the node can be rerun n times. For example, if the value of this parameter is 1, the node can be rerun once. If the value of this parameter is 2, the node can be rerun twice.
                /// </summary>
                [NameInMap("Connection")]
                [Validation(Required=false)]
                public string Connection { get; set; }

                /// <summary>
                /// The interval at which the node is rerun after the node fails to run. Unit: milliseconds.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The ID of the node. You can call the [ListNodes](https://help.aliyun.com/document_detail/173979.html) operation to query the ID of the node.
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// The error message returned.
                /// </summary>
                [NameInMap("CycTime")]
                [Validation(Required=false)]
                public long? CycTime { get; set; }

                /// <summary>
                /// The time when the instance started to wait for resources.
                /// </summary>
                [NameInMap("DagId")]
                [Validation(Required=false)]
                public long? DagId { get; set; }

                /// <summary>
                /// The data timestamp of the instance. In most cases, the value is one day before the time when the instance was run.
                /// </summary>
                [NameInMap("DagType")]
                [Validation(Required=false)]
                public string DagType { get; set; }

                /// <summary>
                /// The operation that you want to perform.
                /// </summary>
                [NameInMap("DqcDescription")]
                [Validation(Required=false)]
                public string DqcDescription { get; set; }

                /// <summary>
                /// The status of the node. Valid values:
                /// 
                /// *   NOT_RUN: The node is not run.
                /// *   WAIT_TIME: The node is waiting for the scheduling time to arrive.
                /// *   WAIT_RESOURCE: The node is waiting for resources.
                /// *   RUNNING: The node is running.
                /// *   CHECKING: Data quality is being checked for the node.
                /// *   CHECKING_CONDITION: Branch conditions are being checked for the node.
                /// *   FAILURE: The node fails to run.
                /// *   SUCCESS: The node is successfully run.
                /// </summary>
                [NameInMap("DqcType")]
                [Validation(Required=false)]
                public int? DqcType { get; set; }

                /// <summary>
                /// The name of the account that is used to run the instance. For example, if an account named Test was used to run the instance to backfill data, the value of this parameter is Test.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account used by the workspace administrator. You can log on to the Alibaba Cloud Management Console and view the ID on the Security Settings page of the Account Center console.
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// The number of the page to return. Minimum value:1. Maximum value: 100.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// The name of the workflow. You can call the [ListBusiness](https://help.aliyun.com/document_detail/173945.html) operation to query the name of the workflow.
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// The environment of the workspace. Valid values: PROD and DEV. The value PROD indicates the production environment. The value DEV indicates the development environment.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// The ID of the workflow.
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// The table and partition filter expression in Data Quality that are associated with the node.
                /// </summary>
                [NameInMap("ParamValues")]
                [Validation(Required=false)]
                public string ParamValues { get; set; }

                /// <summary>
                /// The total number of instances.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// The type of the node. You can call the [ListNodes](https://help.aliyun.com/document_detail/173979.html) operation to query the type of the node.
                /// </summary>
                [NameInMap("RelatedFlowId")]
                [Validation(Required=false)]
                public long? RelatedFlowId { get; set; }

                /// <summary>
                /// The scheduling type of the node. Valid values:
                /// 
                /// *   NORMAL(0): The node is an auto triggered node. The scheduling system regularly runs the node.
                /// 
                /// *   MANUAL(1): The node is a manually triggered node. The scheduling system does not regularly run the node.
                /// 
                /// *   PAUSE(2): The node is a frozen node. The scheduling system regularly runs the node but sets the status of the node to failed when the scheduling system starts to run the node.
                /// 
                /// *   SKIP(3): The node is a dry-run node. The scheduling system regularly runs the node but sets the status of the node to succeeded when the scheduling system starts to run the node.
                /// 
                /// *   SKIP_UNCHOOSE(4): The node is an unselected node in a temporary workflow. This type of node exists only in temporary workflows. The scheduling system sets the status of the node to succeeded when the scheduling system starts to run the node.
                /// 
                /// *   SKIP_CYCLE(5): The node is a node that is scheduled by week or month and is waiting for the scheduling time to arrive. The scheduling system regularly runs the node but sets the status of the node to succeeded when the scheduling system starts to run the node.
                /// 
                /// *   CONDITION_UNCHOOSE(6): The node is not selected by its ancestor branch node and is run as a dry-run node.
                /// 
                ///     REALTIME_DEPRECATED(7): The node has instances that are generated in real time but deprecated. The scheduling system sets the status of the node to succeeded.
                /// </summary>
                [NameInMap("RepeatInterval")]
                [Validation(Required=false)]
                public long? RepeatInterval { get; set; }

                /// <summary>
                /// The status of the node. Valid values:
                /// 
                /// *   NOT_RUN: The node is not run.
                /// *   WAIT_TIME: The node is waiting for the scheduling time to arrive.
                /// *   WAIT_RESOURCE: The node is waiting for resources.
                /// *   RUNNING: The node is running.
                /// *   CHECKING: Data quality is being checked for the node.
                /// *   CHECKING_CONDITION: Branch conditions are being checked for the node.
                /// *   FAILURE: The node fails to run.
                /// *   SUCCESS: The node is successfully run.
                /// </summary>
                [NameInMap("Repeatability")]
                [Validation(Required=false)]
                public bool? Repeatability { get; set; }

                /// <summary>
                /// The data timestamp of the instances that you want to query. Specify the timestamp in the yyyy-MM-dd HH:mm:ss format.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The ID of the workspace. You can call the [ListProjects](https://help.aliyun.com/document_detail/178393.html) operation to query the ID of the workspace.
                /// </summary>
                [NameInMap("TaskRerunTime")]
                [Validation(Required=false)]
                public int? TaskRerunTime { get; set; }

                /// <summary>
                /// The information about the instances.
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

            }

            /// <summary>
            /// The time when the node was scheduled to run.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The end of the time range to query. Specify the time in the yyyy-MM-dd HH:mm:ss format.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The priority of the instance. Valid values: 1, 3, 5, 7, and 8.
            /// 
            /// A greater value indicates a higher priority. Default value: 1.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The error message that is returned for the instance.
        /// 
        /// This parameter is deprecated. You can call the [GetInstanceLog](https://help.aliyun.com/document_detail/173983.html) operation to query the error information related to the node.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The name of the node.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the yyyy-MM-dd HH:mm:ss format.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
