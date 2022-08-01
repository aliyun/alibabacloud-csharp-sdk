// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateCheckPointRequest : TeaModel {
        [NameInMap("checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        [NameInMap("shard")]
        [Validation(Required=false)]
        public int? Shard { get; set; }

        [NameInMap("consumer")]
        [Validation(Required=false)]
        public string Consumer { get; set; }

        [NameInMap("forceSuccess")]
        [Validation(Required=false)]
        public bool? ForceSuccess { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
