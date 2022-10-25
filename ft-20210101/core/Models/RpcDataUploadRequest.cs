// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ft20210101.Models
{
    public class RpcDataUploadRequest : TeaModel {
        [NameInMap("largeParam")]
        [Validation(Required=false)]
        public string LargeParam { get; set; }

        [NameInMap("query1")]
        [Validation(Required=false)]
        public string Query1 { get; set; }

        [NameInMap("query2")]
        [Validation(Required=false)]
        public long? Query2 { get; set; }

    }

}
