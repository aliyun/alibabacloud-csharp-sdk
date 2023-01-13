// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryStudioAppListResponse : TeaModel {
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
        public QueryStudioAppListResponseData Data { get; set; }
        public class QueryStudioAppListResponseData : TeaModel {
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
            public QueryStudioAppListResponseDataList List { get; set; }
            public class QueryStudioAppListResponseDataList : TeaModel {
                [NameInMap("AppInfo")]
                [Validation(Required=true)]
                public List<QueryStudioAppListResponseDataListAppInfo> AppInfo { get; set; }
                public class QueryStudioAppListResponseDataListAppInfo : TeaModel {
                    [NameInMap("AppId")]
                    [Validation(Required=true)]
                    public string AppId { get; set; }

                    [NameInMap("AppKey")]
                    [Validation(Required=true)]
                    public string AppKey { get; set; }

                    [NameInMap("AppSecret")]
                    [Validation(Required=true)]
                    public string AppSecret { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=true)]
                    public string Description { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=true)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=true)]
                    public string GmtModified { get; set; }

                    [NameInMap("GmtRelease")]
                    [Validation(Required=true)]
                    public string GmtRelease { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                    [NameInMap("ProjectId")]
                    [Validation(Required=true)]
                    public string ProjectId { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=true)]
                    public string Type { get; set; }

                }

            }

        }

    }

}
