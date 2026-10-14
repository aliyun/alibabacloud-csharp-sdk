// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIDBClustersRequest : TeaModel {
        /// <summary>
        /// <para>The node type. You can specify multiple types separated by commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>vnode: managed by Kubernetes.</description></item>
        /// <item><description>container: logon-enabled container.</description></item>
        /// <item><description>maas: model service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vnode,container</para>
        /// </summary>
        [NameInMap("AiNodeType")]
        [Validation(Required=false)]
        public string AiNodeType { get; set; }

        /// <summary>
        /// <para>The description of the cluster. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <para>The cluster IDs. Separate multiple cluster IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-***************</para>
        /// </summary>
        [NameInMap("DBClusterIds")]
        [Validation(Required=false)]
        public string DBClusterIds { get; set; }

        /// <summary>
        /// <para>The status of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Creating</b>: The cluster is being created.</description></item>
        /// <item><description><b>Running</b>: The cluster is running.</description></item>
        /// <item><description><b>Deleting</b>: The cluster is being released.</description></item>
        /// <item><description><b>Rebooting</b>: The cluster is being restarted.</description></item>
        /// <item><description><b>DBNodeCreating</b>: Nodes are being increased.</description></item>
        /// <item><description><b>DBNodeDeleting</b>: Nodes are being deleted.</description></item>
        /// <item><description><b>ClassChanging</b>: The node specifications are being changed.</description></item>
        /// <item><description><b>NetAddressCreating</b>: The network connectivity is being created.</description></item>
        /// <item><description><b>NetAddressDeleting</b>: The network connectivity is being deleted.</description></item>
        /// <item><description><b>NetAddressModifying</b>: The network connectivity is being modified. </description></item>
        /// <item><description><b>Deleted</b>: The cluster is released.</description></item>
        /// <item><description><b>ClassChanged</b>: Resources are being revoked after you upgrade or decrease the quota.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DBClusterStatus")]
        [Validation(Required=false)]
        public string DBClusterStatus { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>.</para>
        /// <para>Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tag list.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeAIDBClustersRequestTag> Tag { get; set; }
        public class DescribeAIDBClustersRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can filter clusters by tag. You can specify up to 20 tag key-value pairs. The number n in each tag pair must be unique and must be a consecutive integer starting from 1. The value of Tag.n.Key is Tag.n.Value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value that corresponds to the tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testValueData</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
