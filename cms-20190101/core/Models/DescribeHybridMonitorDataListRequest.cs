// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorDataListRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query.
        /// 
        /// Unit: seconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public long? End { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// 
        /// For more information about how to query the names of namespaces, see [DescribeHybridMonitorNamespaceList](https://help.aliyun.com/document_detail/428880.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The statistical period of the monitoring data.
        /// 
        /// Unit: seconds.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The metric name.
        /// 
        /// >  PromQL statements are supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PromSQL")]
        [Validation(Required=false)]
        public string PromSQL { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The start of the time range to query.
        /// 
        /// Unit: seconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

    }

}
