// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class WebofficePermission : TeaModel {
        [NameInMap("Copy")]
        [Validation(Required=false)]
        public bool? Copy { get; set; }

        [NameInMap("Export")]
        [Validation(Required=false)]
        public bool? Export { get; set; }

        [NameInMap("History")]
        [Validation(Required=false)]
        public bool? History { get; set; }

        [NameInMap("Print")]
        [Validation(Required=false)]
        public bool? Print { get; set; }

        [NameInMap("Readonly")]
        [Validation(Required=false)]
        public bool? Readonly { get; set; }

        [NameInMap("Rename")]
        [Validation(Required=false)]
        public bool? Rename { get; set; }

    }

}
