// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GenerateResultResponseBody : TeaModel {
        /// <summary>
        /// The returned data. `true` indicates that the request is successful, `false` indicates that the request fails.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

        /// <summary>
        /// The ID of the request. The value is unique for each request. This facilitates subsequent troubleshooting.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
