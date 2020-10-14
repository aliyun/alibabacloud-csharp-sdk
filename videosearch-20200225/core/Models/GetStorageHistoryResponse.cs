// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videosearch20200225.Models
{
    public class GetStorageHistoryResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetStorageHistoryResponseData Data { get; set; }
        public class GetStorageHistoryResponseData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("Count")]
            [Validation(Required=true)]
            public long Count { get; set; }
            [NameInMap("List")]
            [Validation(Required=true)]
            public List<GetStorageHistoryResponseDataList> List { get; set; }
            public class GetStorageHistoryResponseDataList : TeaModel {
                public string VideoId { get; set; }
                public string Description { get; set; }
                public int? StorageType { get; set; }
                public int? StorageInfo { get; set; }
                public long ModifiedTime { get; set; }
                public string VideoUrl { get; set; }
            }
        };

    }

}
