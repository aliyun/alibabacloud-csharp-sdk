// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetMultiAccountResourceCenterServiceStatusResponseBody : TeaModel {
        /// <summary>
        /// The initialization status of the feature. Valid values:
        /// 
        /// *   Pending: The feature is being initialized.
        /// *   Finished: The feature is initialized.
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
        /// The status of the feature. Valid values:
        /// 
        /// *   Enabled: The feature is enabled.
        /// *   Disabled: The feature is disabled.
        /// </summary>
        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

    }

}
