// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListCorpGroupsResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListCorpGroupsResponseData Data { get; set; }
        public class ListCorpGroupsResponseData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public long PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public long PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public long TotalCount { get; set; }
            [NameInMap("TotalPage")]
            [Validation(Required=true)]
            public long TotalPage { get; set; }
            [NameInMap("Records")]
            [Validation(Required=true)]
            public List<string> Records { get; set; }
        };

    }

}
