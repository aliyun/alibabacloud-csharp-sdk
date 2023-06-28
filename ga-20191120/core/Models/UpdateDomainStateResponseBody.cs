// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateDomainStateResponseBody : TeaModel {
        /// <summary>
        /// The accelerated domain name.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ICP filing status of the accelerated domain name. Valid values:
        /// 
        /// *   **illegal:** The domain name is illegal.
        /// *   **inactive:** The domain name has not completed ICP filing.
        /// *   **active:** The domain name has a valid ICP number.
        /// *   **unknown:** The ICP filing status is unknown.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
