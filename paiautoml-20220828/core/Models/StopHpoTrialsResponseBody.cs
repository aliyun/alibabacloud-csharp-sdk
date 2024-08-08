// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiAutoML20220828.Models
{
    public class StopHpoTrialsResponseBody : TeaModel {
        /// <summary>
        /// Error code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Extra error information.
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public Dictionary<string, string> Detail { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The results of trial stop.
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public Dictionary<string, object> Results { get; set; }

    }

}
