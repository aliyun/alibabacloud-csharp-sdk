// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetNodeMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the queried metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DiskWriteRate</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The metric information of the nodes.</para>
        /// </summary>
        [NameInMap("NodesMetrics")]
        [Validation(Required=false)]
        public List<NodeMetric> NodesMetrics { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. Each resource group has a globally unique ID. You can use the resource group ID to retrieve the information about the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rgf0zhfqn1d4ity2</para>
        /// </summary>
        [NameInMap("ResourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

    }

}
