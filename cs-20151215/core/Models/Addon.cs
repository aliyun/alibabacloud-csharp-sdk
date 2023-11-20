/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class Addon : TeaModel {
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
