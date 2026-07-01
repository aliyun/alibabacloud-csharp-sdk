// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JobDiagnosisSymptoms : TeaModel {
        /// <summary>
        /// <para>Job resource diagnosis.</para>
        /// </summary>
        [NameInMap("autopilot")]
        [Validation(Required=false)]
        public JobDiagnosisSymptom Autopilot { get; set; }

        /// <summary>
        /// <para>Other namespace diagnosis.</para>
        /// </summary>
        [NameInMap("others")]
        [Validation(Required=false)]
        public List<JobDiagnosisSymptom> Others { get; set; }

        /// <summary>
        /// <para>Run diagnosis.</para>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public List<JobDiagnosisSymptom> Runtime { get; set; }

        /// <summary>
        /// <para>Startup procedure diagnosis.</para>
        /// </summary>
        [NameInMap("startup")]
        [Validation(Required=false)]
        public List<JobDiagnosisSymptom> Startup { get; set; }

        /// <summary>
        /// <para>Job status diagnosis.</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public List<JobDiagnosisSymptom> State { get; set; }

        /// <summary>
        /// <para>Underlying abnormal diagnosis.</para>
        /// </summary>
        [NameInMap("troubleshooting")]
        [Validation(Required=false)]
        public List<JobDiagnosisSymptom> Troubleshooting { get; set; }

    }

}
