// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateConfigRequest : TeaModel {
        /// <summary>
        /// The body of the request.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public LogtailConfig Body { get; set; }

    }

}
