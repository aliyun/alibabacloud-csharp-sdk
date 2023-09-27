// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20180601.Models
{
    public class DescribeBlackListsResponseBody : TeaModel {
        [NameInMap("BlackLists")]
        [Validation(Required=false)]
        public DescribeBlackListsResponseBodyBlackLists BlackLists { get; set; }
        public class DescribeBlackListsResponseBodyBlackLists : TeaModel {
            [NameInMap("BlackList")]
            [Validation(Required=false)]
            public List<DescribeBlackListsResponseBodyBlackListsBlackList> BlackList { get; set; }
            public class DescribeBlackListsResponseBodyBlackListsBlackList : TeaModel {
                [NameInMap("BlackContent")]
                [Validation(Required=false)]
                public string BlackContent { get; set; }

                [NameInMap("BlackType")]
                [Validation(Required=false)]
                public string BlackType { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
