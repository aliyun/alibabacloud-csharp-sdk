// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetClusterDiagnosisResultResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("created")]
        [Validation(Required=false)]
        public string Created { get; set; }

        [NameInMap("diagnosis_id")]
        [Validation(Required=false)]
        public string DiagnosisId { get; set; }

        [NameInMap("finished")]
        [Validation(Required=false)]
        public string Finished { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        [NameInMap("target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
