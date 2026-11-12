// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDbClusterAttributeZonalRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the edge cluster. You can first call the DescribeDBClustersZonal operation to list available edge clusters, and then use the returned DBClusterId to query the properties. The IDs of common clusters are not applicable. If you do not have an edge cluster, you can call the CreateDBCluster operation and specify CloudProvider=ENS and EnsRegionId to create one. If you do not have an edge cluster, you can call the CreateDBCluster operation and specify the CloudProvider=ENS and EnsRegionId parameters to create one.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve AI-related node information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI</para>
        /// </summary>
        [NameInMap("DescribeType")]
        [Validation(Required=false)]
        public string DescribeType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
