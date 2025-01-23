// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamPoolsResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("IpamPools")]
        [Validation(Required=false)]
        public List<ListIpamPoolsResponseBodyIpamPools> IpamPools { get; set; }
        public class ListIpamPoolsResponseBodyIpamPools : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>28</para>
            /// </summary>
            [NameInMap("AllocationDefaultCidrMask")]
            [Validation(Required=false)]
            public int? AllocationDefaultCidrMask { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("AllocationMaxCidrMask")]
            [Validation(Required=false)]
            public int? AllocationMaxCidrMask { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("AllocationMinCidrMask")]
            [Validation(Required=false)]
            public int? AllocationMinCidrMask { get; set; }

            [NameInMap("AutoImport")]
            [Validation(Required=false)]
            public bool? AutoImport { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-04-19T16:49:01Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasSubPool")]
            [Validation(Required=false)]
            public bool? HasSubPool { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ipam-b5mtlx3q7xcnyr****</para>
            /// </summary>
            [NameInMap("IpamId")]
            [Validation(Required=false)]
            public string IpamId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test description</para>
            /// </summary>
            [NameInMap("IpamPoolDescription")]
            [Validation(Required=false)]
            public string IpamPoolDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ipam-pool-6rcq3tobayc20t****</para>
            /// </summary>
            [NameInMap("IpamPoolId")]
            [Validation(Required=false)]
            public string IpamPoolId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("IpamPoolName")]
            [Validation(Required=false)]
            public string IpamPoolName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("IpamRegionId")]
            [Validation(Required=false)]
            public string IpamRegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ipam-scope-glfmcyldpm8lsy****</para>
            /// </summary>
            [NameInMap("IpamScopeId")]
            [Validation(Required=false)]
            public string IpamScopeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("IpamScopeType")]
            [Validation(Required=false)]
            public string IpamScopeType { get; set; }

            [NameInMap("IsShared")]
            [Validation(Required=false)]
            public bool? IsShared { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1210123456******</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PoolDepth")]
            [Validation(Required=false)]
            public int? PoolDepth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("PoolRegionId")]
            [Validation(Required=false)]
            public string PoolRegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ipam-pool-lfnwi4jok1ss0g****</para>
            /// </summary>
            [NameInMap("SourceIpamPoolId")]
            [Validation(Required=false)]
            public string SourceIpamPoolId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListIpamPoolsResponseBodyIpamPoolsTags> Tags { get; set; }
            public class ListIpamPoolsResponseBodyIpamPoolsTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FinanceJoshua</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B54867DE-83DC-56B4-A57E-69A03119D0B1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
