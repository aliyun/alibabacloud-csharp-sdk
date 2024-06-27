// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSafTagListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeSafTagListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeSafTagListResponseBodyResultObject : TeaModel {
            [NameInMap("tagDesc")]
            [Validation(Required=false)]
            public string TagDesc { get; set; }

            [NameInMap("tagMean")]
            [Validation(Required=false)]
            public string TagMean { get; set; }

            [NameInMap("tagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

            [NameInMap("tagState")]
            [Validation(Required=false)]
            public string TagState { get; set; }

            [NameInMap("tagType")]
            [Validation(Required=false)]
            public string TagType { get; set; }

            [NameInMap("tagUid")]
            [Validation(Required=false)]
            public string TagUid { get; set; }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
