// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateClusterDiagnosisResponseBody : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The diagnostic ID.
        /// </summary>
        [NameInMap("diagnosis_id")]
        [Validation(Required=false)]
        public string DiagnosisId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
