// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class XpackRelateDBRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("DbClusterIds")]
        [Validation(Required=false)]
        public string DbClusterIds { get; set; }

        [NameInMap("RelateDbType")]
        [Validation(Required=false)]
        public string RelateDbType { get; set; }

    }

}
