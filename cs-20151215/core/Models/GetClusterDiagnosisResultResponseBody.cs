// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetClusterDiagnosisResultResponseBody : TeaModel {
        /// <summary>
        /// The code that indicates the diagnostic result. Valid values:
        /// 
        /// *   0: the diagnostic is completed.
        /// *   1: the diagnostic failed.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The time when the diagnostic is initiated.
        /// </summary>
        [NameInMap("created")]
        [Validation(Required=false)]
        public string Created { get; set; }

        /// <summary>
        /// The diagnostic ID.
        /// </summary>
        [NameInMap("diagnosis_id")]
        [Validation(Required=false)]
        public string DiagnosisId { get; set; }

        /// <summary>
        /// The time when the diagnostic is completed.
        /// </summary>
        [NameInMap("finished")]
        [Validation(Required=false)]
        public string Finished { get; set; }

        /// <summary>
        /// The diagnostic status information.
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The diagnostic result.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// The status of the diagnostic. Valid values:
        /// 
        /// *   0: The diagnostic is created.
        /// *   1: The diagnostic is running.
        /// *   2: The diagnostic is completed.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// The diagnostic object.
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// The type of the diagnostic.
        /// 
        /// Valid values:
        /// 
        /// *   node
        /// *   ingress
        /// *   cluster
        /// *   memory
        /// *   pod
        /// *   service
        /// *   network
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
