// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeWhitelistResponse : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("Items")]
        [Validation(Required=true)]
        public List<DescribeWhitelistResponseItems> Items { get; set; }
        public class DescribeWhitelistResponseItems : TeaModel {
            [NameInMap("BizId")]
            [Validation(Required=true)]
            public string BizId { get; set; }

            [NameInMap("BizType")]
            [Validation(Required=true)]
            public string BizType { get; set; }

            [NameInMap("EndDate")]
            [Validation(Required=true)]
            public long? EndDate { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=true)]
            public long? GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=true)]
            public long? GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=true)]
            public long? Id { get; set; }

            [NameInMap("IdCardNum")]
            [Validation(Required=true)]
            public string IdCardNum { get; set; }

            [NameInMap("StartDate")]
            [Validation(Required=true)]
            public long? StartDate { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=true)]
            public long? Uid { get; set; }

            [NameInMap("Valid")]
            [Validation(Required=true)]
            public int? Valid { get; set; }

        }

    }

}
