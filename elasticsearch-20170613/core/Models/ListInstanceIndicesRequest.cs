// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListInstanceIndicesRequest : TeaModel {
        [NameInMap("all")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("isManaged")]
        [Validation(Required=false)]
        public bool? IsManaged { get; set; }

    }

}
