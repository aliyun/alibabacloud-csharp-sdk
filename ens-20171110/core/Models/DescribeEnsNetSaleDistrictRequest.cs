// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsNetSaleDistrictRequest : TeaModel {
        /// <summary>
        /// The region code.
        /// 
        /// *   If you do not specify this parameter, only nodes under the area level that is specified by NetLevelCode are queried.
        /// *   If you specify this parameter, only child nodes in the area that is specified by NetDistrictCode are queried.
        /// </summary>
        [NameInMap("NetDistrictCode")]
        [Validation(Required=false)]
        public string NetDistrictCode { get; set; }

        /// <summary>
        /// The network level. Valid values:
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
