// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class RemoveSourcesFromPrometheusGlobalViewRequest : TeaModel {
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

        /// <summary>
        /// The list of custom data sources. You can specify multiple data sources and separate them with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceNames")]
        [Validation(Required=false)]
        public string SourceNames { get; set; }

    }

}
