// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class ChainPurposeListAli : TeaModel {
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public bool? Extend { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Item")]
        [Validation(Required=false)]
        public bool? Item { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("Purpose")]
        [Validation(Required=false)]
        public string Purpose { get; set; }

    }

}
