// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeAvailableResourceRequest : TeaModel {
        /// <summary>
        /// <para>The display language of the response. Default value: zh-CN. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh-CN</b>: Chinese</description></item>
        /// <item><description><b>en-US</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The category of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Redis</b></description></item>
        /// <item><description><b>Memcache</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Redis</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go</description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <remarks>
        /// <para>This parameter is available and required only if the <b>OrderType</b> parameter is set to <b>UPGRADE</b> or <b>DOWNGRADE</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The edition of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>professional</b>: Standard Edition. This edition supports the standalone, master-replica, read /write splitting, and cluster architectures and provides high scalability.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>professional</para>
        /// </summary>
        [NameInMap("InstanceScene")]
        [Validation(Required=false)]
        public string InstanceScene { get; set; }

        /// <summary>
        /// <para>The ID of the data node for which you want to query available resources that can be created. You can call the <a href="https://help.aliyun.com/document_detail/94665.html">DescribeLogicInstanceTopology</a> operation to query the ID of the data node. Remove the number sign (<c>#</c>) and the content that follows the number sign. For example, retain only r-bp10noxlhcoim2\<em>\</em>\<em>\</em>-db-0.</para>
        /// <remarks>
        /// <para>Before you specify this parameter, you must set the <b>InstanceId</b> parameter to the ID of an instance that uses the cluster or read/write splitting architecture.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****-db-0</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The type of the order. Default value: BUY. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BUY</b>: orders that are newly created</description></item>
        /// <item><description><b>UPGRADE</b>: orders that are used to upgrade instances</description></item>
        /// <item><description><b>DOWNGRADE</b>: orders that are used to downgrade instances</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BUY</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The series of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Local</b>: classic ApsaraDB for Redis Community Edition instance or classic ApsaraDB for Redis Enhanced Edition (Tair) DRAM-based instance</description></item>
        /// <item><description><b>Tair_rdb</b>: cloud-native ApsaraDB for Redis Enhanced Edition (Tair) DRAM-based instance</description></item>
        /// <item><description><b>Tair_scm</b>: ApsaraDB for Redis Enhanced Edition (Tair) persistent memory-optimized instance</description></item>
        /// <item><description><b>Tair_essd</b>: ESSD-based instance</description></item>
        /// <item><description><b>OnECS</b>: cloud-native ApsaraDB for Redis Community Edition instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Local</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/61012.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs. You can call the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to query the IDs of resource groups.</para>
        /// <remarks>
        /// <para>You can also query the IDs of resource groups in the Resource Management console. For more information, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information about a resource group</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyiu4e******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/94527.html">DescribeZones</a> operation to query the most recent zone list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
