// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsEipAddressesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the EIP that you want to query. You can specify up to 50 EIP IDs. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-5q9uwkd9bznjpxz8hr6cirnjk</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// <para>The ID of the instance with which you want to associate the EIP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5t18quoohsrc3xkf86spmnu77</para>
        /// </summary>
        [NameInMap("AssociatedInstanceId")]
        [Validation(Required=false)]
        public string AssociatedInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the instance with which you want to associate the EIP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>EnsInstance</b>: ENS instance in a VPC</description></item>
        /// <item><description><b>SlbInstance</b>: Edge Load Balancer (ELB) instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SlbInstance</para>
        /// </summary>
        [NameInMap("AssociatedInstanceType")]
        [Validation(Required=false)]
        public string AssociatedInstanceType { get; set; }

        /// <summary>
        /// <para>The EIP that you want to query. You can specify up to 50 EIPs. Separate multiple EIPs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.1</para>
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
        /// <para>The ID of the Edge Node Service (ENS) node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu-telecom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether the EIP is a secondary EIP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Standby")]
        [Validation(Required=false)]
        public string Standby { get; set; }

    }

}
