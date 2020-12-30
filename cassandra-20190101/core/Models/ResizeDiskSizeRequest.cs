// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class ResizeDiskSizeRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("DataCenterId")]
        [Validation(Required=false)]
        public string DataCenterId { get; set; }

        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

    }

}
