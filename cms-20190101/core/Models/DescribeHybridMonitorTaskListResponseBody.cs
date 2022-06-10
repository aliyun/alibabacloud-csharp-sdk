// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorTaskListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<DescribeHybridMonitorTaskListResponseBodyTaskList> TaskList { get; set; }
        public class DescribeHybridMonitorTaskListResponseBodyTaskList : TeaModel {
            [NameInMap("AttachLabels")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorTaskListResponseBodyTaskListAttachLabels> AttachLabels { get; set; }
            public class DescribeHybridMonitorTaskListResponseBodyTaskListAttachLabels : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("CollectInterval")]
            [Validation(Required=false)]
            public int? CollectInterval { get; set; }

            [NameInMap("CollectTargetEndpoint")]
            [Validation(Required=false)]
            public string CollectTargetEndpoint { get; set; }

            [NameInMap("CollectTargetPath")]
            [Validation(Required=false)]
            public string CollectTargetPath { get; set; }

            [NameInMap("CollectTargetType")]
            [Validation(Required=false)]
            public string CollectTargetType { get; set; }

            [NameInMap("CollectTimout")]
            [Validation(Required=false)]
            public int? CollectTimout { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<string> Instances { get; set; }

            [NameInMap("LogFilePath")]
            [Validation(Required=false)]
            public string LogFilePath { get; set; }

            [NameInMap("LogProcess")]
            [Validation(Required=false)]
            public string LogProcess { get; set; }

            [NameInMap("LogSample")]
            [Validation(Required=false)]
            public string LogSample { get; set; }

            [NameInMap("LogSplit")]
            [Validation(Required=false)]
            public string LogSplit { get; set; }

            [NameInMap("MatchExpress")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorTaskListResponseBodyTaskListMatchExpress> MatchExpress { get; set; }
            public class DescribeHybridMonitorTaskListResponseBodyTaskListMatchExpress : TeaModel {
                [NameInMap("Function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("MatchExpressRelation")]
            [Validation(Required=false)]
            public string MatchExpressRelation { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            [NameInMap("SLSProcess")]
            [Validation(Required=false)]
            public string SLSProcess { get; set; }

            [NameInMap("SLSProcessConfig")]
            [Validation(Required=false)]
            public DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfig SLSProcessConfig { get; set; }
            public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfig : TeaModel {
                [NameInMap("Express")]
                [Validation(Required=false)]
                public List<DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigExpress> Express { get; set; }
                public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigExpress : TeaModel {
                    public string Alias { get; set; }
                    public string Express { get; set; }
                }
                [NameInMap("Filter")]
                [Validation(Required=false)]
                public DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigFilter Filter { get; set; }
                public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigFilter : TeaModel {
                    [NameInMap("Filters")]
                    [Validation(Required=false)]
                    public List<DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigFilterFilters> Filters { get; set; }
                    public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigFilterFilters : TeaModel {
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        [NameInMap("SLSKeyName")]
                        [Validation(Required=false)]
                        public string SLSKeyName { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("Relation")]
                    [Validation(Required=false)]
                    public string Relation { get; set; }

                }
                [NameInMap("GroupBy")]
                [Validation(Required=false)]
                public List<DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigGroupBy> GroupBy { get; set; }
                public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigGroupBy : TeaModel {
                    public string Alias { get; set; }
                    public string SLSKeyName { get; set; }
                }
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public List<DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigStatistics> Statistics { get; set; }
                public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigStatistics : TeaModel {
                    public string Alias { get; set; }
                    public string Function { get; set; }
                    public string Parameter1 { get; set; }
                    public string Parameter2 { get; set; }
                    public string SLSKeyName { get; set; }
                }
            };

            [NameInMap("TargetUserId")]
            [Validation(Required=false)]
            public string TargetUserId { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("UploadRegion")]
            [Validation(Required=false)]
            public string UploadRegion { get; set; }

            [NameInMap("YARMConfig")]
            [Validation(Required=false)]
            public string YARMConfig { get; set; }

        }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
