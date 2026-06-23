// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class ListMdsCubeTemplatesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public ListMdsCubeTemplatesResponseBodyResultContent ResultContent { get; set; }
        public class ListMdsCubeTemplatesResponseBodyResultContent : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public ListMdsCubeTemplatesResponseBodyResultContentData Data { get; set; }
            public class ListMdsCubeTemplatesResponseBodyResultContentData : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public ListMdsCubeTemplatesResponseBodyResultContentDataContent Content { get; set; }
                public class ListMdsCubeTemplatesResponseBodyResultContentDataContent : TeaModel {
                    [NameInMap("FirstPage")]
                    [Validation(Required=false)]
                    public bool? FirstPage { get; set; }

                    [NameInMap("FirstResult")]
                    [Validation(Required=false)]
                    public long? FirstResult { get; set; }

                    [NameInMap("LastPage")]
                    [Validation(Required=false)]
                    public bool? LastPage { get; set; }

                    [NameInMap("List")]
                    [Validation(Required=false)]
                    public List<ListMdsCubeTemplatesResponseBodyResultContentDataContentList> List { get; set; }
                    public class ListMdsCubeTemplatesResponseBodyResultContentDataContentList : TeaModel {
                        [NameInMap("AppCode")]
                        [Validation(Required=false)]
                        public string AppCode { get; set; }

                        [NameInMap("GmtCreate")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }

                        [NameInMap("GmtModified")]
                        [Validation(Required=false)]
                        public string GmtModified { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public int? Status { get; set; }

                        [NameInMap("TemplateDesc")]
                        [Validation(Required=false)]
                        public string TemplateDesc { get; set; }

                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                        [NameInMap("TemplateName")]
                        [Validation(Required=false)]
                        public string TemplateName { get; set; }

                    }

                    [NameInMap("NextPage")]
                    [Validation(Required=false)]
                    public long? NextPage { get; set; }

                    [NameInMap("PageNo")]
                    [Validation(Required=false)]
                    public int? PageNo { get; set; }

                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public int? PageSize { get; set; }

                    [NameInMap("PrePage")]
                    [Validation(Required=false)]
                    public long? PrePage { get; set; }

                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public int? TotalCount { get; set; }

                    [NameInMap("TotalPage")]
                    [Validation(Required=false)]
                    public long? TotalPage { get; set; }

                }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                [NameInMap("ResultMsg")]
                [Validation(Required=false)]
                public string ResultMsg { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
