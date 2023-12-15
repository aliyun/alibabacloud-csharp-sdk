// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20181015.Models
{
    public class GrafanaWorkspaceIniProperty : TeaModel {
        [NameInMap("defaultValue")]
        [Validation(Required=false)]
        public string DefaultValue { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("example")]
        [Validation(Required=false)]
        public string Example { get; set; }

        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("secret")]
        [Validation(Required=false)]
        public bool? Secret { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
