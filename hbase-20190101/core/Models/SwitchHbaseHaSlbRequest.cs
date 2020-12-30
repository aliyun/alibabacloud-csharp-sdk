// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class SwitchHbaseHaSlbRequest : TeaModel {
        [NameInMap("BdsId")]
        [Validation(Required=false)]
        public string BdsId { get; set; }

        [NameInMap("HaId")]
        [Validation(Required=false)]
        public string HaId { get; set; }

        [NameInMap("HaTypes")]
        [Validation(Required=false)]
        public string HaTypes { get; set; }

        [NameInMap("HbaseType")]
        [Validation(Required=false)]
        public string HbaseType { get; set; }

    }

}
