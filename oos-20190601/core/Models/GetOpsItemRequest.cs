// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetOpsItemRequest : TeaModel {
        /// <summary>
        /// The O\\&M item ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OpsItemId")]
        [Validation(Required=false)]
        public string OpsItemId { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
