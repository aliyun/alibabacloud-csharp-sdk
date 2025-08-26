// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DLSerdeInfo : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DeserializerClass")]
        [Validation(Required=false)]
        public string DeserializerClass { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        [NameInMap("SerdeType")]
        [Validation(Required=false)]
        public int? SerdeType { get; set; }

        [NameInMap("SerializationLib")]
        [Validation(Required=false)]
        public string SerializationLib { get; set; }

        [NameInMap("SerializerClass")]
        [Validation(Required=false)]
        public string SerializerClass { get; set; }

    }

}
