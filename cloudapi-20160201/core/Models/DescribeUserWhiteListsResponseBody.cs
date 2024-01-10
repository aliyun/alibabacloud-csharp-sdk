// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160201.Models
{
    public class DescribeUserWhiteListsResponseBody : TeaModel {
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

        [NameInMap("UserWhiteListInfos")]
        [Validation(Required=false)]
        public DescribeUserWhiteListsResponseBodyUserWhiteListInfos UserWhiteListInfos { get; set; }
        public class DescribeUserWhiteListsResponseBodyUserWhiteListInfos : TeaModel {
            [NameInMap("UserWhiteListInfo")]
            [Validation(Required=false)]
            public List<DescribeUserWhiteListsResponseBodyUserWhiteListInfosUserWhiteListInfo> UserWhiteListInfo { get; set; }
            public class DescribeUserWhiteListsResponseBodyUserWhiteListInfosUserWhiteListInfo : TeaModel {
                [NameInMap("AoneId")]
                [Validation(Required=false)]
                public string AoneId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Uid")]
                [Validation(Required=false)]
                public long? Uid { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
