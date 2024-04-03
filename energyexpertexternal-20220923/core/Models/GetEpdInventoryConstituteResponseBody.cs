// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetEpdInventoryConstituteResponseBody : TeaModel {
        /// <summary>
        /// List of environmental impact results.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<EpdInventoryConstituteItem> Data { get; set; }

        /// <summary>
        /// The ID of the request. The value is unique for each request. This facilitates subsequent troubleshooting.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
