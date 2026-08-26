// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIDBClustersRequest : TeaModel {
        /// <summary>
        /// <para>The node type. Multiple types are supported. Separate two values with a comma (,).</para>
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
        /// <para>The cluster description. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <para>The cluster ID. Separate multiple cluster IDs with commas (,).</para>
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
        /// <item><description><b>Creating</b>: being created.</description></item>
        /// <item><description><b>Running</b>: running.</description></item>
        /// <item><description><b>Deleting</b>: being released.</description></item>
        /// <item><description><b>Rebooting</b>: being restarted.</description></item>
        /// <item><description><b>DBNodeCreating</b>: a node is being added (increase).</description></item>
        /// <item><description><b>DBNodeDeleting</b>: a node is being deleted.</description></item>
        /// <item><description><b>ClassChanging</b>: node specifications are being changed.</description></item>
        /// <item><description><b>NetAddressCreating</b>: a network connectivity is being created.</description></item>
        /// <item><description><b>NetAddressDeleting</b>: a network connectivity is being deleted.</description></item>
        /// <item><description><b>NetAddressModifying</b>: a network connectivity is being modified. </description></item>
        /// <item><description><b>Deleted</b>: released.</description></item>
        /// </list>
        /// <list type="bullet">
        /// <item><description><b>ClassChanged</b>: resources are being revoked after a decrease the quota operation.</description></item>
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
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeAIDBClustersRequestTag> Tag { get; set; }
        public class DescribeAIDBClustersRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can filter the cluster list by tag. You can specify up to 20 tag pairs. The number n for each tag pair must be unique and must be a consecutive integer starting from 1. The value of Tag.n.Key corresponds to Tag.n.Value.</para>
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
