// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class FullDataType : TeaModel {
        [NameInMap("element")]
        [Validation(Required=false)]
        public FullDataType Element { get; set; }

        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<DataField> Fields { get; set; }

        [NameInMap("key")]
        [Validation(Required=false)]
        public FullDataType Key { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public FullDataType Value { get; set; }

    }

}
