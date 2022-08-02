// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class JSONInput : TeaModel {
        [NameInMap("ParseJsonNumberAsString")]
        [Validation(Required=false)]
        public bool? ParseJsonNumberAsString { get; set; }

        [NameInMap("Range")]
        [Validation(Required=false)]
        public string Range { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
