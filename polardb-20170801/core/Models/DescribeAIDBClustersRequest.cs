// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIDBClustersRequest : TeaModel {
        /// <summary>
        /// <para>The node type. To specify multiple types, separate them with a comma. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>vnode</b>: a node managed by Kubernetes</para>
        /// </description></item>
        /// <item><description><para><b>container</b>: a container that you can log on to</para>
        /// </description></item>
        /// <item><description><para><b>maas</b>: model service</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vnode,container</para>
        /// </summary>
        [NameInMap("AiNodeType")]
        [Validation(Required=false)]
        public string AiNodeType { get; set; }

        /// <summary>
        /// <para>The cluster description. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <para>The cluster ID. To specify multiple clusters, separate their IDs with a comma.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-***************</para>
        /// </summary>
        [NameInMap("DBClusterIds")]
        [Validation(Required=false)]
        public string DBClusterIds { get; set; }

        /// <summary>
        /// <para>The cluster status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Creating</b>: The cluster is being created.</para>
        /// </description></item>
        /// <item><description><para><b>Running</b>: The cluster is running.</para>
        /// </description></item>
        /// <item><description><para><b>Deleting</b>: The cluster is being released.</para>
        /// </description></item>
        /// <item><description><para><b>Rebooting</b>: The cluster is restarting.</para>
        /// </description></item>
        /// <item><description><para><b>DBNodeCreating</b>: A node is being added.</para>
        /// </description></item>
        /// <item><description><para><b>DBNodeDeleting</b>: A node is being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>ClassChanging</b>: The node specifications are being changed.</para>
        /// </description></item>
        /// <item><description><para><b>NetAddressCreating</b>: A network connection is being created.</para>
        /// </description></item>
        /// <item><description><para><b>NetAddressDeleting</b>: A network connection is being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>NetAddressModifying</b>: A network connection is being modified.</para>
        /// </description></item>
        /// <item><description><para><b>Deleted</b>: The cluster is released.</para>
        /// </description></item>
        /// </list>
        /// <list type="bullet">
        /// <item><description><b>ClassChanged</b>: Resources are being reclaimed after the upgrade or downgrade.</description></item>
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
        /// <para>The number of entries per page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>.</para>
        /// <para>Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Postpaid</b>: pay-as-you-go</para>
        /// </description></item>
        /// <item><description><para><b>Prepaid</b>: subscription</para>
        /// </description></item>
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
        /// <para>A list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeAIDBClustersRequestTag> Tag { get; set; }
        public class DescribeAIDBClustersRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. Use this parameter with <c>Tag.n.Value</c> to filter clusters by tag. You can specify up to 20 tag pairs. The index n must be a unique, consecutive integer starting from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
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
