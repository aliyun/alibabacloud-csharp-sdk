// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeGrantRulesToCenRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the CEN instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-nye53d7p3hzyu4****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The ID of the network instance to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-rj9gt5nll27onu7****</para>
        /// </summary>
        [NameInMap("ChildInstanceId")]
        [Validation(Required=false)]
        public string ChildInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that owns the network instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1250123456123456</para>
        /// </summary>
        [NameInMap("ChildInstanceOwnerId")]
        [Validation(Required=false)]
        public long? ChildInstanceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether IPv6 is enabled.</para>
        /// <ol>
        /// <item><description><para>This parameter applies only when <b>ProductType</b> is set to <b>VPC</b>.</para>
        /// </description></item>
        /// <item><description><para>Set to <b>true</b> to return only VPCs with IPv6 enabled, or <b>false</b> to return only those with IPv6 disabled. If you omit this parameter, the response is not filtered by the IPv6 status.</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnabledIpv6")]
        [Validation(Required=false)]
        public bool? EnabledIpv6 { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If you omit this parameter, all entries are returned. The <b>MaxResults</b> value in the response then indicates the total number of entries.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter, the response is paginated. The <b>MaxResults</b> value specifies the number of entries to return on each page. Valid values: <b>1</b> to <b>100</b>. The <b>MaxResults</b> value in the response indicates the number of entries on the current page. Setting <b>MaxResults</b> to <b>20</b> is recommended.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to retrieve the next page of results.</para>
        /// <list type="bullet">
        /// <item><description><para>Omit this parameter for the first request.</para>
        /// </description></item>
        /// <item><description><para>Set this parameter to the <b>NextToken</b> value from the previous response to retrieve the next page of results.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The type of the network instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>VPC</b>: a virtual private cloud (VPC).</para>
        /// </description></item>
        /// <item><description><para><b>VBR</b>: a virtual border router (VBR).</para>
        /// </description></item>
        /// <item><description><para><b>CCN</b>: a Cloud Connect Network (CCN) instance.</para>
        /// </description></item>
        /// <item><description><para><b>VPN</b>: an IPsec-VPN connection.</para>
        /// </description></item>
        /// <item><description><para><b>ECR</b>: an Express Connect router.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The ID of the region where the network instance is located.</para>
        /// <para>You can call the <a href="t2264556.xdita#"></a>operation to query region IDs.</para>
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
