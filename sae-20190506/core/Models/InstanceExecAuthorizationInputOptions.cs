// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class InstanceExecAuthorizationInputOptions : TeaModel {
        [NameInMap("command")]
        [Validation(Required=false)]
        public List<string> Command { get; set; }

        [NameInMap("stderr")]
        [Validation(Required=false)]
        public bool? Stderr { get; set; }

        [NameInMap("stdin")]
        [Validation(Required=false)]
        public bool? Stdin { get; set; }

        [NameInMap("stdout")]
        [Validation(Required=false)]
        public bool? Stdout { get; set; }

        [NameInMap("tty")]
        [Validation(Required=false)]
        public bool? Tty { get; set; }

    }

}
