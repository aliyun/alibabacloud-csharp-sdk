// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetCheckPointResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=true)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=true)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public List<GetCheckPointResponseBody> Body { get; set; }
        public class GetCheckPointResponseBody : TeaModel {
            /// <summary>
            /// Shard ID。
            /// </summary>
            [NameInMap("shard")]
            [Validation(Required=false)]
            public int? Shard { get; set; }

            [NameInMap("checkpoint")]
            [Validation(Required=false)]
            public string Checkpoint { get; set; }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            [NameInMap("consumer")]
            [Validation(Required=false)]
            public string Consumer { get; set; }

        }

    }

}
