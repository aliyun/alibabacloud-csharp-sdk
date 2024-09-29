// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetIDEEventDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The data snapshot that is generated when an extension point event is triggered.</para>
        /// <para>The fields contained in data snapshots vary based on the types of the triggered extension point events. For more information, see the description of the fields.</para>
        /// </summary>
        [NameInMap("EventDetail")]
        [Validation(Required=false)]
        public GetIDEEventDetailResponseBodyEventDetail EventDetail { get; set; }
        public class GetIDEEventDetailResponseBodyEventDetail : TeaModel {
            /// <summary>
            /// <para>The data snapshot when the file is committed and deployed.</para>
            /// <para>This parameter is valid only if the message type is IDE_FILE_SUBMIT_BEFORE or IDE_FILE_DEPLOY_BEFORE.</para>
            /// </summary>
            [NameInMap("CommittedFile")]
            [Validation(Required=false)]
            public GetIDEEventDetailResponseBodyEventDetailCommittedFile CommittedFile { get; set; }
            public class GetIDEEventDetailResponseBodyEventDetailCommittedFile : TeaModel {
                /// <summary>
                /// <para>The type of the change to the file of the current version. Valid values: CREATE, UPDATE, and DELETE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UPDATE</para>
                /// </summary>
                [NameInMap("ChangeType")]
                [Validation(Required=false)]
                public string ChangeType { get; set; }

                /// <summary>
                /// <para>The description of the file version.</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that is used to generate the file of the current version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7384234****</para>
                /// </summary>
                [NameInMap("Committor")]
                [Validation(Required=false)]
                public string Committor { get; set; }

                /// <summary>
                /// <para>The code in the file of the current version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SHOW TABLES;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The file ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234123</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <para>The name of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hello_dataworks.sql</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The details of the file.</para>
                /// </summary>
                [NameInMap("FilePropertyContent")]
                [Validation(Required=false)]
                public GetIDEEventDetailResponseBodyEventDetailCommittedFileFilePropertyContent FilePropertyContent { get; set; }
                public class GetIDEEventDetailResponseBodyEventDetailCommittedFileFilePropertyContent : TeaModel {
                    /// <summary>
                    /// <para>The ID of the workflow to which the file belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>74328</para>
                    /// </summary>
                    [NameInMap("BusinessId")]
                    [Validation(Required=false)]
                    public long? BusinessId { get; set; }

                    /// <summary>
                    /// <para>The latest version number of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CurrentVersion")]
                    [Validation(Required=false)]
                    public long? CurrentVersion { get; set; }

                    /// <summary>
                    /// <para>The name of the data source with which the file is associated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps_first</para>
                    /// </summary>
                    [NameInMap("DataSourceName")]
                    [Validation(Required=false)]
                    public string DataSourceName { get; set; }

                    /// <summary>
                    /// <para>The ID of the folder to which the file belongs. You can call the <a href="https://help.aliyun.com/document_detail/173952.html">GetFolder</a> operation to query the details of the file based on the folder ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aldurie78l2falure</para>
                    /// </summary>
                    [NameInMap("FolderId")]
                    [Validation(Required=false)]
                    public string FolderId { get; set; }

                    /// <summary>
                    /// <para>The file owner.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7384234****</para>
                    /// </summary>
                    [NameInMap("Owner")]
                    [Validation(Required=false)]
                    public string Owner { get; set; }

                    /// <summary>
                    /// <para>The ID of the do-while node or for-each node that corresponds to the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234122</para>
                    /// </summary>
                    [NameInMap("ParentFileId")]
                    [Validation(Required=false)]
                    public long? ParentFileId { get; set; }

                }

                /// <summary>
                /// <para>The type of the code for the file. Valid values: 6 (Shell), 10 (ODPS SQL), 11 (ODPS MR), 23 (Data Integration), 24 (ODPS Script), 99 (zero load), 221 (PyODPS 2), 225 (ODPS Spark), 227 (EMR Hive), 228 (EMR Spark), 229 (EMR Spark SQL), 230 (EMR MR), 239 (OSS object inspection), 257 (EMR Shell), 258 (EMR Spark Shell), 259 (EMR Presto), 260 (EMR Impala), 900 (real-time synchronization), 1089 (cross-tenant collaboration), 1091 (Hologres development), 1093 (Hologres SQL), 1100 (assignment), and 1221 (PyODPS 3).</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public long? FileType { get; set; }

                /// <summary>
                /// <para>The scheduling properties of the node that corresponds to the file.</para>
                /// </summary>
                [NameInMap("NodeConfiguration")]
                [Validation(Required=false)]
                public GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfiguration NodeConfiguration { get; set; }
                public class GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The interval at which the node corresponding to the file is rerun. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120000</para>
                    /// </summary>
                    [NameInMap("AutoRerunIntervalMillis")]
                    [Validation(Required=false)]
                    public long? AutoRerunIntervalMillis { get; set; }

                    /// <summary>
                    /// <para>The number of times that the node corresponding to the file can be rerun.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("AutoRerunTimes")]
                    [Validation(Required=false)]
                    public long? AutoRerunTimes { get; set; }

                    /// <summary>
                    /// <para>The CRON expression that is used to schedule the node corresponding to the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>00 05 00 * * ?</para>
                    /// </summary>
                    [NameInMap("CronExpress")]
                    [Validation(Required=false)]
                    public string CronExpress { get; set; }

                    /// <summary>
                    /// <para>The type of the scheduling cycle of the node that corresponds to the file. Valid values: NOT_DAY and DAY. The value NOT_DAY indicates that the node is scheduled to run by minute or hour. The value DAY indicates that the node is scheduled to run by day, week, or month.</para>
                    /// <para>This parameter corresponds to the Scheduling Cycle parameter in the Schedule section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DAY</para>
                    /// </summary>
                    [NameInMap("CycleType")]
                    [Validation(Required=false)]
                    public string CycleType { get; set; }

                    /// <summary>
                    /// <para>The ID of the node on which the node that corresponds to the file depends when the DependentType parameter is set to USER_DEFINE. Multiple IDs are separated by commas (,).</para>
                    /// <para>The value of this parameter is equivalent to the ID of the node that you specified after you select Other Nodes for Cross-Cycle Dependency (Original Previous-Cycle Dependency) in the Dependencies section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5,10,15,20</para>
                    /// </summary>
                    [NameInMap("DependentNodeIdList")]
                    [Validation(Required=false)]
                    public string DependentNodeIdList { get; set; }

                    /// <summary>
                    /// <para>The type of the cross-cycle scheduling dependency of the node. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>SELF: The instance generated for the node in the current cycle depends on the instance generated for the node in the previous cycle.</description></item>
                    /// <item><description>CHILD: The instance generated for the node in the current cycle depends on the instances generated for the descendant nodes at the nearest level of the node in the previous cycle.</description></item>
                    /// <item><description>USER_DEFINE: The instance generated for the node in the current cycle depends on the instances generated for one or more specified nodes in the previous cycle.</description></item>
                    /// <item><description>NONE: No cross-cycle scheduling dependency type is selected for the node.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>USER_DEFINE</para>
                    /// </summary>
                    [NameInMap("DependentType")]
                    [Validation(Required=false)]
                    public string DependentType { get; set; }

                    /// <summary>
                    /// <para>The output names of the parent files on which the current file depends.</para>
                    /// </summary>
                    [NameInMap("InputList")]
                    [Validation(Required=false)]
                    public List<GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfigurationInputList> InputList { get; set; }
                    public class GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfigurationInputList : TeaModel {
                        /// <summary>
                        /// <para>The output name of the parent file on which the current file depends.</para>
                        /// <para>This parameter corresponds to the Output Name of Ancestor Node parameter under Parent Nodes in the Dependencies section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dw_project_root</para>
                        /// </summary>
                        [NameInMap("Input")]
                        [Validation(Required=false)]
                        public string Input { get; set; }

                        /// <summary>
                        /// <para>The mode of the configuration file dependency. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>MANUAL: Scheduling dependencies are manually configured.</description></item>
                        /// <item><description>AUTO: Scheduling dependencies are automatically parsed.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MANUAL</para>
                        /// </summary>
                        [NameInMap("ParseType")]
                        [Validation(Required=false)]
                        public string ParseType { get; set; }

                    }

                    /// <summary>
                    /// <para>The output names of the current file.</para>
                    /// <para>This parameter corresponds to the Output Name of Current Node parameter in the Dependencies section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// </summary>
                    [NameInMap("OutputList")]
                    [Validation(Required=false)]
                    public List<GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfigurationOutputList> OutputList { get; set; }
                    public class GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfigurationOutputList : TeaModel {
                        /// <summary>
                        /// <para>The output name of the current file.</para>
                        /// <para>This parameter corresponds to the Output Name parameter under Output Name of Current Node in the Dependencies section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dw_project.002_out</para>
                        /// </summary>
                        [NameInMap("Output")]
                        [Validation(Required=false)]
                        public string Output { get; set; }

                        /// <summary>
                        /// <para>The output table name of the current file.</para>
                        /// <para>This parameter corresponds to the Output Table Name parameter under Output Name of Current Node in the Dependencies section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ods_user_info_d</para>
                        /// </summary>
                        [NameInMap("RefTableName")]
                        [Validation(Required=false)]
                        public string RefTableName { get; set; }

                    }

                    /// <summary>
                    /// <para>The scheduling parameters of the node.</para>
                    /// <para>This parameter corresponds to the Scheduling Parameter section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. For more information about the configurations of the scheduling parameters, see <a href="https://help.aliyun.com/document_detail/137548.html">Configure scheduling parameters</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>a=x b=y</para>
                    /// </summary>
                    [NameInMap("ParaValue")]
                    [Validation(Required=false)]
                    public string ParaValue { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the node that corresponds to the file can be rerun. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ALL_ALLOWED: The node can be rerun regardless of whether it is successfully run or fails to run.</description></item>
                    /// <item><description>FAILURE_ALLOWED: The node can be rerun only after it fails to run.</description></item>
                    /// <item><description>ALL_DENIED: The node cannot be rerun regardless of whether it is successfully run or fails to run.</description></item>
                    /// </list>
                    /// <para>This parameter corresponds to the Rerun parameter in the Schedule section of the Properties tab in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ALL_ALLOWED</para>
                    /// </summary>
                    [NameInMap("RerunMode")]
                    [Validation(Required=false)]
                    public string RerunMode { get; set; }

                    /// <summary>
                    /// <para>The ID of the resource group that is used to run the node that corresponds to the file. You can call the <a href="https://help.aliyun.com/document_detail/173913.html">ListResourceGroups</a> operation to query the available resource groups in the workspace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>375827434852437</para>
                    /// </summary>
                    [NameInMap("ResourceGroupId")]
                    [Validation(Required=false)]
                    public long? ResourceGroupId { get; set; }

                    /// <summary>
                    /// <para>The scheduling type of the node. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>NORMAL: The node is an auto triggered node.</description></item>
                    /// <item><description>MANUAL: The node is a manually triggered node. Manually triggered nodes cannot be automatically triggered. They correspond to the nodes in the Manually Triggered Workflows pane.</description></item>
                    /// <item><description>PAUSE: The node is a paused node.</description></item>
                    /// <item><description>SKIP: The node is a dry-run node. Dry-run nodes are started as scheduled, but the system sets the status of the nodes to successful when it starts to run them.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NORMAL</para>
                    /// </summary>
                    [NameInMap("SchedulerType")]
                    [Validation(Required=false)]
                    public string SchedulerType { get; set; }

                }

                /// <summary>
                /// <para>The ID of the node that is scheduled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>421429</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The module to which the file belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NORMAL: The file is used for DataStudio.</description></item>
                /// <item><description>MANUAL: The file is used for a manually triggered node.</description></item>
                /// <item><description>MANUAL_BIZ: The file is used for a manually triggered workflow.</description></item>
                /// <item><description>SKIP: The file is used for a dry-run DataStudio node.</description></item>
                /// <item><description>ADHOCQUERY: The file is used for an ad hoc query.</description></item>
                /// <item><description>COMPONENT: The file is used for a snippet.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("UseType")]
                [Validation(Required=false)]
                public string UseType { get; set; }

            }

            /// <summary>
            /// <para>The data snapshot when the file is deleted. This parameter is valid only if the message type is IDE_FILE_DELETE_BEFORE.</para>
            /// </summary>
            [NameInMap("DeletedFile")]
            [Validation(Required=false)]
            public GetIDEEventDetailResponseBodyEventDetailDeletedFile DeletedFile { get; set; }
            public class GetIDEEventDetailResponseBodyEventDetailDeletedFile : TeaModel {
                /// <summary>
                /// <para>The ID of the workflow to which the file belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>74328</para>
                /// </summary>
                [NameInMap("BusinessId")]
                [Validation(Required=false)]
                public long? BusinessId { get; set; }

                /// <summary>
                /// <para>The code in the file of the current version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SHOW TABLES;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The latest version number of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public long? CurrentVersion { get; set; }

                /// <summary>
                /// <para>The name of the data source with which the file is associated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_first</para>
                /// </summary>
                [NameInMap("DataSourceName")]
                [Validation(Required=false)]
                public string DataSourceName { get; set; }

                /// <summary>
                /// <para>The file ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234123</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <para>The name of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hello_dataworks.sql</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The type of the code for the file. Valid values: 6 (Shell), 10 (ODPS SQL), 11 (ODPS MR), 23 (Data Integration), 24 (ODPS Script), 99 (zero load), 221 (PyODPS 2), 225 (ODPS Spark), 227 (EMR Hive), 228 (EMR Spark), 229 (EMR Spark SQL), 230 (EMR MR), 239 (OSS object inspection), 257 (EMR Shell), 258 (EMR Spark Shell), 259 (EMR Presto), 260 (EMR Impala), 900 (real-time synchronization), 1089 (cross-tenant collaboration), 1091 (Hologres development), 1093 (Hologres SQL), 1100 (assignment), and 1221 (PyODPS 3).</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public long? FileType { get; set; }

                /// <summary>
                /// <para>The ID of the folder to which the file belongs. You can call the <a href="https://help.aliyun.com/document_detail/173952.html">GetFolder</a> operation to query the details of the file based on the folder ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aldurie78l2falure</para>
                /// </summary>
                [NameInMap("FolderId")]
                [Validation(Required=false)]
                public string FolderId { get; set; }

                /// <summary>
                /// <para>The ID of the node that is scheduled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>421429</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The file owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7384234****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The ID of the do-while node or for-each node that corresponds to the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234122</para>
                /// </summary>
                [NameInMap("ParentFileId")]
                [Validation(Required=false)]
                public long? ParentFileId { get; set; }

                /// <summary>
                /// <para>The module to which the file belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NORMAL: The file is used for DataStudio.</description></item>
                /// <item><description>MANUAL: The file is used for a manually triggered node.</description></item>
                /// <item><description>MANUAL_BIZ: The file is used for a manually triggered workflow.</description></item>
                /// <item><description>SKIP: The file is used for a dry-run DataStudio node.</description></item>
                /// <item><description>ADHOCQUERY: The file is used for an ad hoc query.</description></item>
                /// <item><description>COMPONENT: The file is used for a snippet.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("UseType")]
                [Validation(Required=false)]
                public string UseType { get; set; }

            }

            /// <summary>
            /// <para>The data snapshot when the code in the file is run. This parameter is valid only if the message type is IDE_FILE_EXECUTE_BEFORE.</para>
            /// </summary>
            [NameInMap("FileExecutionCommand")]
            [Validation(Required=false)]
            public GetIDEEventDetailResponseBodyEventDetailFileExecutionCommand FileExecutionCommand { get; set; }
            public class GetIDEEventDetailResponseBodyEventDetailFileExecutionCommand : TeaModel {
                /// <summary>
                /// <para>The code in the file of the current version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SHOW TABLES;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The name of the data source with which the file is associated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_first</para>
                /// </summary>
                [NameInMap("DataSourceName")]
                [Validation(Required=false)]
                public string DataSourceName { get; set; }

                /// <summary>
                /// <para>The file ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234123</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <para>The type of the code for the file. The code for files varies based on the file type. For more information, see <a href="https://help.aliyun.com/document_detail/600169.html">DataWorks nodes</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public long? FileType { get; set; }

            }

            /// <summary>
            /// <para>The data snapshot when the table is committed and deployed. This parameter is valid only if the message type is IDE_TABLE_SUBMIT_BEFORE or IDE_TABLE_DEPLOY_BEFORE.</para>
            /// </summary>
            [NameInMap("TableModel")]
            [Validation(Required=false)]
            public GetIDEEventDetailResponseBodyEventDetailTableModel TableModel { get; set; }
            public class GetIDEEventDetailResponseBodyEventDetailTableModel : TeaModel {
                /// <summary>
                /// <para>The columns in the table.</para>
                /// </summary>
                [NameInMap("Columns")]
                [Validation(Required=false)]
                public List<GetIDEEventDetailResponseBodyEventDetailTableModelColumns> Columns { get; set; }
                public class GetIDEEventDetailResponseBodyEventDetailTableModelColumns : TeaModel {
                    /// <summary>
                    /// <para>The name of the column.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ID</para>
                    /// </summary>
                    [NameInMap("ColumnName")]
                    [Validation(Required=false)]
                    public string ColumnName { get; set; }

                    /// <summary>
                    /// <para>The data type of the column.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BIGINT</para>
                    /// </summary>
                    [NameInMap("ColumnType")]
                    [Validation(Required=false)]
                    public string ColumnType { get; set; }

                    /// <summary>
                    /// <para>The remarks of the column.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ID</para>
                    /// </summary>
                    [NameInMap("Comment")]
                    [Validation(Required=false)]
                    public string Comment { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the column is a partition key column. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsPartitionColumn")]
                    [Validation(Required=false)]
                    public bool? IsPartitionColumn { get; set; }

                }

                /// <summary>
                /// <para>The remarks of the table.</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The name of the data source to which the table belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_first</para>
                /// </summary>
                [NameInMap("DataSourceName")]
                [Validation(Required=false)]
                public string DataSourceName { get; set; }

                /// <summary>
                /// <para>The environment in which the table is used. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DEV</description></item>
                /// <item><description>PROD</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DEV</para>
                /// </summary>
                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                /// <summary>
                /// <para>The lifecycle of the metatable. Unit: day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("LifeCycle")]
                [Validation(Required=false)]
                public long? LifeCycle { get; set; }

                /// <summary>
                /// <para>The path of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hdfs://path/to/object</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>The name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tb_hello</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8abcb91f-d266-4073-b907-2ed670378ed1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
