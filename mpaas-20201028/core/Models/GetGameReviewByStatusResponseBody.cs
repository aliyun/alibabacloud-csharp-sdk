// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class GetGameReviewByStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public GetGameReviewByStatusResponseBodyResultContent ResultContent { get; set; }
        public class GetGameReviewByStatusResponseBodyResultContent : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<GetGameReviewByStatusResponseBodyResultContentContent> Content { get; set; }
            public class GetGameReviewByStatusResponseBodyResultContentContent : TeaModel {
                [NameInMap("Appendix")]
                [Validation(Required=false)]
                public string Appendix { get; set; }

                [NameInMap("AutoOnline")]
                [Validation(Required=false)]
                public bool? AutoOnline { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public long? FlowId { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Icons")]
                [Validation(Required=false)]
                public List<string> Icons { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("ReviewChannel")]
                [Validation(Required=false)]
                public string ReviewChannel { get; set; }

                [NameInMap("ReviewIntegerStatus")]
                [Validation(Required=false)]
                public int? ReviewIntegerStatus { get; set; }

                [NameInMap("ReviewProgress")]
                [Validation(Required=false)]
                public List<GetGameReviewByStatusResponseBodyResultContentContentReviewProgress> ReviewProgress { get; set; }
                public class GetGameReviewByStatusResponseBodyResultContentContentReviewProgress : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("FlowNodeId")]
                    [Validation(Required=false)]
                    public long? FlowNodeId { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("NodeIndex")]
                    [Validation(Required=false)]
                    public int? NodeIndex { get; set; }

                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    [NameInMap("NodeStatus")]
                    [Validation(Required=false)]
                    public string NodeStatus { get; set; }

                    [NameInMap("NodeStatusId")]
                    [Validation(Required=false)]
                    public int? NodeStatusId { get; set; }

                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("Remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    [NameInMap("RoleId")]
                    [Validation(Required=false)]
                    public long? RoleId { get; set; }

                }

                [NameInMap("ReviewStatus")]
                [Validation(Required=false)]
                public string ReviewStatus { get; set; }

                [NameInMap("ReviewTarget")]
                [Validation(Required=false)]
                public long? ReviewTarget { get; set; }

                [NameInMap("TargetDetail")]
                [Validation(Required=false)]
                public GetGameReviewByStatusResponseBodyResultContentContentTargetDetail TargetDetail { get; set; }
                public class GetGameReviewByStatusResponseBodyResultContentContentTargetDetail : TeaModel {
                    [NameInMap("AutoOnline")]
                    [Validation(Required=false)]
                    public bool? AutoOnline { get; set; }

                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public string Detail { get; set; }

                    [NameInMap("GameMaker")]
                    [Validation(Required=false)]
                    public string GameMaker { get; set; }

                    [NameInMap("IconUrl")]
                    [Validation(Required=false)]
                    public string IconUrl { get; set; }

                    [NameInMap("Introduction")]
                    [Validation(Required=false)]
                    public string Introduction { get; set; }

                    [NameInMap("MiniProgramCode")]
                    [Validation(Required=false)]
                    public string MiniProgramCode { get; set; }

                    [NameInMap("MiniProgramInfoId")]
                    [Validation(Required=false)]
                    public long? MiniProgramInfoId { get; set; }

                    [NameInMap("MiniProgramName")]
                    [Validation(Required=false)]
                    public string MiniProgramName { get; set; }

                    [NameInMap("MiniResourceId")]
                    [Validation(Required=false)]
                    public long? MiniResourceId { get; set; }

                    [NameInMap("PublishStatus")]
                    [Validation(Required=false)]
                    public int? PublishStatus { get; set; }

                    [NameInMap("QrCodeUrl")]
                    [Validation(Required=false)]
                    public string QrCodeUrl { get; set; }

                    [NameInMap("ReviewTargetType")]
                    [Validation(Required=false)]
                    public string ReviewTargetType { get; set; }

                    [NameInMap("SubType")]
                    [Validation(Required=false)]
                    public int? SubType { get; set; }

                    [NameInMap("TargetId")]
                    [Validation(Required=false)]
                    public long? TargetId { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("ResultMsg")]
            [Validation(Required=false)]
            public string ResultMsg { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
