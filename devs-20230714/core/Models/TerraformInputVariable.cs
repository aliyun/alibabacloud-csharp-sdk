// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class TerraformInputVariable : TeaModel {
        [NameInMap("defaultJson")]
        [Validation(Required=false)]
        public string DefaultJson { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("nullable")]
        [Validation(Required=false)]
        public bool? Nullable { get; set; }

        [NameInMap("sensitive")]
        [Validation(Required=false)]
        public bool? Sensitive { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
