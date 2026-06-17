// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBNodeDescriptionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to view information about all clusters in the destination region, including cluster IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-***************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the node. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>It cannot start with http\:// or https\://.</para>
        /// </description></item>
        /// <item><description><para>It must be 2 to 256 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NodeDescriptionTest</para>
        /// </summary>
        [NameInMap("DBNodeDescription")]
        [Validation(Required=false)]
        public string DBNodeDescription { get; set; }

        /// <summary>
        /// <para>The ID of the cluster node.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/185342.html">DescribeDBClusters</a> operation to view the details of all clusters that belong to your account, including node IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pi-*****************</para>
        /// </summary>
        [NameInMap("DBNodeId")]
        [Validation(Required=false)]
        public string DBNodeId { get; set; }

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
