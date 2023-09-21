// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateServiceTrailRequest : TeaModel {
        /// <summary>
        /// The region ID of the instance. Valid values:
        /// 
        /// *   **cn-hangzhou**: International
        /// *   **ap-southeast-1**: Singapore
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
