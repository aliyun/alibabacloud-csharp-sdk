// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetFlowLogServiceStatusResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the flow log feature is enabled. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no You can call the [OpenFlowLogService](~~449637~~) operation to enable the flow log feature.
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
