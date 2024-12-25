// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class ModifyLoadBalancerInternetSpecRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically pay the subscription fee of the Internet-facing CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables automatic payments. This is the default value.</description></item>
        /// <item><description><b>false</b>: disables automatic payment. You must complete the payment in Order Center.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth of the Internet-facing CLB instance that uses the pay-by-bandwidth metering method. Unit: Mbit/s.</para>
        /// <para>Valid values: <b>1 to 5000</b>. The maximum bandwidth varies based on the region where the CLB instance is created.****</para>
        /// <remarks>
        /// <para> You do not need to specify this parameter if you set <b>InternetChargeType</b> to <b>paybytraffic</b> (pay-by-data-transfer).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The metering method of the Internet-facing CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>paybybandwidth</b>: pay-by-bandwidth</description></item>
        /// <item><description><b>paybytraffic</b>: pay-by-data-transfer</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>paybytraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the CLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1b6c719dfa08ex******</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the CLB instance is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/27584.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
