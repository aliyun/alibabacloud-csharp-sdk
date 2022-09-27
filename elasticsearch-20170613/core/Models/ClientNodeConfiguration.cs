/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ClientNodeConfiguration : TeaModel {
        [NameInMap("amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        [NameInMap("disk")]
        [Validation(Required=false)]
        public long? Disk { get; set; }

        [NameInMap("diskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        [NameInMap("spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
