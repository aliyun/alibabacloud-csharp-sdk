// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ConfirmVirusEventsRequest : TeaModel {
        [NameInMap("OperationAll")]
        [Validation(Required=false)]
        public int? OperationAll { get; set; }

        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        [NameInMap("OperationRange")]
        [Validation(Required=false)]
        public string OperationRange { get; set; }

    }

}
