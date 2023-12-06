// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckSaleRequest : TeaModel {
        /// <summary>
        /// The region in which the Security Center instance is deployed. Valid values:
        /// 
        /// *   **cn-hangzhou:** inside China
        /// *   Global **ap-southeast-1:** outside China
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
