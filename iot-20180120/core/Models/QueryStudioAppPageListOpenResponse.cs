// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryStudioAppPageListOpenResponse : TeaModel {
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
        public QueryStudioAppPageListOpenResponseData Data { get; set; }
        public class QueryStudioAppPageListOpenResponseData : TeaModel {
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
            public QueryStudioAppPageListOpenResponseDataList List { get; set; }
            public class QueryStudioAppPageListOpenResponseDataList : TeaModel {
                [NameInMap("PageInfo")]
                [Validation(Required=true)]
                public List<QueryStudioAppPageListOpenResponseDataListPageInfo> PageInfo { get; set; }
                public class QueryStudioAppPageListOpenResponseDataListPageInfo : TeaModel {
                    [NameInMap("GmtCreate")]
                    [Validation(Required=true)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=true)]
                    public string GmtModified { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=true)]
                    public int? Id { get; set; }

                    [NameInMap("IsHidden")]
                    [Validation(Required=true)]
                    public int? IsHidden { get; set; }

                    [NameInMap("IsHome")]
                    [Validation(Required=true)]
                    public int? IsHome { get; set; }

                    [NameInMap("IsLoginPage")]
                    [Validation(Required=true)]
                    public int? IsLoginPage { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                    [NameInMap("PageId")]
                    [Validation(Required=true)]
                    public string PageId { get; set; }

                    [NameInMap("Path")]
                    [Validation(Required=true)]
                    public string Path { get; set; }

                }

            }

        }

    }

}
