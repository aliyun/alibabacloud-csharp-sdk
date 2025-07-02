// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamResourceCidrsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The list of resources in the IPAM pool.</para>
        /// </summary>
        [NameInMap("IpamResourceCidrs")]
        [Validation(Required=false)]
        public List<ListIpamResourceCidrsResponseBodyIpamResourceCidrs> IpamResourceCidrs { get; set; }
        public class ListIpamResourceCidrsResponseBodyIpamResourceCidrs : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>132193271328****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The CIDR block of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.0/32</para>
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// <para>The compliance status of the resource.</para>
            /// <list type="bullet">
            /// <item><description><b>Compliant</b></description></item>
            /// <item><description><b>Noncompliant</b></description></item>
            /// <item><description><b>Ignored</b> Ignored resources are not monitored.</description></item>
            /// <item><description><b>Unmanaged</b>: The resource does not have a CIDR block allocated from the IPAM pool. IPAM does not monitor whether the CIDR block of the resource meets the allocation rules of the IP address pool.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Compliant</para>
            /// </summary>
            [NameInMap("ComplianceStatus")]
            [Validation(Required=false)]
            public string ComplianceStatus { get; set; }

            [NameInMap("IpCountDetail")]
            [Validation(Required=false)]
            public ListIpamResourceCidrsResponseBodyIpamResourceCidrsIpCountDetail IpCountDetail { get; set; }
            public class ListIpamResourceCidrsResponseBodyIpamResourceCidrsIpCountDetail : TeaModel {
                [NameInMap("FreeIpCount")]
                [Validation(Required=false)]
                public string FreeIpCount { get; set; }

                [NameInMap("TotalIpCount")]
                [Validation(Required=false)]
                public string TotalIpCount { get; set; }

                [NameInMap("UsedIpCount")]
                [Validation(Required=false)]
                public string UsedIpCount { get; set; }

            }

            /// <summary>
            /// <para>The IP usage that is displayed in decimal form.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IpUsage")]
            [Validation(Required=false)]
            public string IpUsage { get; set; }

            /// <summary>
            /// <para>The ID of the instance to which CIDR blocks are allocated from the IPAM pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipam-pool-alloc-112za33e4****</para>
            /// </summary>
            [NameInMap("IpamAllocationId")]
            [Validation(Required=false)]
            public string IpamAllocationId { get; set; }

            /// <summary>
            /// <para>The ID of the IPAM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipam-uq5dcfc2eqhpf4****</para>
            /// </summary>
            [NameInMap("IpamId")]
            [Validation(Required=false)]
            public string IpamId { get; set; }

            /// <summary>
            /// <para>The ID of the IPAM pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipam-pool-6rcq3tobayc20t***</para>
            /// </summary>
            [NameInMap("IpamPoolId")]
            [Validation(Required=false)]
            public string IpamPoolId { get; set; }

            /// <summary>
            /// <para>The ID of the IPAM scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipam-scope-glfmcyldpm8lsy****</para>
            /// </summary>
            [NameInMap("IpamScopeId")]
            [Validation(Required=false)]
            public string IpamScopeId { get; set; }

            /// <summary>
            /// <para>The management status of the resource.</para>
            /// <list type="bullet">
            /// <item><description><b>Managed</b>: The resource has a CIDR block allocated from an IPAM pool. IPAM is monitoring whether the allocated CIDR block overlaps with other CIDR blocks and whether the allocated CIDR block meets the allocation rules.</description></item>
            /// <item><description><b>Unmanaged</b>: The resource does not have a CIDR block allocated from the IPAM pool. IPAM is monitoring whether the resource has CIDR blocks that meet the allocation rules. Monitor whether CIDR blocks overlap with each other.</description></item>
            /// <item><description><b>Ignored</b>: The resource is not monitored. Ignored resources are not monitored. If you ignore a resource, CIDR blocks allocated to the resource are returned to the IPAM pool and will not be automatically allocated to the resource (if automatic allocation rules are specified).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Managed</para>
            /// </summary>
            [NameInMap("ManagementStatus")]
            [Validation(Required=false)]
            public string ManagementStatus { get; set; }

            /// <summary>
            /// <para>List of resources that overlap with the current resource.</para>
            /// </summary>
            [NameInMap("OverlapDetail")]
            [Validation(Required=false)]
            public List<ListIpamResourceCidrsResponseBodyIpamResourceCidrsOverlapDetail> OverlapDetail { get; set; }
            public class ListIpamResourceCidrsResponseBodyIpamResourceCidrsOverlapDetail : TeaModel {
                /// <summary>
                /// <para>The CIDR that overlaps with the current resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.0/24</para>
                /// </summary>
                [NameInMap("OverlapResourceCidr")]
                [Validation(Required=false)]
                public string OverlapResourceCidr { get; set; }

                /// <summary>
                /// <para>Instance ID that overlaps with the current resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-aq3fjgnig5av6jb8d****</para>
                /// </summary>
                [NameInMap("OverlapResourceId")]
                [Validation(Required=false)]
                public string OverlapResourceId { get; set; }

                /// <summary>
                /// <para>The region of instance that overlaps with the current resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("OverlapResourceRegion")]
                [Validation(Required=false)]
                public string OverlapResourceRegion { get; set; }

            }

            /// <summary>
            /// <para>The overlapping status of the resource.</para>
            /// <list type="bullet">
            /// <item><description><b>Nonoverlapping</b></description></item>
            /// <item><description><b>Overlapping</b></description></item>
            /// <item><description><b>Ignored</b> Ignored resources are not monitored.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Nonoverlapping</para>
            /// </summary>
            [NameInMap("OverlapStatus")]
            [Validation(Required=false)]
            public string OverlapStatus { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp16qjewdsunr41m1****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>132193271328****</para>
            /// </summary>
            [NameInMap("ResourceOwnerId")]
            [Validation(Required=false)]
            public long? ResourceOwnerId { get; set; }

            /// <summary>
            /// <para>The effective region ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

            /// <summary>
            /// <para>The type of resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VPC</b></description></item>
            /// <item><description><b>VSwitch</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The source CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.0/24</para>
            /// </summary>
            [NameInMap("SourceCidr")]
            [Validation(Required=false)]
            public string SourceCidr { get; set; }

            /// <summary>
            /// <para>The status of the resource in the IPAM pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Created</b></description></item>
            /// <item><description><b>Deleted</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1fjfnrg3av6zb9e****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value of <b>NextToken</b> is returned, the value indicates the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49A9DE56-B68C-5FFC-BC06-509D086F287C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
