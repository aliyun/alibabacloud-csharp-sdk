// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class SwitchNetworkResponseBody : TeaModel {
        /// <summary>
        /// Switches the network type of an ApsaraDB for Redis instance from classic network to Virtual Private Cloud (VPC).
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Specifies whether to retain the original endpoint for the classic network after you switch the instance from classic network to VPC. Valid values:
        /// 
        /// *   **True**: retains the original endpoint.
        /// *   **False**: does not retain the original endpoint. This is the default value.
        /// 
        /// >  This parameter can be used only when the network type of the instance is classic network.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
