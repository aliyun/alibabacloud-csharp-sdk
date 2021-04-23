// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeBoardsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Boards")]
        [Validation(Required=false)]
        public List<DescribeBoardsResponseBodyBoards> Boards { get; set; }
        public class DescribeBoardsResponseBodyBoards : TeaModel {
            [NameInMap("BoardId")]
            [Validation(Required=false)]
            public string BoardId { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public int? State { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

    }

}
