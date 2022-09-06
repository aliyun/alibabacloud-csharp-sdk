// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryStudioAppPageListOpenResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryStudioAppPageListOpenResponseBodyData Data { get; set; }
        public class QueryStudioAppPageListOpenResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryStudioAppPageListOpenResponseBodyDataList List { get; set; }
            public class QueryStudioAppPageListOpenResponseBodyDataList : TeaModel {
                [NameInMap("PageInfo")]
                [Validation(Required=false)]
                public List<QueryStudioAppPageListOpenResponseBodyDataListPageInfo> PageInfo { get; set; }
                public class QueryStudioAppPageListOpenResponseBodyDataListPageInfo : TeaModel {
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public int? Id { get; set; }

                    [NameInMap("IsHidden")]
                    [Validation(Required=false)]
                    public int? IsHidden { get; set; }

                    [NameInMap("IsHome")]
                    [Validation(Required=false)]
                    public int? IsHome { get; set; }

                    [NameInMap("IsLoginPage")]
                    [Validation(Required=false)]
                    public int? IsLoginPage { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("PageId")]
                    [Validation(Required=false)]
                    public string PageId { get; set; }

                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                }

            }

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
