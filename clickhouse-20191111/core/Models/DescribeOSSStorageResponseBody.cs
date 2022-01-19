// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeOSSStorageResponseBody : TeaModel {
        [NameInMap("ColdStorage")]
        [Validation(Required=false)]
        public bool? ColdStorage { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("StorageUsage")]
        [Validation(Required=false)]
        public string StorageUsage { get; set; }

    }

}
