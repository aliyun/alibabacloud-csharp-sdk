// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamPoolsResponseBody : TeaModel {
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
        /// <para>The IPAM pools.</para>
        /// </summary>
        [NameInMap("IpamPools")]
        [Validation(Required=false)]
        public List<ListIpamPoolsResponseBodyIpamPools> IpamPools { get; set; }
        public class ListIpamPoolsResponseBodyIpamPools : TeaModel {
            /// <summary>
            /// <para>The default network mask assigned to the IPAM pool.</para>
            /// <para>An IPv4 mask must be <b>0 to 32</b> bits in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>28</para>
            /// </summary>
            [NameInMap("AllocationDefaultCidrMask")]
            [Validation(Required=false)]
            public int? AllocationDefaultCidrMask { get; set; }

            /// <summary>
            /// <para>The maximum network mask assigned to the IPAM pool.</para>
            /// <para>An IPv4 mask must be <b>0 to 32</b> bits in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("AllocationMaxCidrMask")]
            [Validation(Required=false)]
            public int? AllocationMaxCidrMask { get; set; }

            /// <summary>
            /// <para>The minimum network mask assigned to the IPAM pool.</para>
            /// <para>An IPv4 mask must be <b>0 to 32</b> bits in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("AllocationMinCidrMask")]
            [Validation(Required=false)]
            public int? AllocationMinCidrMask { get; set; }

            /// <summary>
            /// <para>Whether the pool has the auto-import feature enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoImport")]
            [Validation(Required=false)]
            public bool? AutoImport { get; set; }

            /// <summary>
            /// <para>The time when the IPAM pool was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-19T16:49:01Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the pool is a subpool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasSubPool")]
            [Validation(Required=false)]
            public bool? HasSubPool { get; set; }

            /// <summary>
            /// <para>The IP version. Only <b>IPv4</b> may be returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// <para>The ID of the IPAM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipam-b5mtlx3q7xcnyr****</para>
            /// </summary>
            [NameInMap("IpamId")]
            [Validation(Required=false)]
            public string IpamId { get; set; }

            /// <summary>
            /// <para>The description of the IPAM pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test description</para>
            /// </summary>
            [NameInMap("IpamPoolDescription")]
            [Validation(Required=false)]
            public string IpamPoolDescription { get; set; }

            /// <summary>
            /// <para>The ID of the IPAM pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipam-pool-6rcq3tobayc20t****</para>
            /// </summary>
            [NameInMap("IpamPoolId")]
            [Validation(Required=false)]
            public string IpamPoolId { get; set; }

            /// <summary>
            /// <para>The name of the IPAM pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("IpamPoolName")]
            [Validation(Required=false)]
            public string IpamPoolName { get; set; }

            /// <summary>
            /// <para>The ID of the region where the IPAM to which the IPAM pool belongs is hosted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("IpamRegionId")]
            [Validation(Required=false)]
            public string IpamRegionId { get; set; }

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
            /// <para>The type of the IPAM scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>public</b></description></item>
            /// <item><description><b>private</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("IpamScopeType")]
            [Validation(Required=false)]
            public string IpamScopeType { get; set; }

            /// <summary>
            /// <para>Whether it is a shared pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsShared")]
            [Validation(Required=false)]
            public bool? IsShared { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account of the owner for the IPAM pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1210123456******</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            /// <summary>
            /// <para>The depth of the IPAM pool. Valid values: <b>0 to 10</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PoolDepth")]
            [Validation(Required=false)]
            public int? PoolDepth { get; set; }

            /// <summary>
            /// <para>The effective region of the IPAM pool. The ID of the effective region for the IPAM pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("PoolRegionId")]
            [Validation(Required=false)]
            public string PoolRegionId { get; set; }

            /// <summary>
            /// <para>The ID of the region where the operation is called.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmxazb4ph6aiy****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the source IPAM pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipam-pool-lfnwi4jok1ss0g****</para>
            /// </summary>
            [NameInMap("SourceIpamPoolId")]
            [Validation(Required=false)]
            public string SourceIpamPoolId { get; set; }

            /// <summary>
            /// <para>The status of the IPAM pool. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b></description></item>
            /// <item><description><b>Created</b>: indicates that the creation is complete.</description></item>
            /// <item><description><b>Modifying</b></description></item>
            /// <item><description><b>Deleting</b></description></item>
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
            /// <para>The tag list.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListIpamPoolsResponseBodyIpamPoolsTags> Tags { get; set; }
            public class ListIpamPoolsResponseBodyIpamPoolsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceJoshua</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 10.</para>
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
        /// <para>B54867DE-83DC-56B4-A57E-69A03119D0B1</para>
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
