// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class RecommendRequest : TeaModel {
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("Imei")]
        [Validation(Required=false)]
        public string Imei { get; set; }

        [NameInMap("ReturnCount")]
        [Validation(Required=false)]
        public int? ReturnCount { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public string Items { get; set; }

    }

}
