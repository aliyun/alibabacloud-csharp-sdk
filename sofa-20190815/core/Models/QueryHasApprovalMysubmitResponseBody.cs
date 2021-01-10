// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasApprovalMysubmitResponseBody : TeaModel {
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
        public QueryHasApprovalMysubmitResponseBodyResultContent ResultContent { get; set; }
        public class QueryHasApprovalMysubmitResponseBodyResultContent : TeaModel {
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
            public List<QueryHasApprovalMysubmitResponseBodyResultContentData> Data { get; set; }
            public class QueryHasApprovalMysubmitResponseBodyResultContentData : TeaModel {
                public string Id { get; set; }
                public string Url { get; set; }
                public string OutBizId { get; set; }
                public string Type { get; set; }
                public string RefSource { get; set; }
                public string Context { get; set; }
                public string Status { get; set; }
                public bool? SyncFromBPMS { get; set; }
                public string ExecuteStatus { get; set; }
                public string FailedReason { get; set; }
                public string SubmitterId { get; set; }
                public string SubmitterAccount { get; set; }
                public string SubmitterNickName { get; set; }
                public string SubmitterRealName { get; set; }
                public string Strategy { get; set; }
                public string Title { get; set; }
                public string Brief { get; set; }
                public string StatusUpdated { get; set; }
                public string UpdaterId { get; set; }
                public string BpmsLink { get; set; }
                public string ProcessTaskId { get; set; }
                public string UtcCreate { get; set; }
                public string UtcModified { get; set; }
                public List<QueryHasApprovalMysubmitResponseBodyResultContentDataRenderDatas> RenderDatas { get; set; }
                public class QueryHasApprovalMysubmitResponseBodyResultContentDataRenderDatas : TeaModel {
                    public string Label { get; set; }
                    public string Key { get; set; }
                    public string Value { get; set; }
                    public bool? Visible { get; set; }
                }
            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public QueryHasApprovalMysubmitResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class QueryHasApprovalMysubmitResponseBodyResultContentTopErrorCode : TeaModel {
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
            public QueryHasApprovalMysubmitResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class QueryHasApprovalMysubmitResponseBodyResultContentTopErrorReason : TeaModel {
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
