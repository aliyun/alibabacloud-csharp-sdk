// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetPrometheusGlobalViewRequest : TeaModel {
        /// <summary>
        /// The ID of the global aggregation instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GlobalViewClusterId")]
        [Validation(Required=false)]
        public string GlobalViewClusterId { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
