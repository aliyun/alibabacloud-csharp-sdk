// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ListClassesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The commodity code of the instances.</para>
        /// <list type="bullet">
        /// <item><description><b>bards_intl</b>: The instances are pay-as-you-go primary instances.</description></item>
        /// <item><description><b>rds_intl</b>: The instances are subscription primary instances.</description></item>
        /// <item><description><b>rords_intl</b>: The instances are pay-as-you-go read-only instances.</description></item>
        /// <item><description><b>rds_rordspre_public_intl</b>: The instances are subscription read-only instances.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bards_intl</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <remarks>
        /// <para> If you set the <b>CommodityCode</b> parameter to the commodity code of read-only instances, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The database engine of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>SQLServer</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>MariaDB</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The type of order that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BUY</b>: specifies the query orders that are used to purchase instances.</description></item>
        /// <item><description><b>UPGRADE</b>: specifies the query orders that are used to change the specifications of instances.</description></item>
        /// <item><description><b>RENEW</b>: specifies the query orders that are used to renew instances.</description></item>
        /// <item><description><b>CONVERT</b>: specifies the query orders that are used to change the billing methods of instances.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUY</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the most recent region list.</para>
        /// <remarks>
        /// <para> If you are using an Alibaba Cloud account on the International site (alibabacloud.com), you must specify this parameter.</para>
        /// </remarks>
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

    }

}
