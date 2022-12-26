// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateWebLockFileEventsRequest : TeaModel {
        [NameInMap("DealAll")]
        [Validation(Required=false)]
        public int? DealAll { get; set; }

        [NameInMap("EventIds")]
        [Validation(Required=false)]
        public List<long?> EventIds { get; set; }

        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

    }

}
