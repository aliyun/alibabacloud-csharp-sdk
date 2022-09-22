// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateFileSystemResponseBody : TeaModel {
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public List<string> AllocationId { get; set; }

        [NameInMap("BizStatusCode")]
        [Validation(Required=false)]
        public string BizStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UnAllocationId")]
        [Validation(Required=false)]
        public List<string> UnAllocationId { get; set; }

    }

}
