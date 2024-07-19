// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceVersionRequest : TeaModel {
        /// <summary>
        /// The destination version of the service. The value must be of the INT type. The value must be greater than 0 and smaller than the current version of the service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

    }

}
