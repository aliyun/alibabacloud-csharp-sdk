// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class UpdateProductVersionRequest : TeaModel {
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("continuousIntegration")]
        [Validation(Required=false)]
        public bool? ContinuousIntegration { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("entry")]
        [Validation(Required=false)]
        public string Entry { get; set; }

        [NameInMap("timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
