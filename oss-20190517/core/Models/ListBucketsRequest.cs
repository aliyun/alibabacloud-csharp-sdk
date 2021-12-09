// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ListBucketsRequest : TeaModel {
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("max-keys")]
        [Validation(Required=false)]
        public long? MaxKeys { get; set; }

        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

    }

}
