// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeAdvanceSearchPageListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeAdvanceSearchPageListResponseBodyResultObject ResultObject { get; set; }
        public class DescribeAdvanceSearchPageListResponseBodyResultObject : TeaModel {
            [NameInMap("currentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            [NameInMap("data")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Data { get; set; }

            [NameInMap("header")]
            [Validation(Required=false)]
            public List<DescribeAdvanceSearchPageListResponseBodyResultObjectHeader> Header { get; set; }
            public class DescribeAdvanceSearchPageListResponseBodyResultObjectHeader : TeaModel {
                [NameInMap("fieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                [NameInMap("fieldTitle")]
                [Validation(Required=false)]
                public string FieldTitle { get; set; }

                [NameInMap("isDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

            }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("totalItem")]
            [Validation(Required=false)]
            public long? TotalItem { get; set; }

            [NameInMap("totalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

        }

    }

}
