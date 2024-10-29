// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamsResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("Ipams")]
        [Validation(Required=false)]
        public List<ListIpamsResponseBodyIpams> Ipams { get; set; }
        public class ListIpamsResponseBodyIpams : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-01T02:05:23Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DefaultResourceDiscoveryAssociationId")]
            [Validation(Required=false)]
            public string DefaultResourceDiscoveryAssociationId { get; set; }

            [NameInMap("DefaultResourceDiscoveryId")]
            [Validation(Required=false)]
            public string DefaultResourceDiscoveryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test description</para>
            /// </summary>
            [NameInMap("IpamDescription")]
            [Validation(Required=false)]
            public string IpamDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ipam-ccxbnsbhew0d6t****</para>
            /// </summary>
            [NameInMap("IpamId")]
            [Validation(Required=false)]
            public string IpamId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("IpamName")]
            [Validation(Required=false)]
            public string IpamName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("IpamStatus")]
            [Validation(Required=false)]
            public string IpamStatus { get; set; }

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
            /// <para>ipam-scope-okoerbco6unqfr****</para>
            /// </summary>
            [NameInMap("PrivateDefaultScopeId")]
            [Validation(Required=false)]
            public string PrivateDefaultScopeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ipam-scope-ovb76p1g1m19dr****</para>
            /// </summary>
            [NameInMap("PublicDefaultScopeId")]
            [Validation(Required=false)]
            public string PublicDefaultScopeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceDiscoveryAssociationCount")]
            [Validation(Required=false)]
            public int? ResourceDiscoveryAssociationCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-aek2dbprgpt****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ScopeCount")]
            [Validation(Required=false)]
            public int? ScopeCount { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListIpamsResponseBodyIpamsTags> Tags { get; set; }
            public class ListIpamsResponseBodyIpamsTags : TeaModel {
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
        /// <para>20</para>
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
        /// <para>23CA0A0B-B0F5-5495-B355-7D9A9203A46B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
