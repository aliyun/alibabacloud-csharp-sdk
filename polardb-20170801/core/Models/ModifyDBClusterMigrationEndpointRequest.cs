// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterMigrationEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/173433.html">DescribeDBClusters</a> operation to view information about all clusters in the destination region, including the cluster ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1w68hcomx235jaz</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The parameters for modifying the DTS task.</para>
        /// <para><b>dtsJobId</b>: The ID of the DTS task.</para>
        /// <para>endpoint: The endpoint to switch. Set the value to src for the source endpoint or <b>dst</b> for the destination endpoint.</para>
        /// <para><b>endpointInstanceId</b>: The ID of the cloud instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;dtsJobId\&quot;:\&quot;di4w4d9r12m38mb\&quot;,\&quot;endpoint\&quot;:\&quot;src\&quot;,\&quot;endpointInstanceId\&quot;:\&quot;pc-k2j96w169uhu868l8\&quot;}]</para>
        /// </summary>
        [NameInMap("MigrationConfig")]
        [Validation(Required=false)]
        public string MigrationConfig { get; set; }

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
