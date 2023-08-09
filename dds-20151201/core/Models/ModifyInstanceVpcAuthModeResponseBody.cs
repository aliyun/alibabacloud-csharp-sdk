// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyInstanceVpcAuthModeResponseBody : TeaModel {
        /// <summary>
        /// Specifies whether to enable authentication to allow access within a VPC. Valid values:
        /// 
        /// *   **Open**: enables password-free access.
        /// *   **Close**: disables password-free access.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
