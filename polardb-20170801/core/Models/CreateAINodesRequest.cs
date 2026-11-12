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
        /// <para>You can call the <a href="https://api.aliyun.com/api/polardb/2017-08-01/DescribeAIDBClusters">DescribeAIDBClusters</a> operation to query the information about all clusters under your account, including the cluster ID.</para>
        /// </remarks>
        /// <remarks>
        /// <para>The AiNodeType of the target cluster must be vnode or container. The maas type is not supported. You can query the AiNodeType by calling DescribeAIDBClusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pm-xxxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The list of node information to add.</para>
        /// <remarks>
        /// <para>You must specify at least 1 and at most 100 DBNode elements when you call this operation. If you omit this parameter or pass an empty array, the InvalidNewNodeNum.Malformed error is returned.</para>
        /// </remarks>
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
