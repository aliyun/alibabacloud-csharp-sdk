// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class ListGamesResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<ListGamesResponseBodyDataList> DataList { get; set; }
        public class ListGamesResponseBodyDataList : TeaModel {
            [NameInMap("GameId")]
            [Validation(Required=false)]
            public string GameId { get; set; }

            [NameInMap("GameName")]
            [Validation(Required=false)]
            public string GameName { get; set; }

            [NameInMap("PlatformType")]
            [Validation(Required=false)]
            public long? PlatformType { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
