// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateConfigRequest : TeaModel {
        /// <summary>
        /// <para>The body of the request.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public LogtailConfig Body { get; set; }

    }

}
