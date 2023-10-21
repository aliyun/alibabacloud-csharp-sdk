// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorDataListRequest : TeaModel {
        /// <summary>
        /// The timestamp that specifies the end of the time range to query.
        /// 
        /// Unit: seconds.
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public long? End { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// 
        /// For information about how to obtain the name of a namespace, see [DescribeHybridMonitorNamespaceList](~~428880~~).
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The interval at which monitoring data is collected.
        /// 
        /// Unit: seconds.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The name of the metric.
        /// 
        /// >  PromQL statements are supported.
        /// </summary>
        [NameInMap("PromSQL")]
        [Validation(Required=false)]
        public string PromSQL { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The timestamp that specifies the beginning of the time range to query.
        /// 
        /// Unit: seconds.
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

    }

}
