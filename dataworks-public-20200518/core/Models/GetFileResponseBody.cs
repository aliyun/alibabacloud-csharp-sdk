// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetFileResponseBody : TeaModel {
        /// <summary>
        /// The details of the file.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileResponseBodyData Data { get; set; }
        public class GetFileResponseBodyData : TeaModel {
            /// <summary>
            /// The basic information about the file.
            /// </summary>
            [NameInMap("File")]
            [Validation(Required=false)]
            public GetFileResponseBodyDataFile File { get; set; }
            public class GetFileResponseBodyDataFile : TeaModel {
                /// <summary>
                /// The advanced configurations of the node.
                /// 
                /// This parameter is valid for an EMR node. This parameter corresponds to the Advanced Settings tab in the right-side navigation pane on the configuration tab of the node in the [DataWorks console](https://workbench.data.aliyun.com/console).
                /// 
                /// >  You cannot configure advanced parameters for EMR Shell nodes.
                /// 
                /// For information about the advanced parameters of each type of EMR node, see [Develop EMR tasks](https://help.aliyun.com/document_detail/473077.html).
                /// </summary>
                [NameInMap("AdvancedSettings")]
                [Validation(Required=false)]
                public string AdvancedSettings { get; set; }

                /// <summary>
                /// Indicates whether the automatic parsing feature is enabled for the file. Valid values:
                /// 
                /// *   true: The automatic parsing feature is enabled for the file.
                /// *   false: The automatic parsing feature is not enabled for the file.
                /// 
                /// This parameter corresponds to the Analyze Code parameter that is displayed after Same Cycle is selected in the Dependencies section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                /// </summary>
                [NameInMap("AutoParsing")]
                [Validation(Required=false)]
                public bool? AutoParsing { get; set; }

                /// <summary>
                /// The ID of the workflow to which the file belongs. This parameter is deprecated and replaced by the BusinessId parameter.
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public long? BizId { get; set; }

                /// <summary>
                /// The ID of the workflow to which the file belongs.
                /// </summary>
                [NameInMap("BusinessId")]
                [Validation(Required=false)]
                public long? BusinessId { get; set; }

                /// <summary>
                /// Indicates whether the latest code in the file is committed. Valid values: 0 and 1. The value 0 indicates that the latest code in the file is not committed. The value 1 indicates that the latest code in the file is committed.
                /// </summary>
                [NameInMap("CommitStatus")]
                [Validation(Required=false)]
                public int? CommitStatus { get; set; }

                /// <summary>
                /// The ID of the compute engine instance that is used to run the node that corresponds to the file.
                /// </summary>
                [NameInMap("ConnectionName")]
                [Validation(Required=false)]
                public string ConnectionName { get; set; }

                /// <summary>
                /// The code in the file.
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The time when the file was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account used to create the file.
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// The latest version number of the file.
                /// </summary>
                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public int? CurrentVersion { get; set; }

                /// <summary>
                /// The status of the file. Valid values:
                /// 
                /// *   NORMAL: The file is not deleted.
                /// *   RECYCLE_BIN: The file is stored in the recycle bin.
                /// *   DELETED: The file is deleted.
                /// </summary>
                [NameInMap("DeletedStatus")]
                [Validation(Required=false)]
                public string DeletedStatus { get; set; }

                /// <summary>
                /// The description of the file.
                /// </summary>
                [NameInMap("FileDescription")]
                [Validation(Required=false)]
                public string FileDescription { get; set; }

                /// <summary>
                /// The ID of the folder to which the file belongs.
                /// </summary>
                [NameInMap("FileFolderId")]
                [Validation(Required=false)]
                public string FileFolderId { get; set; }

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
                public int? FileType { get; set; }

                /// <summary>
                /// Indicates whether the file needs to be uploaded to MaxCompute.
                /// 
                /// This parameter is returned only if the file is a MaxCompute resource file.
                /// </summary>
                [NameInMap("IsMaxCompute")]
                [Validation(Required=false)]
                public bool? IsMaxCompute { get; set; }

                /// <summary>
                /// The time when the file was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("LastEditTime")]
                [Validation(Required=false)]
                public long? LastEditTime { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account used to last modify the file.
                /// </summary>
                [NameInMap("LastEditUser")]
                [Validation(Required=false)]
                public string LastEditUser { get; set; }

                /// <summary>
                /// The ID of the auto triggered node that is generated in the scheduling system after the file is committed.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account used by the file owner.
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The ID of the node group file to which the current file belongs. This parameter is returned only if the current file is an inner file of the node group file.
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

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
            /// The scheduling configurations of the file.
            /// </summary>
            [NameInMap("NodeConfiguration")]
            [Validation(Required=false)]
            public GetFileResponseBodyDataNodeConfiguration NodeConfiguration { get; set; }
            public class GetFileResponseBodyDataNodeConfiguration : TeaModel {
                [NameInMap("ApplyScheduleImmediately")]
                [Validation(Required=false)]
                public string ApplyScheduleImmediately { get; set; }

                /// <summary>
                /// The interval between automatic reruns after an error occurs. Unit: milliseconds.
                /// 
                /// This parameter corresponds to the Rerun Interval parameter that is displayed after the Auto Rerun upon Error check box is selected in the Schedule section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                /// 
                /// The interval that you specify in the DataWorks console is measured in minutes. Pay attention to the conversion between the units of time when you call the operation.
                /// </summary>
                [NameInMap("AutoRerunIntervalMillis")]
                [Validation(Required=false)]
                public int? AutoRerunIntervalMillis { get; set; }

                /// <summary>
                /// The number of automatic reruns that are allowed after an error occurs.
                /// </summary>
                [NameInMap("AutoRerunTimes")]
                [Validation(Required=false)]
                public int? AutoRerunTimes { get; set; }

                /// <summary>
                /// The CRON expression that represents the periodic scheduling policy of the node.
                /// </summary>
                [NameInMap("CronExpress")]
                [Validation(Required=false)]
                public string CronExpress { get; set; }

                /// <summary>
                /// The type of the scheduling cycle. Valid values: NOT_DAY and DAY. The value NOT_DAY indicates that the node is scheduled to run by minute or hour. The value DAY indicates that the node is scheduled to run by day, week, or month.
                /// 
                /// This parameter corresponds to the Scheduling Cycle parameter in the Schedule section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                /// </summary>
                [NameInMap("CycleType")]
                [Validation(Required=false)]
                public string CycleType { get; set; }

                /// <summary>
                /// The ID of the node on which the node corresponding to the file depends when the DependentType parameter is set to USER_DEFINE. Multiple IDs are separated by commas (,).
                /// 
                /// The value of this parameter is equivalent to the ID of the node that you specified after you select Previous Cycle and set Depend On to Other Nodes in the Dependencies section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
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
                /// The end time of automatic scheduling. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// 
                /// This parameter corresponds to the Validity Period parameter in the Schedule section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                /// </summary>
                [NameInMap("EndEffectDate")]
                [Validation(Required=false)]
                public long? EndEffectDate { get; set; }

                /// <summary>
                /// The output names of the parent files on which the current file depends.
                /// </summary>
                [NameInMap("InputList")]
                [Validation(Required=false)]
                public List<GetFileResponseBodyDataNodeConfigurationInputList> InputList { get; set; }
                public class GetFileResponseBodyDataNodeConfigurationInputList : TeaModel {
                    /// <summary>
                    /// The output name of the parent file on which the current file depends.
                    /// 
                    /// This parameter corresponds to the Output Name of Ancestor Node parameter under Parent Nodes after Same Cycle is selected in the Dependencies section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
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
                /// Input parameters of the node.
                /// 
                /// This parameter corresponds to the Input Parameters table in the Input and Output Parameters section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                /// </summary>
                [NameInMap("InputParameters")]
                [Validation(Required=false)]
                public List<GetFileResponseBodyDataNodeConfigurationInputParameters> InputParameters { get; set; }
                public class GetFileResponseBodyDataNodeConfigurationInputParameters : TeaModel {
                    /// <summary>
                    /// The name of the input parameter of the node. In the code, you can use the ${...} method to reference the input parameter of the node.
                    /// 
                    /// This parameter corresponds to the Parameter Name parameter in the Input Parameters table in the Input and Output Parameters section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                    /// </summary>
                    [NameInMap("ParameterName")]
                    [Validation(Required=false)]
                    public string ParameterName { get; set; }

                    /// <summary>
                    /// The value source of the input parameter of the node.
                    /// 
                    /// This parameter corresponds to the Value Source parameter in the Input Parameters table in the Input and Output Parameters section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                    /// </summary>
                    [NameInMap("ValueSource")]
                    [Validation(Required=false)]
                    public string ValueSource { get; set; }

                }

                /// <summary>
                /// The output names of the current file.
                /// 
                /// This parameter corresponds to the Output Name parameter under Output after Same Cycle is selected in the Dependencies section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                /// </summary>
                [NameInMap("OutputList")]
                [Validation(Required=false)]
                public List<GetFileResponseBodyDataNodeConfigurationOutputList> OutputList { get; set; }
                public class GetFileResponseBodyDataNodeConfigurationOutputList : TeaModel {
                    /// <summary>
                    /// The output name of the current file.
                    /// 
                    /// This parameter corresponds to the Output Name parameter under Output after Same Cycle is selected in the Dependencies section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                    /// </summary>
                    [NameInMap("Output")]
                    [Validation(Required=false)]
                    public string Output { get; set; }

                    /// <summary>
                    /// The output table name of the current file.
                    /// 
                    /// This parameter corresponds to the Output Table Name parameter under Output after Same Cycle is selected in the Dependencies section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                    /// </summary>
                    [NameInMap("RefTableName")]
                    [Validation(Required=false)]
                    public string RefTableName { get; set; }

                }

                /// <summary>
                /// Output parameters of the node.
                /// 
                /// This parameter corresponds to the Output Parameters table in the Input and Output Parameters section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                /// </summary>
                [NameInMap("OutputParameters")]
                [Validation(Required=false)]
                public List<GetFileResponseBodyDataNodeConfigurationOutputParameters> OutputParameters { get; set; }
                public class GetFileResponseBodyDataNodeConfigurationOutputParameters : TeaModel {
                    /// <summary>
                    /// The description of the output parameter of the node.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the output parameter of the node.
                    /// 
                    /// This parameter corresponds to the Parameter Name parameter in the Output Parameters table in the Input and Output Parameters section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                    /// </summary>
                    [NameInMap("ParameterName")]
                    [Validation(Required=false)]
                    public string ParameterName { get; set; }

                    /// <summary>
                    /// The type of the output parameter of the node. Valid values:
                    /// 
                    /// *   1: indicates a constant.
                    /// *   2: indicates a variable.
                    /// *   3: indicates a pass-through variable.
                    /// 
                    /// This parameter corresponds to the Type parameter in the Output Parameters table in the Input and Output Parameters section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// The value of the output parameter of the node.
                    /// 
                    /// This parameter corresponds to the Value parameter in the Output Parameters table in the Input and Output Parameters section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The scheduling parameters of the node.
                /// 
                /// This parameter corresponds to the Parameters section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console). For more information about the configurations of the scheduling parameters, see [Configure scheduling parameters](https://help.aliyun.com/document_detail/137548.html).
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
                /// The ID of the resource group that is used to run the node. You can call the [ListResourceGroups](https://help.aliyun.com/document_detail/173913.html) operation to query the available resource groups in the workspace.
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
                /// *   SKIP: The node is a dry-run node. Dry-run nodes are started as scheduled but the system sets the status of the nodes to successful when it starts to run them.
                /// </summary>
                [NameInMap("SchedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

                /// <summary>
                /// The start time of automatic scheduling. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// 
                /// This parameter corresponds to the Validity Period parameter in the Schedule section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                /// </summary>
                [NameInMap("StartEffectDate")]
                [Validation(Required=false)]
                public long? StartEffectDate { get; set; }

                /// <summary>
                /// Indicates whether a node is immediately run after the node is deployed to the production environment.
                /// 
                /// This parameter is valid only for an EMR Spark Streaming node or an EMR Streaming SQL node. This parameter corresponds to the Start Method parameter in the Schedule section of the Configure tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                /// </summary>
                [NameInMap("StartImmediately")]
                [Validation(Required=false)]
                public bool? StartImmediately { get; set; }

                /// <summary>
                /// Indicates whether the scheduling for the node is suspended Valid values:
                /// 
                /// *   true: The scheduling for the node is suspended.
                /// *   false: The scheduling for the node is not suspended.
                /// 
                /// This parameter corresponds to the Recurrence parameter in the Schedule section of the Properties tab in the [DataWorks console](https://workbench.data.aliyun.com/console).
                /// </summary>
                [NameInMap("Stop")]
                [Validation(Required=false)]
                public bool? Stop { get; set; }

            }

        }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The ID of the request. You can use the ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true: The request is successful.
        /// *   false: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
