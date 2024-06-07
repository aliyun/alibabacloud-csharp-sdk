// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class CreateManualDagResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ReturnCode")]
        [Validation(Required=false)]
        public string ReturnCode { get; set; }

        [NameInMap("ReturnErrorSolution")]
        [Validation(Required=false)]
        public string ReturnErrorSolution { get; set; }

        [NameInMap("ReturnMessage")]
        [Validation(Required=false)]
        public string ReturnMessage { get; set; }

        [NameInMap("ReturnValue")]
        [Validation(Required=false)]
        public long? ReturnValue { get; set; }

    }

}
