// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class ListUserFbIssuesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListUserFbIssuesResponseBodyData Data { get; set; }
        public class ListUserFbIssuesResponseBodyData : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public string Count { get; set; }

            [NameInMap("FeedbackIssueData")]
            [Validation(Required=false)]
            public List<ListUserFbIssuesResponseBodyDataFeedbackIssueData> FeedbackIssueData { get; set; }
            public class ListUserFbIssuesResponseBodyDataFeedbackIssueData : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                [NameInMap("ClientModel")]
                [Validation(Required=false)]
                public string ClientModel { get; set; }

                [NameInMap("ClientSn")]
                [Validation(Required=false)]
                public string ClientSn { get; set; }

                [NameInMap("CustomerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DesktopId")]
                [Validation(Required=false)]
                public string DesktopId { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("FbType")]
                [Validation(Required=false)]
                public int? FbType { get; set; }

                [NameInMap("FileList")]
                [Validation(Required=false)]
                public List<ListUserFbIssuesResponseBodyDataFeedbackIssueDataFileList> FileList { get; set; }
                public class ListUserFbIssuesResponseBodyDataFeedbackIssueDataFileList : TeaModel {
                    [NameInMap("FileMd5")]
                    [Validation(Required=false)]
                    public string FileMd5 { get; set; }

                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("FileSize")]
                    [Validation(Required=false)]
                    public int? FileSize { get; set; }

                    [NameInMap("FileType")]
                    [Validation(Required=false)]
                    public int? FileType { get; set; }

                    [NameInMap("OssUrl")]
                    [Validation(Required=false)]
                    public string OssUrl { get; set; }

                }

                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                [NameInMap("IssueId")]
                [Validation(Required=false)]
                public int? IssueId { get; set; }

                [NameInMap("IssueLabel")]
                [Validation(Required=false)]
                public string IssueLabel { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("UserEmail")]
                [Validation(Required=false)]
                public string UserEmail { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

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

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
