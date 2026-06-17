// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateAINodesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://api.aliyun.com/api/polardb/2017-08-01/DescribeAIDBClusters">DescribeAIDBClusters</a> operation to query information about all clusters in your account, including cluster IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pm-xxxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The information about the nodes to add.</para>
        /// </summary>
        [NameInMap("DBNodes")]
        [Validation(Required=false)]
        public List<CreateAINodesRequestDBNodes> DBNodes { get; set; }
        public class CreateAINodesRequestDBNodes : TeaModel {
            /// <summary>
            /// <para>The node specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polar.mysql.g4.xlarge.gu10</para>
            /// </summary>
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

        }

    }

}
