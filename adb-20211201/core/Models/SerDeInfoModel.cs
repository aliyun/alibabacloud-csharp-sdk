// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class SerDeInfoModel : TeaModel {
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Parameters { get; set; }

        [NameInMap("SerDeId")]
        [Validation(Required=false)]
        public long? SerDeId { get; set; }

        [NameInMap("SerializationLib")]
        [Validation(Required=false)]
        public string SerializationLib { get; set; }

    }

}
