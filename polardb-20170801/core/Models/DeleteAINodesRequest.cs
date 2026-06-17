// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DeleteAINodesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://api.aliyun.com/api/polardb/2017-08-01/DescribeAIDBClusters">DescribeAIDBClusters</a> operation to view the cluster ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pm-xxxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The IDs of the nodes to delete.</para>
        /// </summary>
        [NameInMap("DBNodeId")]
        [Validation(Required=false)]
        public List<string> DBNodeId { get; set; }

    }

}
