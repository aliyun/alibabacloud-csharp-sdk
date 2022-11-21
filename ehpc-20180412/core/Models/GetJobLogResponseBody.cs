// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetJobLogResponseBody : TeaModel {
        [NameInMap("ErrorLog")]
        [Validation(Required=false)]
        public string ErrorLog { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("OutputLog")]
        [Validation(Required=false)]
        public string OutputLog { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
