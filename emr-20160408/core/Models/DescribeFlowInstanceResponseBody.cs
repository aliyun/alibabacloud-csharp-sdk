// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeFlowInstanceResponseBody : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        [NameInMap("DependencyFlowList")]
        [Validation(Required=false)]
        public DescribeFlowInstanceResponseBodyDependencyFlowList DependencyFlowList { get; set; }
        public class DescribeFlowInstanceResponseBodyDependencyFlowList : TeaModel {
            [NameInMap("ParentFlow")]
            [Validation(Required=false)]
            public List<DescribeFlowInstanceResponseBodyDependencyFlowListParentFlow> ParentFlow { get; set; }
            public class DescribeFlowInstanceResponseBodyDependencyFlowListParentFlow : TeaModel {
                [NameInMap("BizDate")]
                [Validation(Required=false)]
                public long? BizDate { get; set; }

                [NameInMap("DependencyFlowId")]
                [Validation(Required=false)]
                public string DependencyFlowId { get; set; }

                [NameInMap("DependencyInstanceId")]
                [Validation(Required=false)]
                public string DependencyInstanceId { get; set; }

                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                [NameInMap("FlowInstanceId")]
                [Validation(Required=false)]
                public string FlowInstanceId { get; set; }

                [NameInMap("Meet")]
                [Validation(Required=false)]
                public bool? Meet { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                [NameInMap("ScheduleKey")]
                [Validation(Required=false)]
                public string ScheduleKey { get; set; }

            }

        }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        [NameInMap("Graph")]
        [Validation(Required=false)]
        public string Graph { get; set; }

        [NameInMap("HasNodeFailed")]
        [Validation(Required=false)]
        public bool? HasNodeFailed { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Lifecycle")]
        [Validation(Required=false)]
        public string Lifecycle { get; set; }

        [NameInMap("LogArchiveLocation")]
        [Validation(Required=false)]
        public string LogArchiveLocation { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("NodeInstance")]
        [Validation(Required=false)]
        public DescribeFlowInstanceResponseBodyNodeInstance NodeInstance { get; set; }
        public class DescribeFlowInstanceResponseBodyNodeInstance : TeaModel {
            [NameInMap("NodeInstance")]
            [Validation(Required=false)]
            public List<DescribeFlowInstanceResponseBodyNodeInstanceNodeInstance> NodeInstance { get; set; }
            public class DescribeFlowInstanceResponseBodyNodeInstanceNodeInstance : TeaModel {
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("ExternalId")]
                [Validation(Required=false)]
                public string ExternalId { get; set; }

                [NameInMap("ExternalInfo")]
                [Validation(Required=false)]
                public string ExternalInfo { get; set; }

                [NameInMap("ExternalStatus")]
                [Validation(Required=false)]
                public string ExternalStatus { get; set; }

                [NameInMap("FailAct")]
                [Validation(Required=false)]
                public string FailAct { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                [NameInMap("JobType")]
                [Validation(Required=false)]
                public string JobType { get; set; }

                [NameInMap("MaxRetry")]
                [Validation(Required=false)]
                public string MaxRetry { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("Pending")]
                [Validation(Required=false)]
                public bool? Pending { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                [NameInMap("Retries")]
                [Validation(Required=false)]
                public int? Retries { get; set; }

                [NameInMap("RetryInterval")]
                [Validation(Required=false)]
                public string RetryInterval { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScheduleTime")]
        [Validation(Required=false)]
        public long? ScheduleTime { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
