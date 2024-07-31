// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetIDEEventDetailResponseBody : TeaModel {
        /// <summary>
        /// The data snapshot that is generated when an extension point event is triggered.
        /// 
        /// The fields contained in data snapshots vary based on the types of the triggered extension point events. For more information, see the description of the fields.
        /// </summary>
        [NameInMap("EventDetail")]
        [Validation(Required=false)]
        public GetIDEEventDetailResponseBodyEventDetail EventDetail { get; set; }
        public class GetIDEEventDetailResponseBodyEventDetail : TeaModel {
            /// <summary>
            /// The data snapshot when the file is committed and deployed.
            /// 
            /// This parameter is valid only if the message type is IDE_FILE_SUBMIT_BEFORE or IDE_FILE_DEPLOY_BEFORE.
            /// </summary>
            [NameInMap("CommittedFile")]
            [Validation(Required=false)]
            public GetIDEEventDetailResponseBodyEventDetailCommittedFile CommittedFile { get; set; }
            public class GetIDEEventDetailResponseBodyEventDetailCommittedFile : TeaModel {
                /// <summary>
                /// The type of the change to the file of the current version. Valid values: CREATE, UPDATE, and DELETE.
                /// </summary>
                [NameInMap("ChangeType")]
                [Validation(Required=false)]
                public string ChangeType { get; set; }

                /// <summary>
                /// The description of the file version.
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account that is used to generate the file of the current version.
                /// </summary>
                [NameInMap("Committor")]
                [Validation(Required=false)]
                public string Committor { get; set; }

                /// <summary>
                /// The code in the file of the current version.
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The file ID.
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// The name of the file.
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// The details of the file.
                /// </summary>
                [NameInMap("FilePropertyContent")]
                [Validation(Required=false)]
                public GetIDEEventDetailResponseBodyEventDetailCommittedFileFilePropertyContent FilePropertyContent { get; set; }
                public class GetIDEEventDetailResponseBodyEventDetailCommittedFileFilePropertyContent : TeaModel {
                    /// <summary>
                    /// The ID of the workflow to which the file belongs.
                    /// </summary>
                    [NameInMap("BusinessId")]
                    [Validation(Required=false)]
                    public long? BusinessId { get; set; }

                    /// <summary>
                    /// The latest version number of the file.
                    /// </summary>
                    [NameInMap("CurrentVersion")]
                    [Validation(Required=false)]
                    public long? CurrentVersion { get; set; }

                    /// <summary>
                    /// The name of the data source with which the file is associated.
                    /// </summary>
                    [NameInMap("DataSourceName")]
                    [Validation(Required=false)]
                    public string DataSourceName { get; set; }

                    /// <summary>
                    /// The ID of the folder to which the file belongs. You can call the [GetFolder](https://help.aliyun.com/document_detail/173952.html) operation to query the details of the file based on the folder ID.
                    /// </summary>
                    [NameInMap("FolderId")]
                    [Validation(Required=false)]
                    public string FolderId { get; set; }

                    /// <summary>
                    /// The file owner.
                    /// </summary>
                    [NameInMap("Owner")]
                    [Validation(Required=false)]
                    public string Owner { get; set; }

                    /// <summary>
                    /// The ID of the do-while node or for-each node that corresponds to the file.
                    /// </summary>
                    [NameInMap("ParentFileId")]
                    [Validation(Required=false)]
                    public long? ParentFileId { get; set; }

                }

                /// <summary>
                /// The type of the code for the file. Valid values: 6 (Shell), 10 (ODPS SQL), 11 (ODPS MR), 23 (Data Integration), 24 (ODPS Script), 99 (zero load), 221 (PyODPS 2), 225 (ODPS Spark), 227 (EMR Hive), 228 (EMR Spark), 229 (EMR Spark SQL), 230 (EMR MR), 239 (OSS object inspection), 257 (EMR Shell), 258 (EMR Spark Shell), 259 (EMR Presto), 260 (EMR Impala), 900 (real-time synchronization), 1089 (cross-tenant collaboration), 1091 (Hologres development), 1093 (Hologres SQL), 1100 (assignment), and 1221 (PyODPS 3).
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public long? FileType { get; set; }

                /// <summary>
                /// The scheduling properties of the node that corresponds to the file.
                /// </summary>
                [NameInMap("NodeConfiguration")]
                [Validation(Required=false)]
                public GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfiguration NodeConfiguration { get; set; }
                public class GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfiguration : TeaModel {
                    /// <summary>
                    /// The interval at which the node corresponding to the file is rerun. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("AutoRerunIntervalMillis")]
                    [Validation(Required=false)]
                    public long? AutoRerunIntervalMillis { get; set; }

                    /// <summary>
                    /// The number of times that the node corresponding to the file can be rerun.
                    /// </summary>
                    [NameInMap("AutoRerunTimes")]
                    [Validation(Required=false)]
                    public long? AutoRerunTimes { get; set; }

                    /// <summary>
                    /// The CRON expression that is used to schedule the node corresponding to the file.
                    /// </summary>
                    [NameInMap("CronExpress")]
                    [Validation(Required=false)]
                    public string CronExpress { get; set; }

                    /// <summary>
                    /// The type of the scheduling cycle of the node that corresponds to the file. Valid values: NOT_DAY and DAY. The value NOT_DAY indicates that the node is scheduled to run by minute or hour. The value DAY indicates that the node is scheduled to run by day, week, or month.
                    /// 
                    /// This parameter corresponds to the Scheduling Cycle parameter in the Schedule section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                    /// </summary>
                    [NameInMap("CycleType")]
                    [Validation(Required=false)]
                    public string CycleType { get; set; }

                    /// <summary>
                    /// The ID of the node on which the node that corresponds to the file depends when the DependentType parameter is set to USER_DEFINE. Multiple IDs are separated by commas (,).
                    /// 
                    /// The value of this parameter is equivalent to the ID of the node that you specified after you select Other Nodes for Cross-Cycle Dependency (Original Previous-Cycle Dependency) in the Dependencies section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                    /// </summary>
                    [NameInMap("DependentNodeIdList")]
                    [Validation(Required=false)]
                    public string DependentNodeIdList { get; set; }

                    /// <summary>
                    /// The type of the cross-cycle scheduling dependency of the node. Valid values:
                    /// 
                    /// *   SELF: The instance generated for the node in the current cycle depends on the instance generated for the node in the previous cycle.
                    /// *   CHILD: The instance generated for the node in the current cycle depends on the instances generated for the descendant nodes at the nearest level of the node in the previous cycle.
                    /// *   USER_DEFINE: The instance generated for the node in the current cycle depends on the instances generated for one or more specified nodes in the previous cycle.
                    /// *   NONE: No cross-cycle scheduling dependency type is selected for the node.
                    /// </summary>
                    [NameInMap("DependentType")]
                    [Validation(Required=false)]
                    public string DependentType { get; set; }

                    /// <summary>
                    /// The output names of the parent files on which the current file depends.
                    /// </summary>
                    [NameInMap("InputList")]
                    [Validation(Required=false)]
                    public List<GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfigurationInputList> InputList { get; set; }
                    public class GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfigurationInputList : TeaModel {
                        /// <summary>
                        /// The output name of the parent file on which the current file depends.
                        /// 
                        /// This parameter corresponds to the Output Name of Ancestor Node parameter under Parent Nodes in the Dependencies section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                        /// </summary>
                        [NameInMap("Input")]
                        [Validation(Required=false)]
                        public string Input { get; set; }

                        /// <summary>
                        /// The mode of the configuration file dependency. Valid values:
                        /// 
                        /// *   MANUAL: Scheduling dependencies are manually configured.
                        /// *   AUTO: Scheduling dependencies are automatically parsed.
                        /// </summary>
                        [NameInMap("ParseType")]
                        [Validation(Required=false)]
                        public string ParseType { get; set; }

                    }

                    /// <summary>
                    /// The output names of the current file.
                    /// 
                    /// This parameter corresponds to the Output Name of Current Node parameter in the Dependencies section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                    /// </summary>
                    [NameInMap("OutputList")]
                    [Validation(Required=false)]
                    public List<GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfigurationOutputList> OutputList { get; set; }
                    public class GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfigurationOutputList : TeaModel {
                        /// <summary>
                        /// The output name of the current file.
                        /// 
                        /// This parameter corresponds to the Output Name parameter under Output Name of Current Node in the Dependencies section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                        /// </summary>
                        [NameInMap("Output")]
                        [Validation(Required=false)]
                        public string Output { get; set; }

                        /// <summary>
                        /// The output table name of the current file.
                        /// 
                        /// This parameter corresponds to the Output Table Name parameter under Output Name of Current Node in the Dependencies section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                        /// </summary>
                        [NameInMap("RefTableName")]
                        [Validation(Required=false)]
                        public string RefTableName { get; set; }

                    }

                    /// <summary>
                    /// The scheduling parameters of the node.
                    /// 
                    /// This parameter corresponds to the Scheduling Parameter section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console). For more information about the configurations of the scheduling parameters, see [Configure scheduling parameters](https://help.aliyun.com/document_detail/137548.html).
                    /// </summary>
                    [NameInMap("ParaValue")]
                    [Validation(Required=false)]
                    public string ParaValue { get; set; }

                    /// <summary>
                    /// Indicates whether the node that corresponds to the file can be rerun. Valid values:
                    /// 
                    /// *   ALL_ALLOWED: The node can be rerun regardless of whether it is successfully run or fails to run.
                    /// *   FAILURE_ALLOWED: The node can be rerun only after it fails to run.
                    /// *   ALL_DENIED: The node cannot be rerun regardless of whether it is successfully run or fails to run.
                    /// 
                    /// This parameter corresponds to the Rerun parameter in the Schedule section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                    /// </summary>
                    [NameInMap("RerunMode")]
                    [Validation(Required=false)]
                    public string RerunMode { get; set; }

                    /// <summary>
                    /// The ID of the resource group that is used to run the node that corresponds to the file. You can call the [ListResourceGroups](https://help.aliyun.com/document_detail/173913.html) operation to query the available resource groups in the workspace.
                    /// </summary>
                    [NameInMap("ResourceGroupId")]
                    [Validation(Required=false)]
                    public long? ResourceGroupId { get; set; }

                    /// <summary>
                    /// The scheduling type of the node. Valid values:
                    /// 
                    /// *   NORMAL: The node is an auto triggered node.
                    /// *   MANUAL: The node is a manually triggered node. Manually triggered nodes cannot be automatically triggered. They correspond to the nodes in the Manually Triggered Workflows pane.
                    /// *   PAUSE: The node is a paused node.
                    /// *   SKIP: The node is a dry-run node. Dry-run nodes are started as scheduled, but the system sets the status of the nodes to successful when it starts to run them.
                    /// </summary>
                    [NameInMap("SchedulerType")]
                    [Validation(Required=false)]
                    public string SchedulerType { get; set; }

                }

                /// <summary>
                /// The ID of the node that is scheduled.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// The module to which the file belongs. Valid values:
                /// 
                /// *   NORMAL: The file is used for DataStudio.
                /// *   MANUAL: The file is used for a manually triggered node.
                /// *   MANUAL_BIZ: The file is used for a manually triggered workflow.
                /// *   SKIP: The file is used for a dry-run DataStudio node.
                /// *   ADHOCQUERY: The file is used for an ad hoc query.
                /// *   COMPONENT: The file is used for a snippet.
                /// </summary>
                [NameInMap("UseType")]
                [Validation(Required=false)]
                public string UseType { get; set; }

            }

            /// <summary>
            /// The data snapshot when the file is deleted. This parameter is valid only if the message type is IDE_FILE_DELETE_BEFORE.
            /// </summary>
            [NameInMap("DeletedFile")]
            [Validation(Required=false)]
            public GetIDEEventDetailResponseBodyEventDetailDeletedFile DeletedFile { get; set; }
            public class GetIDEEventDetailResponseBodyEventDetailDeletedFile : TeaModel {
                /// <summary>
                /// The ID of the workflow to which the file belongs.
                /// </summary>
                [NameInMap("BusinessId")]
                [Validation(Required=false)]
                public long? BusinessId { get; set; }

                /// <summary>
                /// The code in the file of the current version.
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The latest version number of the file.
                /// </summary>
                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public long? CurrentVersion { get; set; }

                /// <summary>
                /// The name of the data source with which the file is associated.
                /// </summary>
                [NameInMap("DataSourceName")]
                [Validation(Required=false)]
                public string DataSourceName { get; set; }

                /// <summary>
                /// The file ID.
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// The name of the file.
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// The type of the code for the file. Valid values: 6 (Shell), 10 (ODPS SQL), 11 (ODPS MR), 23 (Data Integration), 24 (ODPS Script), 99 (zero load), 221 (PyODPS 2), 225 (ODPS Spark), 227 (EMR Hive), 228 (EMR Spark), 229 (EMR Spark SQL), 230 (EMR MR), 239 (OSS object inspection), 257 (EMR Shell), 258 (EMR Spark Shell), 259 (EMR Presto), 260 (EMR Impala), 900 (real-time synchronization), 1089 (cross-tenant collaboration), 1091 (Hologres development), 1093 (Hologres SQL), 1100 (assignment), and 1221 (PyODPS 3).
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public long? FileType { get; set; }

                /// <summary>
                /// The ID of the folder to which the file belongs. You can call the [GetFolder](https://help.aliyun.com/document_detail/173952.html) operation to query the details of the file based on the folder ID.
                /// </summary>
                [NameInMap("FolderId")]
                [Validation(Required=false)]
                public string FolderId { get; set; }

                /// <summary>
                /// The ID of the node that is scheduled.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// The file owner.
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The ID of the do-while node or for-each node that corresponds to the file.
                /// </summary>
                [NameInMap("ParentFileId")]
                [Validation(Required=false)]
                public long? ParentFileId { get; set; }

                /// <summary>
                /// The module to which the file belongs. Valid values:
                /// 
                /// *   NORMAL: The file is used for DataStudio.
                /// *   MANUAL: The file is used for a manually triggered node.
                /// *   MANUAL_BIZ: The file is used for a manually triggered workflow.
                /// *   SKIP: The file is used for a dry-run DataStudio node.
                /// *   ADHOCQUERY: The file is used for an ad hoc query.
                /// *   COMPONENT: The file is used for a snippet.
                /// </summary>
                [NameInMap("UseType")]
                [Validation(Required=false)]
                public string UseType { get; set; }

            }

            /// <summary>
            /// The data snapshot when the code in the file is run. This parameter is valid only if the message type is IDE_FILE_EXECUTE_BEFORE.
            /// </summary>
            [NameInMap("FileExecutionCommand")]
            [Validation(Required=false)]
            public GetIDEEventDetailResponseBodyEventDetailFileExecutionCommand FileExecutionCommand { get; set; }
            public class GetIDEEventDetailResponseBodyEventDetailFileExecutionCommand : TeaModel {
                /// <summary>
                /// The code in the file of the current version.
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The name of the data source with which the file is associated.
                /// </summary>
                [NameInMap("DataSourceName")]
                [Validation(Required=false)]
                public string DataSourceName { get; set; }

                /// <summary>
                /// The file ID.
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// The type of the code for the file. Valid values: 6 (Shell), 10 (ODPS SQL), 11 (ODPS MR), 23 (Data Integration), 24 (ODPS Script), 99 (zero load), 221 (PyODPS 2), 225 (ODPS Spark), 227 (EMR Hive), 228 (EMR Spark), 229 (EMR Spark SQL), 230 (EMR MR), 239 (OSS object inspection), 257 (EMR Shell), 258 (EMR Spark Shell), 259 (EMR Presto), 260 (EMR Impala), 900 (real-time synchronization), 1089 (cross-tenant collaboration), 1091 (Hologres development), 1093 (Hologres SQL), 1100 (assignment), and 1221 (PyODPS 3).
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public long? FileType { get; set; }

            }

            /// <summary>
            /// The data snapshot when the table is committed and deployed. This parameter is valid only if the message type is IDE_TABLE_SUBMIT_BEFORE or IDE_TABLE_DEPLOY_BEFORE.
            /// </summary>
            [NameInMap("TableModel")]
            [Validation(Required=false)]
            public GetIDEEventDetailResponseBodyEventDetailTableModel TableModel { get; set; }
            public class GetIDEEventDetailResponseBodyEventDetailTableModel : TeaModel {
                /// <summary>
                /// The columns in the table.
                /// </summary>
                [NameInMap("Columns")]
                [Validation(Required=false)]
                public List<GetIDEEventDetailResponseBodyEventDetailTableModelColumns> Columns { get; set; }
                public class GetIDEEventDetailResponseBodyEventDetailTableModelColumns : TeaModel {
                    /// <summary>
                    /// The name of the column.
                    /// </summary>
                    [NameInMap("ColumnName")]
                    [Validation(Required=false)]
                    public string ColumnName { get; set; }

                    /// <summary>
                    /// The data type of the column.
                    /// </summary>
                    [NameInMap("ColumnType")]
                    [Validation(Required=false)]
                    public string ColumnType { get; set; }

                    /// <summary>
                    /// The remarks of the column.
                    /// </summary>
                    [NameInMap("Comment")]
                    [Validation(Required=false)]
                    public string Comment { get; set; }

                    /// <summary>
                    /// Indicates whether the column is a partition key column. Valid values:
                    /// 
                    /// *   true
                    /// *   false
                    /// </summary>
                    [NameInMap("IsPartitionColumn")]
                    [Validation(Required=false)]
                    public bool? IsPartitionColumn { get; set; }

                }

                /// <summary>
                /// The remarks of the table.
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// The name of the data source to which the table belongs.
                /// </summary>
                [NameInMap("DataSourceName")]
                [Validation(Required=false)]
                public string DataSourceName { get; set; }

                /// <summary>
                /// The environment in which the table is used. Valid values:
                /// 
                /// *   DEV
                /// *   PROD
                /// </summary>
                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                /// <summary>
                /// The lifecycle of the metatable. Unit: day.
                /// </summary>
                [NameInMap("LifeCycle")]
                [Validation(Required=false)]
                public long? LifeCycle { get; set; }

                /// <summary>
                /// The path of the table.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The name of the table.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
