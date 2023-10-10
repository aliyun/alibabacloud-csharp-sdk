// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class SwitchAdvancedMonitoringResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the advanced application monitoring feature is enabled. Valid values:
        /// 
        /// *   true: The advanced application monitoring feature is enabled.
        /// *   false: The advanced application monitoring feature is disabled.
        /// </summary>
        [NameInMap("AdvancedMonitoringEnabled")]
        [Validation(Required=false)]
        public bool? AdvancedMonitoringEnabled { get; set; }

        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
