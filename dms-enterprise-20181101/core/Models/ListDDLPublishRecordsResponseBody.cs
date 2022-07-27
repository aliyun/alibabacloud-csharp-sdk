// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDDLPublishRecordsResponseBody : TeaModel {
        [NameInMap("DDLPublishRecordList")]
        [Validation(Required=false)]
        public List<ListDDLPublishRecordsResponseBodyDDLPublishRecordList> DDLPublishRecordList { get; set; }
        public class ListDDLPublishRecordsResponseBodyDDLPublishRecordList : TeaModel {
            [NameInMap("AuditExpireTime")]
            [Validation(Required=false)]
            public string AuditExpireTime { get; set; }

            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public long? CreatorId { get; set; }

            [NameInMap("Finality")]
            [Validation(Required=false)]
            public bool? Finality { get; set; }

            [NameInMap("FinalityReason")]
            [Validation(Required=false)]
            public string FinalityReason { get; set; }

            [NameInMap("PublishStatus")]
            [Validation(Required=false)]
            public string PublishStatus { get; set; }

            [NameInMap("PublishTaskInfoList")]
            [Validation(Required=false)]
            public List<ListDDLPublishRecordsResponseBodyDDLPublishRecordListPublishTaskInfoList> PublishTaskInfoList { get; set; }
            public class ListDDLPublishRecordsResponseBodyDDLPublishRecordListPublishTaskInfoList : TeaModel {
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                [NameInMap("PlanTime")]
                [Validation(Required=false)]
                public string PlanTime { get; set; }

                [NameInMap("PublishJobList")]
                [Validation(Required=false)]
                public List<ListDDLPublishRecordsResponseBodyDDLPublishRecordListPublishTaskInfoListPublishJobList> PublishJobList { get; set; }
                public class ListDDLPublishRecordsResponseBodyDDLPublishRecordListPublishTaskInfoListPublishJobList : TeaModel {
                    [NameInMap("DBTaskGroupId")]
                    [Validation(Required=false)]
                    public long? DBTaskGroupId { get; set; }

                    [NameInMap("ExecuteCount")]
                    [Validation(Required=false)]
                    public long? ExecuteCount { get; set; }

                    [NameInMap("Scripts")]
                    [Validation(Required=false)]
                    public string Scripts { get; set; }

                    [NameInMap("StatusDesc")]
                    [Validation(Required=false)]
                    public string StatusDesc { get; set; }

                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    [NameInMap("TaskJobStatus")]
                    [Validation(Required=false)]
                    public string TaskJobStatus { get; set; }

                }

                [NameInMap("PublishStrategy")]
                [Validation(Required=false)]
                public string PublishStrategy { get; set; }

                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                [NameInMap("TaskJobStatus")]
                [Validation(Required=false)]
                public string TaskJobStatus { get; set; }

            }

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            [NameInMap("WorkflowInstanceId")]
            [Validation(Required=false)]
            public long? WorkflowInstanceId { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
