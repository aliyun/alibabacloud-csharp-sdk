// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeGrantRulesToCenRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the CEN instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-nye53d7p3hzyu4****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The instance ID of the network instance to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-rj9gt5nll27onu7****</para>
        /// </summary>
        [NameInMap("ChildInstanceId")]
        [Validation(Required=false)]
        public string ChildInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the network instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1250123456123456</para>
        /// </summary>
        [NameInMap("ChildInstanceOwnerId")]
        [Validation(Required=false)]
        public long? ChildInstanceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether IPv6 is enabled:</para>
        /// <ol>
        /// <item><description>This parameter takes effect only when ProductType is set to &quot;VPC&quot;.</description></item>
        /// <item><description>A value of true indicates that IPv6 is enabled. A value of false indicates that IPv6 is not enabled. If this parameter is left empty, results are not filtered by this parameter.</description></item>
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
        /// <item><description>If you do not specify the <b>MaxResults</b> parameter, pagination is not required. The <b>MaxResults</b> value in the response indicates the total number of entries.</description></item>
        /// <item><description>If you specify the <b>MaxResults</b> parameter, pagination is required. The <b>MaxResults</b> value specifies the number of entries to return per page. Valid values: <b>1</b> to <b>100</b>. The <b>MaxResults</b> value in the response indicates the number of entries in the current page. We recommend that you set <b>MaxResults</b> to <b>20</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first request or if no subsequent query exists.</description></item>
        /// <item><description>If a subsequent query exists, set this parameter to the <b>NextToken</b> value returned by the previous API call.</description></item>
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
        /// <item><description><para><b>VPC</b>: virtual private cloud (VPC).</para>
        /// </description></item>
        /// <item><description><para><b>VBR</b>: virtual border router (VBR).</para>
        /// </description></item>
        /// <item><description><para><b>CCN</b>: Cloud Connect Network (CCN).</para>
        /// </description></item>
        /// <item><description><para><b>VPN</b>: IPsec connection.</para>
        /// </description></item>
        /// <item><description><para><b>ECR</b>: Express Connect Router (ECR).</para>
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
        /// <para>The region ID of the network instance.                   </para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to query region IDs.</para>
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
