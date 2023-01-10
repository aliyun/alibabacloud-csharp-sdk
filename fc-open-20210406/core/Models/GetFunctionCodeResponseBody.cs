// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class GetFunctionCodeResponseBody : TeaModel {
        /// <summary>
        /// The CRC-64 value of the function code package.
        /// </summary>
        [NameInMap("checksum")]
        [Validation(Required=false)]
        public string Checksum { get; set; }

        /// <summary>
        /// The URL of the function code package.
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
