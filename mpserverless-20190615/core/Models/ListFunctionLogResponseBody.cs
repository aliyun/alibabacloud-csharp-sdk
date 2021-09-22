// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class ListFunctionLogResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Paginator")]
        [Validation(Required=false)]
        public ListFunctionLogResponseBodyPaginator Paginator { get; set; }
        public class ListFunctionLogResponseBodyPaginator : TeaModel {
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }
        };

        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<ListFunctionLogResponseBodyDataList> DataList { get; set; }
        public class ListFunctionLogResponseBodyDataList : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SpaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            [NameInMap("Timestamps")]
            [Validation(Required=false)]
            public List<string> Timestamps { get; set; }

            [NameInMap("Contents")]
            [Validation(Required=false)]
            public List<string> Contents { get; set; }

            [NameInMap("Levels")]
            [Validation(Required=false)]
            public List<string> Levels { get; set; }

        }

    }

}
