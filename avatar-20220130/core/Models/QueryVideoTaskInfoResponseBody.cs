// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avatar20220130.Models
{
    public class QueryVideoTaskInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryVideoTaskInfoResponseBodyData Data { get; set; }
        public class QueryVideoTaskInfoResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryVideoTaskInfoResponseBodyDataList> List { get; set; }
            public class QueryVideoTaskInfoResponseBodyDataList : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("TaskResult")]
                [Validation(Required=false)]
                public QueryVideoTaskInfoResponseBodyDataListTaskResult TaskResult { get; set; }
                public class QueryVideoTaskInfoResponseBodyDataListTaskResult : TeaModel {
                    [NameInMap("AlphaUrl")]
                    [Validation(Required=false)]
                    public string AlphaUrl { get; set; }

                    [NameInMap("FailCode")]
                    [Validation(Required=false)]
                    public string FailCode { get; set; }

                    [NameInMap("FailReason")]
                    [Validation(Required=false)]
                    public string FailReason { get; set; }

                    [NameInMap("PreviewPic")]
                    [Validation(Required=false)]
                    public string PreviewPic { get; set; }

                    [NameInMap("SubtitlesUrl")]
                    [Validation(Required=false)]
                    public string SubtitlesUrl { get; set; }

                    [NameInMap("VideoDuration")]
                    [Validation(Required=false)]
                    public int? VideoDuration { get; set; }

                    [NameInMap("VideoUrl")]
                    [Validation(Required=false)]
                    public string VideoUrl { get; set; }

                    [NameInMap("WordSubtitlesUrl")]
                    [Validation(Required=false)]
                    public string WordSubtitlesUrl { get; set; }

                }

                [NameInMap("TaskUuid")]
                [Validation(Required=false)]
                public string TaskUuid { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
