// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JobDiagnosisSymptoms : TeaModel {
        [NameInMap("autopilot")]
        [Validation(Required=false)]
        public JobDiagnosisSymptom Autopilot { get; set; }

        [NameInMap("others")]
        [Validation(Required=false)]
        public List<JobDiagnosisSymptom> Others { get; set; }

        [NameInMap("runtime")]
        [Validation(Required=false)]
        public List<JobDiagnosisSymptom> Runtime { get; set; }

        [NameInMap("startup")]
        [Validation(Required=false)]
        public List<JobDiagnosisSymptom> Startup { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public List<JobDiagnosisSymptom> State { get; set; }

        [NameInMap("troubleshooting")]
        [Validation(Required=false)]
        public List<JobDiagnosisSymptom> Troubleshooting { get; set; }

    }

}
