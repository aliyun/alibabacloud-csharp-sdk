// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class ListLatestGameArchiveResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<ListLatestGameArchiveResponseBodyDataList> DataList { get; set; }
        public class ListLatestGameArchiveResponseBodyDataList : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("ArchiveId")]
            [Validation(Required=false)]
            public string ArchiveId { get; set; }

            [NameInMap("ArchiveTime")]
            [Validation(Required=false)]
            public string ArchiveTime { get; set; }

            [NameInMap("GameId")]
            [Validation(Required=false)]
            public string GameId { get; set; }

            [NameInMap("TagStatus")]
            [Validation(Required=false)]
            public long? TagStatus { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
