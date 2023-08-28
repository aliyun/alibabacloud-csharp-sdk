// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetOfficeEditUrlOption : TeaModel {
        [NameInMap("copy")]
        [Validation(Required=false)]
        public bool? Copy { get; set; }

        [NameInMap("print")]
        [Validation(Required=false)]
        public bool? Print { get; set; }

        [NameInMap("readonly")]
        [Validation(Required=false)]
        public bool? Readonly { get; set; }

    }

}
