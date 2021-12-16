// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class PublishRoutineCodeRevisionShrinkRequest : TeaModel {
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public string EnvsShrink { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SelectCodeRevision")]
        [Validation(Required=false)]
        public string SelectCodeRevision { get; set; }

    }

}
