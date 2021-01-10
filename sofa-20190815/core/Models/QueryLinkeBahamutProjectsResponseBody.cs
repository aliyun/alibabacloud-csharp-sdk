// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutProjectsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryLinkeBahamutProjectsResponseBodyResult> Result { get; set; }
        public class QueryLinkeBahamutProjectsResponseBodyResult : TeaModel {
            [NameInMap("FullName")]
            [Validation(Required=false)]
            public string FullName { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IdPath")]
            [Validation(Required=false)]
            public string IdPath { get; set; }

            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Admins")]
            [Validation(Required=false)]
            public List<QueryLinkeBahamutProjectsResponseBodyResultAdmins> Admins { get; set; }
            public class QueryLinkeBahamutProjectsResponseBodyResultAdmins : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("RealName")]
                [Validation(Required=false)]
                public string RealName { get; set; }

                [NameInMap("StaffId")]
                [Validation(Required=false)]
                public string StaffId { get; set; }

            }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public QueryLinkeBahamutProjectsResponseBodyResultCreator Creator { get; set; }
            public class QueryLinkeBahamutProjectsResponseBodyResultCreator : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }
                [NameInMap("RealName")]
                [Validation(Required=false)]
                public string RealName { get; set; }
                [NameInMap("StaffId")]
                [Validation(Required=false)]
                public string StaffId { get; set; }
            };

        }

        [NameInMap("Paginator")]
        [Validation(Required=false)]
        public QueryLinkeBahamutProjectsResponseBodyPaginator Paginator { get; set; }
        public class QueryLinkeBahamutProjectsResponseBodyPaginator : TeaModel {
            [NameInMap("ItemCount")]
            [Validation(Required=false)]
            public long? ItemCount { get; set; }
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public long? PageCount { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
        };

    }

}
