// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class PutLogsRequest : TeaModel {
        /// <summary>
        /// <para>The compressed Protobuf data.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public LogGroup Body { get; set; }

    }

}
