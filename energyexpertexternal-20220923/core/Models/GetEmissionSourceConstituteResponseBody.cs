// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetEmissionSourceConstituteResponseBody : TeaModel {
        /// <summary>
        /// Response parameters
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ConstituteItem> Data { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
