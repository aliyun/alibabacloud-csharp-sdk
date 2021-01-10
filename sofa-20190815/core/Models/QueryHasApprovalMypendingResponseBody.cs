// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasApprovalMypendingResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public QueryHasApprovalMypendingResponseBodyResultContent ResultContent { get; set; }
        public class QueryHasApprovalMypendingResponseBodyResultContent : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryHasApprovalMypendingResponseBodyResultContentData> Data { get; set; }
            public class QueryHasApprovalMypendingResponseBodyResultContentData : TeaModel {
                public string ApprovalProcessTaskId { get; set; }
                public string ApprovalLoginName { get; set; }
                public string Memo { get; set; }
                public string Action { get; set; }
                public string Id { get; set; }
                public string UtcCreate { get; set; }
                public string UtcModified { get; set; }
                public QueryHasApprovalMypendingResponseBodyResultContentDataApprovalDTO ApprovalDTO { get; set; }
                public class QueryHasApprovalMypendingResponseBodyResultContentDataApprovalDTO : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                    [NameInMap("OutBizId")]
                    [Validation(Required=false)]
                    public string OutBizId { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("RefSource")]
                    [Validation(Required=false)]
                    public string RefSource { get; set; }

                    [NameInMap("Context")]
                    [Validation(Required=false)]
                    public string Context { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("SyncFromBPMS")]
                    [Validation(Required=false)]
                    public bool? SyncFromBPMS { get; set; }

                    [NameInMap("ExecuteStatus")]
                    [Validation(Required=false)]
                    public string ExecuteStatus { get; set; }

                    [NameInMap("FailedReason")]
                    [Validation(Required=false)]
                    public string FailedReason { get; set; }

                    [NameInMap("SubmitterId")]
                    [Validation(Required=false)]
                    public string SubmitterId { get; set; }

                    [NameInMap("SubmitterAccount")]
                    [Validation(Required=false)]
                    public string SubmitterAccount { get; set; }

                    [NameInMap("SubmitterNickName")]
                    [Validation(Required=false)]
                    public string SubmitterNickName { get; set; }

                    [NameInMap("SubmitterRealName")]
                    [Validation(Required=false)]
                    public string SubmitterRealName { get; set; }

                    [NameInMap("Strategy")]
                    [Validation(Required=false)]
                    public string Strategy { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    [NameInMap("Brief")]
                    [Validation(Required=false)]
                    public string Brief { get; set; }

                    [NameInMap("StatusUpdated")]
                    [Validation(Required=false)]
                    public string StatusUpdated { get; set; }

                    [NameInMap("UpdaterId")]
                    [Validation(Required=false)]
                    public string UpdaterId { get; set; }

                    [NameInMap("BpmsLink")]
                    [Validation(Required=false)]
                    public string BpmsLink { get; set; }

                    [NameInMap("ProcessTaskId")]
                    [Validation(Required=false)]
                    public string ProcessTaskId { get; set; }

                    [NameInMap("UtcCreate")]
                    [Validation(Required=false)]
                    public string UtcCreate { get; set; }

                    [NameInMap("UtcModified")]
                    [Validation(Required=false)]
                    public string UtcModified { get; set; }

                    [NameInMap("RenderDatas")]
                    [Validation(Required=false)]
                    public List<QueryHasApprovalMypendingResponseBodyResultContentDataApprovalDTORenderDatas> RenderDatas { get; set; }
                    public class QueryHasApprovalMypendingResponseBodyResultContentDataApprovalDTORenderDatas : TeaModel {
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        [NameInMap("Visible")]
                        [Validation(Required=false)]
                        public bool? Visible { get; set; }

                    }

                }
            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public QueryHasApprovalMypendingResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class QueryHasApprovalMypendingResponseBodyResultContentTopErrorCode : TeaModel {
                [NameInMap("ExceptionCode")]
                [Validation(Required=false)]
                public string ExceptionCode { get; set; }

                [NameInMap("ExceptionCodeDescription")]
                [Validation(Required=false)]
                public string ExceptionCodeDescription { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }
            [NameInMap("TopErrorReason")]
            [Validation(Required=false)]
            public QueryHasApprovalMypendingResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class QueryHasApprovalMypendingResponseBodyResultContentTopErrorReason : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

            }
        };

    }

}
