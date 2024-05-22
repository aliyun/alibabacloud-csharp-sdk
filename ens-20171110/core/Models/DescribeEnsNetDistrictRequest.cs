// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsNetDistrictRequest : TeaModel {
        /// <summary>
        /// The code of the region.
        /// 
        /// If you do not specify this parameter, only nodes in the regions of the level that is specified by the NetLevelCode parameter are queried.
        /// 
        /// If you specify this parameter, only nodes in the regions of the level that is specified by this parameter are queried.
        /// </summary>
        [NameInMap("NetDistrictCode")]
        [Validation(Required=false)]
        public string NetDistrictCode { get; set; }

        /// <summary>
        /// The level of the region.
        /// 
        /// *   **Big**: area
        /// *   **Middle**: province
        /// *   **Small**: city
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NetLevelCode")]
        [Validation(Required=false)]
        public string NetLevelCode { get; set; }

    }

}
