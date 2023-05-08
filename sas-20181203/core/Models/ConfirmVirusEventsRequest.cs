// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ConfirmVirusEventsRequest : TeaModel {
        /// <summary>
        /// Confirms the alert events that you want to handle.
        /// </summary>
        [NameInMap("OperationAll")]
        [Validation(Required=false)]
        public int? OperationAll { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        /// <summary>
        /// The server on which you want to perform the alert events.
        /// </summary>
        [NameInMap("OperationRange")]
        [Validation(Required=false)]
        public string OperationRange { get; set; }

    }

}
