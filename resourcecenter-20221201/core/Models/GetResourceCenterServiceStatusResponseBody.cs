// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetResourceCenterServiceStatusResponseBody : TeaModel {
        /// <summary>
        /// The initialization status of the service. Valid values:
        /// 
        /// *   Pending: The service being initialized.
        /// *   Finished: The service is initialized.
        /// </summary>
        [NameInMap("InitialStatus")]
        [Validation(Required=false)]
        public string InitialStatus { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the service. Valid values:
        /// 
        /// *   Enabled: The service is activated.
        /// *   Disabled: The service is deactivated.
        /// </summary>
        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

    }

}
