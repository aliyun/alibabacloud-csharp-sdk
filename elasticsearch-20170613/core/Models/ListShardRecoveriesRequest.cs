// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListShardRecoveriesRequest : TeaModel {
        [NameInMap("activeOnly")]
        [Validation(Required=false)]
        public bool? ActiveOnly { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
