// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class RecalculateCarbonEmissionResponseBody : TeaModel {
        /// <summary>
        /// The returned data. A value of true indicates that the request is successful. A value of false indicates that the request fails.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
