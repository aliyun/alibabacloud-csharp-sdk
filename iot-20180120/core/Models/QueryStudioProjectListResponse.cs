// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryStudioProjectListResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryStudioProjectListResponseData Data { get; set; }
        public class QueryStudioProjectListResponseData : TeaModel {
            [NameInMap("PageNo")]
            [Validation(Required=true)]
            public int? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }

            [NameInMap("TotalPage")]
            [Validation(Required=true)]
            public int? TotalPage { get; set; }

            [NameInMap("List")]
            [Validation(Required=true)]
            public QueryStudioProjectListResponseDataList List { get; set; }
            public class QueryStudioProjectListResponseDataList : TeaModel {
                [NameInMap("ProjectInfo")]
                [Validation(Required=true)]
                public List<QueryStudioProjectListResponseDataListProjectInfo> ProjectInfo { get; set; }
                public class QueryStudioProjectListResponseDataListProjectInfo : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=true)]
                    public string Description { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=true)]
                    public long? GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=true)]
                    public long? GmtModified { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                    [NameInMap("ProjectId")]
                    [Validation(Required=true)]
                    public string ProjectId { get; set; }

                }

            }

        }

    }

}
