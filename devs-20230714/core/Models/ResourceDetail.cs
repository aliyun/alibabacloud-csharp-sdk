// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ResourceDetail : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("attributeValues")]
        [Validation(Required=false)]
        public Dictionary<string, object> AttributeValues { get; set; }

        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
