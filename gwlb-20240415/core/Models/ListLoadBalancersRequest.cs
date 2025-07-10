// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gwlb20240415.Models
{
    public class ListLoadBalancersRequest : TeaModel {
        /// <summary>
        /// <para>The IP version of the NLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Ipv4</b></description></item>
        /// </list>
        /// <para>Enumeration values:</para>
        /// <list type="bullet">
        /// <item><description>IPv4: IPv4</description></item>
        /// <item><description>DualStack: dual-stack</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// <para>The business status of the GWLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: running as expected</description></item>
        /// <item><description><b>FinancialLocked</b>: locked due to overdue payments</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("LoadBalancerBusinessStatus")]
        [Validation(Required=false)]
        public string LoadBalancerBusinessStatus { get; set; }

        /// <summary>
        /// <para>The GWLB instance IDs. You can query at most 20 GWLB instances in each call.</para>
        /// </summary>
        [NameInMap("LoadBalancerIds")]
        [Validation(Required=false)]
        public List<string> LoadBalancerIds { get; set; }

        /// <summary>
        /// <para>The GWLB instance names. You can specify at most 20 GWLB instance names in each call.</para>
        /// </summary>
        [NameInMap("LoadBalancerNames")]
        [Validation(Required=false)]
        public List<string> LoadBalancerNames { get; set; }

        /// <summary>
        /// <para>The GWLB instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Active</b>: The GWLB instance is running.</description></item>
        /// <item><description><b>Inactive</b>: The GWLB instance is disabled. Listeners of GWLB instances in the Inactive state do not forward traffic.</description></item>
        /// <item><description><b>Provisioning</b>: The GWLB instance is being created.</description></item>
        /// <item><description><b>Configuring</b>: The GWLB instance is being modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 1000. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value of <b>NextToken</b> is returned, the value indicates the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WyJyb290IiwibiIsIm4iLDEsMCwxNjg1MDY1NTgyNzYwLCI2NDcwMGY2ZTc2Zjc0MWFiZGEyZjQyNzc4ZDk2MmJkOTk3ZGZmM2Nm****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2htf5qsyrn****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The number of entries to be skipped in the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Skip")]
        [Validation(Required=false)]
        public int? Skip { get; set; }

        /// <summary>
        /// <para>The tags. You can specify at most 20 tags in each call.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListLoadBalancersRequestTag> Tag { get; set; }
        public class ListLoadBalancersRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 128 characters in length. The tag key cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testTagKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value The tag value can be up to 256 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testTagValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies the traffic processing mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LoadBalance</b>: load balancing mode. GWLB continues to forward traffic to backend servers.</description></item>
        /// <item><description><b>ByPass</b>: bypass mode. GWLB directly returns traffic to the GWLB endpoint without forwarding it to the backend servers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LoadBalance</para>
        /// </summary>
        [NameInMap("TrafficMode")]
        [Validation(Required=false)]
        public string TrafficMode { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) IDs. You can query at most 20 IDs in each call.</para>
        /// </summary>
        [NameInMap("VpcIds")]
        [Validation(Required=false)]
        public List<string> VpcIds { get; set; }

        /// <summary>
        /// <para>The zone IDs. You can query at most 20 zone IDs in each call.</para>
        /// </summary>
        [NameInMap("ZoneIds")]
        [Validation(Required=false)]
        public List<string> ZoneIds { get; set; }

    }

}
