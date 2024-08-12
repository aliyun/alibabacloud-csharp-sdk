// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class ListUserFbAcIssuesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListUserFbAcIssuesResponseBodyData Data { get; set; }
        public class ListUserFbAcIssuesResponseBodyData : TeaModel {
            [NameInMap("IssueDataList")]
            [Validation(Required=false)]
            public List<ListUserFbAcIssuesResponseBodyDataIssueDataList> IssueDataList { get; set; }
            public class ListUserFbAcIssuesResponseBodyDataIssueDataList : TeaModel {
                [NameInMap("Account")]
                [Validation(Required=false)]
                public string Account { get; set; }

                [NameInMap("ClientVersion")]
                [Validation(Required=false)]
                public string ClientVersion { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("FileList")]
                [Validation(Required=false)]
                public List<ListUserFbAcIssuesResponseBodyDataIssueDataListFileList> FileList { get; set; }
                public class ListUserFbAcIssuesResponseBodyDataIssueDataListFileList : TeaModel {
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("FileSize")]
                    [Validation(Required=false)]
                    public int? FileSize { get; set; }

                    [NameInMap("FileType")]
                    [Validation(Required=false)]
                    public int? FileType { get; set; }

                    [NameInMap("SessionId")]
                    [Validation(Required=false)]
                    public string SessionId { get; set; }

                }

                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("IssueId")]
                [Validation(Required=false)]
                public long? IssueId { get; set; }

                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("ReservedA")]
                [Validation(Required=false)]
                public string ReservedA { get; set; }

                [NameInMap("ReservedB")]
                [Validation(Required=false)]
                public string ReservedB { get; set; }

                [NameInMap("UserEmail")]
                [Validation(Required=false)]
                public string UserEmail { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
