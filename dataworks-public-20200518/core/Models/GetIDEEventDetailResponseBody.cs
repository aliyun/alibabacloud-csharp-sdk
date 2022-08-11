// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
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
                [NameInMap("ChangeType")]
                [Validation(Required=false)]
                public string ChangeType { get; set; }

                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("Committor")]
                [Validation(Required=false)]
                public string Committor { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("FilePropertyContent")]
                [Validation(Required=false)]
                public GetIDEEventDetailResponseBodyEventDetailCommittedFileFilePropertyContent FilePropertyContent { get; set; }
                public class GetIDEEventDetailResponseBodyEventDetailCommittedFileFilePropertyContent : TeaModel {
                    [NameInMap("BusinessId")]
                    [Validation(Required=false)]
                    public long? BusinessId { get; set; }
                    [NameInMap("CurrentVersion")]
                    [Validation(Required=false)]
                    public long? CurrentVersion { get; set; }
                    [NameInMap("DataSourceName")]
                    [Validation(Required=false)]
                    public string DataSourceName { get; set; }
                    [NameInMap("FolderId")]
                    [Validation(Required=false)]
                    public string FolderId { get; set; }
                    [NameInMap("Owner")]
                    [Validation(Required=false)]
                    public string Owner { get; set; }
                    [NameInMap("ParentFileId")]
                    [Validation(Required=false)]
                    public long? ParentFileId { get; set; }
                };

                [NameInMap("FileType")]
                [Validation(Required=false)]
                public long? FileType { get; set; }

                [NameInMap("NodeConfiguration")]
                [Validation(Required=false)]
                public GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfiguration NodeConfiguration { get; set; }
                public class GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfiguration : TeaModel {
                    [NameInMap("AutoRerunIntervalMillis")]
                    [Validation(Required=false)]
                    public long? AutoRerunIntervalMillis { get; set; }
                    [NameInMap("AutoRerunTimes")]
                    [Validation(Required=false)]
                    public long? AutoRerunTimes { get; set; }
                    [NameInMap("CronExpress")]
                    [Validation(Required=false)]
                    public string CronExpress { get; set; }
                    [NameInMap("CycleType")]
                    [Validation(Required=false)]
                    public string CycleType { get; set; }
                    [NameInMap("DependentNodeIdList")]
                    [Validation(Required=false)]
                    public string DependentNodeIdList { get; set; }
                    [NameInMap("DependentType")]
                    [Validation(Required=false)]
                    public string DependentType { get; set; }
                    [NameInMap("InputList")]
                    [Validation(Required=false)]
                    public List<GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfigurationInputList> InputList { get; set; }
                    public class GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfigurationInputList : TeaModel {
                        public string Input { get; set; }
                        public string ParseType { get; set; }
                    }
                    [NameInMap("OutputList")]
                    [Validation(Required=false)]
                    public List<GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfigurationOutputList> OutputList { get; set; }
                    public class GetIDEEventDetailResponseBodyEventDetailCommittedFileNodeConfigurationOutputList : TeaModel {
                        public string Output { get; set; }
                        public string RefTableName { get; set; }
                    }
                    [NameInMap("ParaValue")]
                    [Validation(Required=false)]
                    public string ParaValue { get; set; }
                    [NameInMap("RerunMode")]
                    [Validation(Required=false)]
                    public string RerunMode { get; set; }
                    [NameInMap("ResourceGroupId")]
                    [Validation(Required=false)]
                    public long? ResourceGroupId { get; set; }
                    [NameInMap("SchedulerType")]
                    [Validation(Required=false)]
                    public string SchedulerType { get; set; }
                };

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                [NameInMap("UseType")]
                [Validation(Required=false)]
                public string UseType { get; set; }

            }
            [NameInMap("DeletedFile")]
            [Validation(Required=false)]
            public GetIDEEventDetailResponseBodyEventDetailDeletedFile DeletedFile { get; set; }
            public class GetIDEEventDetailResponseBodyEventDetailDeletedFile : TeaModel {
                [NameInMap("BusinessId")]
                [Validation(Required=false)]
                public long? BusinessId { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public long? CurrentVersion { get; set; }

                [NameInMap("DataSourceName")]
                [Validation(Required=false)]
                public string DataSourceName { get; set; }

                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("FileType")]
                [Validation(Required=false)]
                public long? FileType { get; set; }

                [NameInMap("FolderId")]
                [Validation(Required=false)]
                public string FolderId { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("ParentFileId")]
                [Validation(Required=false)]
                public long? ParentFileId { get; set; }

                [NameInMap("UseType")]
                [Validation(Required=false)]
                public string UseType { get; set; }

            }
            [NameInMap("FileExecutionCommand")]
            [Validation(Required=false)]
            public GetIDEEventDetailResponseBodyEventDetailFileExecutionCommand FileExecutionCommand { get; set; }
            public class GetIDEEventDetailResponseBodyEventDetailFileExecutionCommand : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("DataSourceName")]
                [Validation(Required=false)]
                public string DataSourceName { get; set; }

                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

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
                    [NameInMap("ColumnName")]
                    [Validation(Required=false)]
                    public string ColumnName { get; set; }

                    [NameInMap("ColumnType")]
                    [Validation(Required=false)]
                    public string ColumnType { get; set; }

                    [NameInMap("Comment")]
                    [Validation(Required=false)]
                    public string Comment { get; set; }

                    [NameInMap("IsPartitionColumn")]
                    [Validation(Required=false)]
                    public bool? IsPartitionColumn { get; set; }

                }

                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("DataSourceName")]
                [Validation(Required=false)]
                public string DataSourceName { get; set; }

                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                [NameInMap("LifeCycle")]
                [Validation(Required=false)]
                public long? LifeCycle { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
