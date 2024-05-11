// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class AppendInstancesToPrometheusGlobalViewRequest : TeaModel {
        /// <summary>
        /// The list of global aggregation instances. The value is a JSON string.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public string Clusters { get; set; }

        /// <summary>
        /// The ID of the global aggregation instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GlobalViewClusterId")]
        [Validation(Required=false)]
        public string GlobalViewClusterId { get; set; }

        /// <summary>
        /// The name of the global aggregation instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

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
