// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsEipAddressesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the EIP instance to query. You can specify up to 50 EIP instance IDs separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-5q9uwkd9bznjpxz8hr6cirnjk</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// <para>The instance ID of the cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5t18quoohsrc3xkf86spmnu77</para>
        /// </summary>
        [NameInMap("AssociatedInstanceId")]
        [Validation(Required=false)]
        public string AssociatedInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the cloud service instance to associate. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>EnsInstance</b>: a VPC-type ENS instance.</para>
        /// </description></item>
        /// <item><description><para><b>SlbInstance</b>: a load balancing instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SlbInstance</para>
        /// </summary>
        [NameInMap("AssociatedInstanceType")]
        [Validation(Required=false)]
        public string AssociatedInstanceType { get; set; }

        /// <summary>
        /// <para>The IP address of the EIP to query. You can specify up to 50 EIP addresses separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>120.XXX.XXX.4</para>
        /// </summary>
        [NameInMap("EipAddress")]
        [Validation(Required=false)]
        public string EipAddress { get; set; }

        /// <summary>
        /// <para>The name of the EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("EipName")]
        [Validation(Required=false)]
        public string EipName { get; set; }

        /// <summary>
        /// <para>The ENS edge zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu-telecom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The array of ENS edge zone IDs. Array length: 1 to 100.</para>
        /// </summary>
        [NameInMap("EnsRegionIds")]
        [Validation(Required=false)]
        public List<string> EnsRegionIds { get; set; }

        /// <summary>
        /// <para>Specifies whether ICMP echo reply is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): enabled.</description></item>
        /// <item><description><b>false</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IcmpReplyEnabled")]
        [Validation(Required=false)]
        public bool? IcmpReplyEnabled { get; set; }

        /// <summary>
        /// <para>The lock type.</para>
        /// <list type="bullet">
        /// <item><description>financial: locked due to overdue payment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>financial</para>
        /// </summary>
        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        /// <summary>
        /// <para>The page number of the list. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. Maximum value: 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether the EIP is a standby EIP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: standby.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: not standby.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Standby")]
        [Validation(Required=false)]
        public string Standby { get; set; }

        /// <summary>
        /// <para>The status of the EIP. Valid values: Associating: being associated. Unassociating: being disassociated. InUse: allocated. Available: available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InUse</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
