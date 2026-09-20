// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetIDEEventDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The data snapshot at the time the extension point event was triggered.</para>
        /// <para>Different types of message events have different valid fields in the data snapshot. For details, refer to the field descriptions of each message event.</para>
        /// </summary>
        [NameInMap("EventDetail")]
        [Validation(Required=false)]
        public GetIDEEventDetailResponseBodyEventDetail EventDetail { get; set; }
        public class GetIDEEventDetailResponseBodyEventDetail : TeaModel {
            /// <summary>
            /// <para>The snapshot when a file is committed or deployed.</para>
            /// <para>This field is valid only when the Message type is IDE_FILE_SUBMIT_BEFORE or IDE_FILE_DEPLOY_BEFORE.</para>
            /// </summary>
            [NameInMap("CommittedFile")]
            [Validation(Required=false)]
            public GetIDEEventDetailResponseBodyEventDetailCommittedFile CommittedFile { get; set; }
            public class GetIDEEventDetailResponseBodyEventDetailCommittedFile : TeaModel {
                /// <summary>
                /// <para>The change type of this file version. Valid values: CREATE, UPDATE, and DELETE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UPDATE</para>
                /// </summary>
                [NameInMap("ChangeType")]
                [Validation(Required=false)]
                public string ChangeType { get; set; }

                /// <summary>
                /// <para>The description of this file version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Second version submission</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud user ID that generated this file version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7384234****</para>
                /// </summary>
                [NameInMap("Committor")]
                [Validation(Required=false)]
                public string Committor { get; set; }

                /// <summary>
                /// <para>The file code that generated this file version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SHOW TABLES;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The ID of the file.</para>
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
                /// <para>The additional properties of the file.</para>
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
                    /// <para>The latest version of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CurrentVersion")]
                    [Validation(Required=false)]
                    public long? CurrentVersion { get; set; }

                    /// <summary>
                    /// <para>The unique identifier of the data source associated with the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>odps_source</para>
                    /// </summary>
                    [NameInMap("DataSourceName")]
                    [Validation(Required=false)]
                    public string DataSourceName { get; set; }

                    /// <summary>
                    /// <para>The ID of the folder to which the file belongs. You can call the <a href="https://help.aliyun.com/document_detail/173952.html">GetFolder</a> operation to query file details by folder ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aldurie78l2falure</para>
                    /// </summary>
                    [NameInMap("FolderId")]
                    [Validation(Required=false)]
                    public string FolderId { get; set; }

                    /// <summary>
                    /// <para>The owner of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7384234****</para>
                    /// </summary>
                    [NameInMap("Owner")]
                    [Validation(Required=false)]
                    public string Owner { get; set; }

                    /// <summary>
                    /// <para>The node ID of the loop node or traversal node to which the file belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234122</para>
                    /// </summary>
                    [NameInMap("ParentFileId")]
                    [Validation(Required=false)]
                    public long? ParentFileId { get; set; }

                }

                /// <summary>
                /// <para>The file type. Different file types have different code. For more information, see <a href="https://help.aliyun.com/document_detail/600169.html">DataWorks nodes</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public long? FileType { get; set; }

                /// <summary>
                /// <para>The scheduling configuration of the file.</para>
                /// </summary>
                [NameInMap("NodeConfiguration")]
                [Validation(Required=false)]
                public GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfiguration NodeConfiguration { get; set; }
                public class GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfiguration : TeaModel {
                    /// <summary>
                    /// <para>The interval between automatic reruns, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120000</para>
                    /// </summary>
                    [NameInMap("AutoRerunIntervalMillis")]
                    [Validation(Required=false)]
                    public long? AutoRerunIntervalMillis { get; set; }

                    /// <summary>
                    /// <para>The number of automatic reruns.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("AutoRerunTimes")]
                    [Validation(Required=false)]
                    public long? AutoRerunTimes { get; set; }

                    /// <summary>
                    /// <para>The scheduling cron expression.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>00 05 00 * * ?</para>
                    /// </summary>
                    [NameInMap("CronExpress")]
                    [Validation(Required=false)]
                    public string CronExpress { get; set; }

                    /// <summary>
                    /// <para>The type of the scheduling cycle. Valid values: NOT_DAY (minute or hour) and DAY (day, week, or month).</para>
                    /// <para>This parameter corresponds to the &quot;Schedule Configuration &gt; Time Properties &gt; Scheduling Cycle&quot; setting of a DataStudio task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DAY</para>
                    /// </summary>
                    [NameInMap("CycleType")]
                    [Validation(Required=false)]
                    public string CycleType { get; set; }

                    /// <summary>
                    /// <para>The IDs of the nodes on which the current file depends when the DependentType parameter settings are set to USER_DEFINE. Separate multiple node IDs with commas (,).</para>
                    /// <para>This parameter corresponds to the &quot;Settings &gt; Scheduling Dependencies &gt; Cross-epoch Dependencies (Previous Epoch)&quot; setting of a DataStudio task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, when the dependency is set to &quot;Other Nodes&quot;.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5,10,15,20</para>
                    /// </summary>
                    [NameInMap("DependentNodeIdList")]
                    [Validation(Required=false)]
                    public string DependentNodeIdList { get; set; }

                    /// <summary>
                    /// <para>The method of depending on the previous cycle. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>SELF: the dependency is set to the current node.</description></item>
                    /// <item><description>CHILD: the dependency is set to first-level child nodes.</description></item>
                    /// <item><description>USER_DEFINE: the dependency is set to other nodes.</description></item>
                    /// <item><description>NONE: no dependency is selected, meaning the node does not depend on the previous cycle.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>USER_DEFINE</para>
                    /// </summary>
                    [NameInMap("DependentType")]
                    [Validation(Required=false)]
                    public string DependentType { get; set; }

                    /// <summary>
                    /// <para>The upstream file outputs on which the file depends.</para>
                    /// </summary>
                    [NameInMap("InputList")]
                    [Validation(Required=false)]
                    public List<GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfigurationInputList> InputList { get; set; }
                    public class GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfigurationInputList : TeaModel {
                        /// <summary>
                        /// <para>The output name of the upstream file on which the file depends.</para>
                        /// <para>This parameter corresponds to the &quot;Output Name of Upstream Node&quot; in the &quot;Schedule Configuration &gt; Scheduling Dependencies &gt; Depends On Upstream Nodes&quot; setting of a DataStudio task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dw_project_root</para>
                        /// </summary>
                        [NameInMap("Input")]
                        [Validation(Required=false)]
                        public string Input { get; set; }

                        /// <summary>
                        /// <para>The method used to configure file dependencies. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>MANUAL: manual configuration.</description></item>
                        /// <item><description>AUTO: automatic parsing.</description></item>
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
                    /// <para>The outputs of the file.</para>
                    /// <para>This parameter corresponds to the &quot;Schedule Configuration &gt; Scheduling Dependencies &gt; Output Name of Current Node&quot; setting of a DataStudio task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// </summary>
                    [NameInMap("OutputList")]
                    [Validation(Required=false)]
                    public List<GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfigurationOutputList> OutputList { get; set; }
                    public class GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfigurationOutputList : TeaModel {
                        /// <summary>
                        /// <para>The output name of the file.</para>
                        /// <para>This parameter corresponds to the &quot;Output Name&quot; in the &quot;Schedule Configuration &gt; Scheduling Dependencies &gt; Output Name of Current Node&quot; setting of a DataStudio task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dw_project.002_out</para>
                        /// </summary>
                        [NameInMap("Output")]
                        [Validation(Required=false)]
                        public string Output { get; set; }

                        /// <summary>
                        /// <para>The output table name of the file.</para>
                        /// <para>This parameter corresponds to the &quot;Output Table Name&quot; in the &quot;Schedule Configuration &gt; Scheduling Dependencies &gt; Output Name of Current Node&quot; setting of a DataStudio task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ods_user_info_d</para>
                        /// </summary>
                        [NameInMap("RefTableName")]
                        [Validation(Required=false)]
                        public string RefTableName { get; set; }

                    }

                    /// <summary>
                    /// <para>The scheduling parameters.</para>
                    /// <para>This parameter corresponds to the &quot;Schedule Configuration &gt; Parameters&quot; setting of a DataStudio task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. For more information, see <a href="https://help.aliyun.com/document_detail/137548.html">Scheduling parameters</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>a=x b=y</para>
                    /// </summary>
                    [NameInMap("ParaValue")]
                    [Validation(Required=false)]
                    public string ParaValue { get; set; }

                    /// <summary>
                    /// <para>The rerun property. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ALL_ALLOWED: The node can be rerun regardless of whether it runs successfully or fails.</description></item>
                    /// <item><description>FAILURE_ALLOWED: The node can be rerun only after it fails.</description></item>
                    /// <item><description>ALL_DENIED: The node cannot be rerun regardless of whether it runs successfully or fails.</description></item>
                    /// </list>
                    /// <para>This parameter corresponds to the &quot;Schedule Configuration &gt; Time Properties &gt; Rerun Properties&quot; setting of a DataStudio task in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ALL_ALLOWED</para>
                    /// </summary>
                    [NameInMap("RerunMode")]
                    [Validation(Required=false)]
                    public string RerunMode { get; set; }

                    /// <summary>
                    /// <para>The resource group used when the task is executed after the file is deployed. You can call the <a href="https://help.aliyun.com/document_detail/173913.html">ListResourceGroups</a> operation to obtain the list of available resource groups for the workspace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>375827434852437</para>
                    /// </summary>
                    [NameInMap("ResourceGroupId")]
                    [Validation(Required=false)]
                    public long? ResourceGroupId { get; set; }

                    /// <summary>
                    /// <para>The scheduling type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>NORMAL: normal scheduling task.</description></item>
                    /// <item><description>MANUAL: manual task that is not scheduled on a regular basis. This corresponds to nodes in a manual workflow.</description></item>
                    /// <item><description>PAUSE: paused task.</description></item>
                    /// <item><description>SKIP: dry-run task that is scheduled on a regular basis but is directly set to successful when scheduling starts.</description></item>
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
                /// <para>The ID of the scheduling node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>421429</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The functional module to which the file belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NORMAL: DataStudio.</description></item>
                /// <item><description>MANUAL: manual task.</description></item>
                /// <item><description>MANUAL_BIZ: manual workflow.</description></item>
                /// <item><description>SKIP: dry-run scheduling in DataStudio.</description></item>
                /// <item><description>ADHOCQUERY: ad hoc query.</description></item>
                /// <item><description>COMPONENT: component management.</description></item>
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
            /// <para>The snapshot information when a file is deleted. This field is valid only when the Message type is IDE_FILE_DELETE_BEFORE.</para>
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
                /// <para>The file code that generated this file version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SHOW TABLES;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The latest version of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public long? CurrentVersion { get; set; }

                /// <summary>
                /// <para>The unique identifier of the data source associated with the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_source</para>
                /// </summary>
                [NameInMap("DataSourceName")]
                [Validation(Required=false)]
                public string DataSourceName { get; set; }

                /// <summary>
                /// <para>The ID of the file.</para>
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
                /// <para>The file type. Different file types have different code. For more information, see <a href="https://help.aliyun.com/document_detail/600169.html">DataWorks nodes</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public long? FileType { get; set; }

                /// <summary>
                /// <para>The ID of the folder to which the file belongs. You can call the <a href="https://help.aliyun.com/document_detail/173952.html">GetFolder</a> operation to query file details by folder ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aldurie78l2falure</para>
                /// </summary>
                [NameInMap("FolderId")]
                [Validation(Required=false)]
                public string FolderId { get; set; }

                /// <summary>
                /// <para>The ID of the scheduling node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>421429</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The owner of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7384234****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The node ID of the loop node or traversal node to which the file belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234122</para>
                /// </summary>
                [NameInMap("ParentFileId")]
                [Validation(Required=false)]
                public long? ParentFileId { get; set; }

                /// <summary>
                /// <para>The functional module to which the file belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NORMAL: DataStudio.</description></item>
                /// <item><description>MANUAL: manual task.</description></item>
                /// <item><description>MANUAL_BIZ: manual workflow.</description></item>
                /// <item><description>SKIP: dry-run scheduling in DataStudio.</description></item>
                /// <item><description>ADHOCQUERY: ad hoc query.</description></item>
                /// <item><description>COMPONENT: component management.</description></item>
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
            /// <para>The snapshot when file code is executed. This field is valid only when the Message type is IDE_FILE_EXECUTE_BEFORE.</para>
            /// </summary>
            [NameInMap("FileExecutionCommand")]
            [Validation(Required=false)]
            public GetIDEEventDetailResponseBodyEventDetailFileExecutionCommand FileExecutionCommand { get; set; }
            public class GetIDEEventDetailResponseBodyEventDetailFileExecutionCommand : TeaModel {
                /// <summary>
                /// <para>The file code that generated this file version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SHOW TABLES;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The unique identifier of the data source associated with the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_source</para>
                /// </summary>
                [NameInMap("DataSourceName")]
                [Validation(Required=false)]
                public string DataSourceName { get; set; }

                /// <summary>
                /// <para>The ID of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234123</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <para>The file type. Different file types have different code. For more information, see <a href="https://help.aliyun.com/document_detail/600169.html">DataWorks nodes</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public long? FileType { get; set; }

            }

            /// <summary>
            /// <para>The snapshot when a table is committed or deployed. This field is valid only when the Message type is IDE_TABLE_SUBMIT_BEFORE or IDE_TABLE_DEPLOY_BEFORE.</para>
            /// </summary>
            [NameInMap("TableModel")]
            [Validation(Required=false)]
            public GetIDEEventDetailResponseBodyEventDetailTableModel TableModel { get; set; }
            public class GetIDEEventDetailResponseBodyEventDetailTableModel : TeaModel {
                /// <summary>
                /// <para>The list of columns.</para>
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
                    /// <para>The type of the column.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BIGINT</para>
                    /// </summary>
                    [NameInMap("ColumnType")]
                    [Validation(Required=false)]
                    public string ColumnType { get; set; }

                    /// <summary>
                    /// <para>The comment of the column.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ID</para>
                    /// </summary>
                    [NameInMap("Comment")]
                    [Validation(Required=false)]
                    public string Comment { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the column is a partition column. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: The column is a partition column.</description></item>
                    /// <item><description>false: The column is not a partition column.</description></item>
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
                /// <para>The comment of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A new table</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The unique identifier of the data source to which the table belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_source</para>
                /// </summary>
                [NameInMap("DataSourceName")]
                [Validation(Required=false)]
                public string DataSourceName { get; set; }

                /// <summary>
                /// <para>The environment to which the table belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DEV: development environment.</description></item>
                /// <item><description>PROD: production environment.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DEV</para>
                /// </summary>
                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                /// <summary>
                /// <para>The lifecycle of the table. Unit: days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("LifeCycle")]
                [Validation(Required=false)]
                public long? LifeCycle { get; set; }

                /// <summary>
                /// <para>The location information of the external table.</para>
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
        /// <para>The unique ID of the request, which can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8abcb91f-d266-4073-b907-2ed670378ed1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
