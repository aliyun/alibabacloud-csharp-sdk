// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeAvailableResourceRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh-CN</b>: Chinese. This is the default value.</description></item>
        /// <item><description><b>en-US</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Redis</b>: Redis engine</description></item>
        /// <item><description><b>Memcache</b>: Memcache engine</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Redis</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b> (default): subscription</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when <b>OrderType</b> is set to <b>UPGRADE</b> or <b>DOWNGRADE</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The product series. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>professional</b>: Professional Edition. This edition supports the standalone, primary/secondary, read/write splitting, and cluster architectures, and provides high scalability.
        ///  &lt;props=&quot;china&quot;&gt;</description></item>
        /// <item><description><b>economical</b>: Economical Edition. This edition supports only the primary/secondary architecture and is cost-effective. For more information, see <a href="https://help.aliyun.com/document_detail/2489678.html">YiTian RDS instances</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>professional</para>
        /// </summary>
        [NameInMap("InstanceScene")]
        [Validation(Required=false)]
        public string InstanceScene { get; set; }

        /// <summary>
        /// <para>The data node ID. You can call the <a href="https://help.aliyun.com/document_detail/473786.html">DescribeLogicInstanceTopology</a> operation to obtain the data node ID. For the obtained data node ID, you must remove the number sign (<c>#</c>) and the content that follows it. For example, retain only r-bp10noxlhcoim2****-db-0.</para>
        /// <remarks>
        /// <para>Before you specify this parameter, you must also specify the <b>InstanceId</b> parameter, and the instance must use the cluster or read/write splitting architecture.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****-db-0</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The order type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BUY</b> (default): new purchase</description></item>
        /// <item><description><b>UPGRADE</b>: upgrade instance type</description></item>
        /// <item><description><b>DOWNGRADE</b>: downgrade instance type</description></item>
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
        /// <para>The product type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Local</b> (default): Redis Community Edition instance (classic architecture) or memory-optimized instance (classic architecture).</description></item>
        /// <item><description><b>Tair_rdb</b>: memory-optimized instance (cloud-native architecture).</description></item>
        /// <item><description><b>Tair_scm</b>: persistent memory-optimized instance.</description></item>
        /// <item><description><b>Tair_essd</b>: disk-optimized instance.</description></item>
        /// <item><description><b>OnECS</b>: Redis Community Edition instance (cloud-native architecture).<remarks>
        /// <para>The default value is Local. If you want to query cloud disk resources, you must specify the product type that corresponds to the required cloud disk resources.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Local</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. You can invoke the <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> operation to obtain the resource group ID.</para>
        /// <remarks>
        /// <para>You can also obtain the resource group ID in the console. For related operations, see <a href="https://help.aliyun.com/document_detail/151181.html">View the basic information of a resource group</a>.</para>
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
        /// <para>The zone ID. You can call the <a href="https://help.aliyun.com/document_detail/473764.html">DescribeZones</a> operation to query the zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
