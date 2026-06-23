// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetReportResponseResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("outRequestNo")]
        [Validation(Required=false)]
        public string OutRequestNo { get; set; }

        [NameInMap("reportUrl")]
        [Validation(Required=false)]
        public string ReportUrl { get; set; }

    }

}
