// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamResourceDiscoveriesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("IpamResourceDiscoveries")]
        [Validation(Required=false)]
        public List<ListIpamResourceDiscoveriesResponseBodyIpamResourceDiscoveries> IpamResourceDiscoveries { get; set; }
        public class ListIpamResourceDiscoveriesResponseBodyIpamResourceDiscoveries : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-01T02:05:23Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test description</para>
            /// </summary>
            [NameInMap("IpamResourceDiscoveryDescription")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ipam-res-disco-jt5f2af2u6nk2z321****</para>
            /// </summary>
            [NameInMap("IpamResourceDiscoveryId")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("IpamResourceDiscoveryName")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("IpamResourceDiscoveryStatus")]
            [Validation(Required=false)]
            public string IpamResourceDiscoveryStatus { get; set; }

            [NameInMap("OperatingRegionList")]
            [Validation(Required=false)]
            public List<string> OperatingRegionList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1210123456******</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-aek2sermdd6****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListIpamResourceDiscoveriesResponseBodyIpamResourceDiscoveriesTags> Tags { get; set; }
            public class ListIpamResourceDiscoveriesResponseBodyIpamResourceDiscoveriesTags : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>86137597-443F-5B66-B9B6-8514E0C50B8F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
