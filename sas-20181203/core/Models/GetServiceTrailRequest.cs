// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetServiceTrailRequest : TeaModel {
        /// <summary>
        /// The ID of the region in which the instance resides. Valid value:
        /// 
        /// *   **cn-hangzhou**: center.
        /// *   **ap-southeast-1**: Singapore.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
