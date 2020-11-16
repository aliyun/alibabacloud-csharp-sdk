// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeBoardsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Boards")]
        [Validation(Required=true)]
        public List<DescribeBoardsResponseBoards> Boards { get; set; }
        public class DescribeBoardsResponseBoards : TeaModel {
            [NameInMap("BoardId")]
            [Validation(Required=true)]
            public string BoardId { get; set; }

            [NameInMap("Topic")]
            [Validation(Required=true)]
            public string Topic { get; set; }

            [NameInMap("State")]
            [Validation(Required=true)]
            public int? State { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=true)]
            public string UserId { get; set; }

        }

    }

}
