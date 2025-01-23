// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamScopesResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("IpamScopes")]
        [Validation(Required=false)]
        public List<ListIpamScopesResponseBodyIpamScopes> IpamScopes { get; set; }
        public class ListIpamScopesResponseBodyIpamScopes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-04-18T03:12:37Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ipam-ccxbnsbhew0d6t****</para>
            /// </summary>
            [NameInMap("IpamId")]
            [Validation(Required=false)]
            public string IpamId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test description</para>
            /// </summary>
            [NameInMap("IpamScopeDescription")]
            [Validation(Required=false)]
            public string IpamScopeDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ipam-scope-glfmcyldpm8lsy****</para>
            /// </summary>
            [NameInMap("IpamScopeId")]
            [Validation(Required=false)]
            public string IpamScopeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("IpamScopeName")]
            [Validation(Required=false)]
            public string IpamScopeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("IpamScopeType")]
            [Validation(Required=false)]
            public string IpamScopeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

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
            [NameInMap("PoolCount")]
            [Validation(Required=false)]
            public int? PoolCount { get; set; }

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
            /// <para>Created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListIpamScopesResponseBodyIpamScopesTags> Tags { get; set; }
            public class ListIpamScopesResponseBodyIpamScopesTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
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
        /// <para>8859C501-97E7-53D4-B94B-2A9E16003B22</para>
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
