// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeOssBucketInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("IsArchive")]
        [Validation(Required=false)]
        public bool? IsArchive { get; set; }

        [NameInMap("IsBackToResource")]
        [Validation(Required=false)]
        public bool? IsBackToResource { get; set; }

        [NameInMap("IsFresh")]
        [Validation(Required=false)]
        public bool? IsFresh { get; set; }

        [NameInMap("IsSupportServerSideEncryption")]
        [Validation(Required=false)]
        public bool? IsSupportServerSideEncryption { get; set; }

        [NameInMap("IsVersioning")]
        [Validation(Required=false)]
        public bool? IsVersioning { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PollingInterval")]
        [Validation(Required=false)]
        public int? PollingInterval { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
