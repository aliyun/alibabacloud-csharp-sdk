// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20200324.Models
{
    public class TransferResellerToUserRequest : TeaModel {
        [NameInMap("EmpId")]
        [Validation(Required=false)]
        public string EmpId { get; set; }

        [NameInMap("RealName")]
        [Validation(Required=false)]
        public string RealName { get; set; }

        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public string SiteId { get; set; }

        [NameInMap("TransferUid")]
        [Validation(Required=false)]
        public long? TransferUid { get; set; }

    }

}
