// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddInstallCodeResponseBody : TeaModel {
        /// <summary>
        /// The validity period of the installation command. The value is a 13-digit timestamp.
        /// 
        /// >  The installation command is valid only within the validity period. An expired installation command cannot be used to install the Security Center agent.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
