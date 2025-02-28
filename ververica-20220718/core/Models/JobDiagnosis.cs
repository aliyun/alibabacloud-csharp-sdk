// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JobDiagnosis : TeaModel {
        [NameInMap("diagnoseId")]
        [Validation(Required=false)]
        public string DiagnoseId { get; set; }

        [NameInMap("diagnoseTime")]
        [Validation(Required=false)]
        public long? DiagnoseTime { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("riskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        [NameInMap("symptoms")]
        [Validation(Required=false)]
        public JobDiagnosisSymptoms Symptoms { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
