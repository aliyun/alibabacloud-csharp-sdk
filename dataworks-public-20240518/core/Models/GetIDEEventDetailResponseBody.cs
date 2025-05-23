// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetIDEEventDetailResponseBody : TeaModel {
        [NameInMap("EventDetail")]
        [Validation(Required=false)]
        public GetIDEEventDetailResponseBodyEventDetail EventDetail { get; set; }
        public class GetIDEEventDetailResponseBodyEventDetail : TeaModel {
            [NameInMap("CommittedFile")]
            [Validation(Required=false)]
            public GetIDEEventDetailResponseBodyEventDetailCommittedFile CommittedFile { get; set; }
            public class GetIDEEventDetailResponseBodyEventDetailCommittedFile : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>UPDATE</para>
                /// </summary>
                [NameInMap("ChangeType")]
                [Validation(Required=false)]
                public string ChangeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Second version submission</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7384234****</para>
                /// </summary>
                [NameInMap("Committor")]
                [Validation(Required=false)]
                public string Committor { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SHOW TABLES;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234123</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hello_dataworks.sql</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("FilePropertyContent")]
                [Validation(Required=false)]
                public GetIDEEventDetailResponseBodyEventDetailCommittedFileFilePropertyContent FilePropertyContent { get; set; }
                public class GetIDEEventDetailResponseBodyEventDetailCommittedFileFilePropertyContent : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>74328</para>
                    /// </summary>
                    [NameInMap("BusinessId")]
                    [Validation(Required=false)]
                    public long? BusinessId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CurrentVersion")]
                    [Validation(Required=false)]
                    public long? CurrentVersion { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>odps_source</para>
                    /// </summary>
                    [NameInMap("DataSourceName")]
                    [Validation(Required=false)]
                    public string DataSourceName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>aldurie78l2falure</para>
                    /// </summary>
                    [NameInMap("FolderId")]
                    [Validation(Required=false)]
                    public string FolderId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>7384234****</para>
                    /// </summary>
                    [NameInMap("Owner")]
                    [Validation(Required=false)]
                    public string Owner { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1234122</para>
                    /// </summary>
                    [NameInMap("ParentFileId")]
                    [Validation(Required=false)]
                    public long? ParentFileId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public long? FileType { get; set; }

                [NameInMap("NodeConfiguration")]
                [Validation(Required=false)]
                public GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfiguration NodeConfiguration { get; set; }
                public class GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfiguration : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>120000</para>
                    /// </summary>
                    [NameInMap("AutoRerunIntervalMillis")]
                    [Validation(Required=false)]
                    public long? AutoRerunIntervalMillis { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("AutoRerunTimes")]
                    [Validation(Required=false)]
                    public long? AutoRerunTimes { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>00 05 00 * * ?</para>
                    /// </summary>
                    [NameInMap("CronExpress")]
                    [Validation(Required=false)]
                    public string CronExpress { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DAY</para>
                    /// </summary>
                    [NameInMap("CycleType")]
                    [Validation(Required=false)]
                    public string CycleType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5,10,15,20</para>
                    /// </summary>
                    [NameInMap("DependentNodeIdList")]
                    [Validation(Required=false)]
                    public string DependentNodeIdList { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>USER_DEFINE</para>
                    /// </summary>
                    [NameInMap("DependentType")]
                    [Validation(Required=false)]
                    public string DependentType { get; set; }

                    [NameInMap("InputList")]
                    [Validation(Required=false)]
                    public List<GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfigurationInputList> InputList { get; set; }
                    public class GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfigurationInputList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>dw_project_root</para>
                        /// </summary>
                        [NameInMap("Input")]
                        [Validation(Required=false)]
                        public string Input { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>MANUAL</para>
                        /// </summary>
                        [NameInMap("ParseType")]
                        [Validation(Required=false)]
                        public string ParseType { get; set; }

                    }

                    [NameInMap("OutputList")]
                    [Validation(Required=false)]
                    public List<GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfigurationOutputList> OutputList { get; set; }
                    public class GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfigurationOutputList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>dw_project.002_out</para>
                        /// </summary>
                        [NameInMap("Output")]
                        [Validation(Required=false)]
                        public string Output { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>ods_user_info_d</para>
                        /// </summary>
                        [NameInMap("RefTableName")]
                        [Validation(Required=false)]
                        public string RefTableName { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>a=x b=y</para>
                    /// </summary>
                    [NameInMap("ParaValue")]
                    [Validation(Required=false)]
                    public string ParaValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ALL_ALLOWED</para>
                    /// </summary>
                    [NameInMap("RerunMode")]
                    [Validation(Required=false)]
                    public string RerunMode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>375827434852437</para>
                    /// </summary>
                    [NameInMap("ResourceGroupId")]
                    [Validation(Required=false)]
                    public long? ResourceGroupId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>NORMAL</para>
                    /// </summary>
                    [NameInMap("SchedulerType")]
                    [Validation(Required=false)]
                    public string SchedulerType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>421429</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("UseType")]
                [Validation(Required=false)]
                public string UseType { get; set; }

            }

            [NameInMap("DeletedFile")]
            [Validation(Required=false)]
            public GetIDEEventDetailResponseBodyEventDetailDeletedFile DeletedFile { get; set; }
            public class GetIDEEventDetailResponseBodyEventDetailDeletedFile : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>74328</para>
                /// </summary>
                [NameInMap("BusinessId")]
                [Validation(Required=false)]
                public long? BusinessId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SHOW TABLES;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public long? CurrentVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>odps_source</para>
                /// </summary>
                [NameInMap("DataSourceName")]
                [Validation(Required=false)]
                public string DataSourceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234123</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hello_dataworks.sql</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public long? FileType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aldurie78l2falure</para>
                /// </summary>
                [NameInMap("FolderId")]
                [Validation(Required=false)]
                public string FolderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>421429</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7384234****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234122</para>
                /// </summary>
                [NameInMap("ParentFileId")]
                [Validation(Required=false)]
                public long? ParentFileId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("UseType")]
                [Validation(Required=false)]
                public string UseType { get; set; }

            }

            [NameInMap("FileExecutionCommand")]
            [Validation(Required=false)]
            public GetIDEEventDetailResponseBodyEventDetailFileExecutionCommand FileExecutionCommand { get; set; }
            public class GetIDEEventDetailResponseBodyEventDetailFileExecutionCommand : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>SHOW TABLES;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>odps_source</para>
                /// </summary>
                [NameInMap("DataSourceName")]
                [Validation(Required=false)]
                public string DataSourceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234123</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public long? FileType { get; set; }

            }

            [NameInMap("TableModel")]
            [Validation(Required=false)]
            public GetIDEEventDetailResponseBodyEventDetailTableModel TableModel { get; set; }
            public class GetIDEEventDetailResponseBodyEventDetailTableModel : TeaModel {
                [NameInMap("Columns")]
                [Validation(Required=false)]
                public List<GetIDEEventDetailResponseBodyEventDetailTableModelColumns> Columns { get; set; }
                public class GetIDEEventDetailResponseBodyEventDetailTableModelColumns : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ID</para>
                    /// </summary>
                    [NameInMap("ColumnName")]
                    [Validation(Required=false)]
                    public string ColumnName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BIGINT</para>
                    /// </summary>
                    [NameInMap("ColumnType")]
                    [Validation(Required=false)]
                    public string ColumnType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ID</para>
                    /// </summary>
                    [NameInMap("Comment")]
                    [Validation(Required=false)]
                    public string Comment { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsPartitionColumn")]
                    [Validation(Required=false)]
                    public bool? IsPartitionColumn { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>A new table</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>odps_source</para>
                /// </summary>
                [NameInMap("DataSourceName")]
                [Validation(Required=false)]
                public string DataSourceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DEV</para>
                /// </summary>
                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("LifeCycle")]
                [Validation(Required=false)]
                public long? LifeCycle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hdfs://path/to/object</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tb_hello</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8abcb91f-d266-4073-b907-2ed670378ed1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
