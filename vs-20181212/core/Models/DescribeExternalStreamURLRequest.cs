// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeExternalStreamURLRequest : TeaModel {
        [NameInMap("Kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        [NameInMap("TxId")]
        [Validation(Required=false)]
        public string TxId { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
