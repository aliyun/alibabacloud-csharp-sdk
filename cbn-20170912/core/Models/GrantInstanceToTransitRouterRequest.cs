// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class GrantInstanceToTransitRouterRequest : TeaModel {
        /// <summary>
        /// <para>Enter the ID of the Cloud Enterprise Network (CEN) instance to which the transit router belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-44m0p68spvlrqq****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the CEN instance belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1250123456123456</para>
        /// </summary>
        [NameInMap("CenOwnerId")]
        [Validation(Required=false)]
        public long? CenOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the network instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1h8vbrbcgohcju5****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of network instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: VPC</description></item>
        /// <item><description><b>ExpressConnect</b>: VBR</description></item>
        /// <item><description><b>VPN</b>: IPsec-VPN connection</description></item>
        /// <item><description><b>ECR</b>: ECR</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The entity that pays the fees of the network instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayByCenOwner</b>: the Alibaba Cloud account that owns the CEN instance.</description></item>
        /// <item><description><b>PayByResourceOwner</b>: the Alibaba Cloud account that owns the network instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByCenOwner</para>
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
        /// <para>The ID of the region where the network instance is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to query the most recent region list.</para>
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
