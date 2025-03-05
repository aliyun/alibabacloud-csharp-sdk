// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class ListIpamsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The IPAMs.</para>
        /// </summary>
        [NameInMap("Ipams")]
        [Validation(Required=false)]
        public List<ListIpamsResponseBodyIpams> Ipams { get; set; }
        public class ListIpamsResponseBodyIpams : TeaModel {
            /// <summary>
            /// <para>The time when the IPAM was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-01T02:05:23Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ipam-res-disco-assoc-jt5fac8twugdbbgip****</para>
            /// </summary>
            [NameInMap("DefaultResourceDiscoveryAssociationId")]
            [Validation(Required=false)]
            public string DefaultResourceDiscoveryAssociationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ipam-res-disco-jt5f2af2u6nk2z321****</para>
            /// </summary>
            [NameInMap("DefaultResourceDiscoveryId")]
            [Validation(Required=false)]
            public string DefaultResourceDiscoveryId { get; set; }

            /// <summary>
            /// <para>The description of the IPAM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test description</para>
            /// </summary>
            [NameInMap("IpamDescription")]
            [Validation(Required=false)]
            public string IpamDescription { get; set; }

            /// <summary>
            /// <para>The ID of the IPAM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipam-ccxbnsbhew0d6t****</para>
            /// </summary>
            [NameInMap("IpamId")]
            [Validation(Required=false)]
            public string IpamId { get; set; }

            /// <summary>
            /// <para>The name of the IPAM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("IpamName")]
            [Validation(Required=false)]
            public string IpamName { get; set; }

            /// <summary>
            /// <para>The status of the IPAM. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b></description></item>
            /// <item><description><b>Created</b></description></item>
            /// <item><description><b>Deleting</b></description></item>
            /// <item><description><b>Deleted</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("IpamStatus")]
            [Validation(Required=false)]
            public string IpamStatus { get; set; }

            /// <summary>
            /// <para>The effective regions of the IPAM.</para>
            /// </summary>
            [NameInMap("OperatingRegionList")]
            [Validation(Required=false)]
            public List<string> OperatingRegionList { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account that owns the IPAM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1210123456******</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            /// <summary>
            /// <para>The default private scope created by the system after the IPAM is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipam-scope-okoerbco6unqfr****</para>
            /// </summary>
            [NameInMap("PrivateDefaultScopeId")]
            [Validation(Required=false)]
            public string PrivateDefaultScopeId { get; set; }

            /// <summary>
            /// <para>The default public scope created by the system after the IPAM is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipam-scope-ovb76p1g1m19dr****</para>
            /// </summary>
            [NameInMap("PublicDefaultScopeId")]
            [Validation(Required=false)]
            public string PublicDefaultScopeId { get; set; }

            /// <summary>
            /// <para>The region ID of the IPAM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResourceDiscoveryAssociationCount")]
            [Validation(Required=false)]
            public int? ResourceDiscoveryAssociationCount { get; set; }

            /// <summary>
            /// <para>The resource group ID of the IPAM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2dbprgpt****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The number of IPAM scopes. Value: <b>2 to 5</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ScopeCount")]
            [Validation(Required=false)]
            public int? ScopeCount { get; set; }

            /// <summary>
            /// <para>The tag list.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListIpamsResponseBodyIpamsTags> Tags { get; set; }
            public class ListIpamsResponseBodyIpamsTags : TeaModel {
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
        /// <para>20</para>
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
        /// <para>23CA0A0B-B0F5-5495-B355-7D9A9203A46B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
