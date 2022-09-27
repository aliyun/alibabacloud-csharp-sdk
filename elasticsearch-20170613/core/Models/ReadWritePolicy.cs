// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ReadWritePolicy : TeaModel {
        [NameInMap("autoGeneratePk")]
        [Validation(Required=false)]
        public bool? AutoGeneratePk { get; set; }

        [NameInMap("writeHa")]
        [Validation(Required=false)]
        public bool? WriteHa { get; set; }

        [NameInMap("writePolicy")]
        [Validation(Required=false)]
        public string WritePolicy { get; set; }

    }

}
