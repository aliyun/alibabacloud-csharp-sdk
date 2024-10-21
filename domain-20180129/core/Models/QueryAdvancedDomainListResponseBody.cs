// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryAdvancedDomainListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAdvancedDomainListResponseBodyData Data { get; set; }
        public class QueryAdvancedDomainListResponseBodyData : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public List<QueryAdvancedDomainListResponseBodyDataDomain> Domain { get; set; }
            public class QueryAdvancedDomainListResponseBodyDataDomain : TeaModel {
                [NameInMap("DnsList")]
                [Validation(Required=false)]
                public QueryAdvancedDomainListResponseBodyDataDomainDnsList DnsList { get; set; }
                public class QueryAdvancedDomainListResponseBodyDataDomainDnsList : TeaModel {
                    [NameInMap("Dns")]
                    [Validation(Required=false)]
                    public List<string> Dns { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SUCCEED</para>
                /// </summary>
                [NameInMap("DomainAuditStatus")]
                [Validation(Required=false)]
                public string DomainAuditStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("DomainGroupId")]
                [Validation(Required=false)]
                public string DomainGroupId { get; set; }

                [NameInMap("DomainGroupName")]
                [Validation(Required=false)]
                public string DomainGroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gTLD</para>
                /// </summary>
                [NameInMap("DomainType")]
                [Validation(Required=false)]
                public string DomainType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>356</para>
                /// </summary>
                [NameInMap("ExpirationCurrDateDiff")]
                [Validation(Required=false)]
                public int? ExpirationCurrDateDiff { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-04-09 17:07:03</para>
                /// </summary>
                [NameInMap("ExpirationDate")]
                [Validation(Required=false)]
                public string ExpirationDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1554800823000</para>
                /// </summary>
                [NameInMap("ExpirationDateLong")]
                [Validation(Required=false)]
                public long? ExpirationDateLong { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ExpirationDateStatus")]
                [Validation(Required=false)]
                public string ExpirationDateStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>S20182000000000</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Premium")]
                [Validation(Required=false)]
                public bool? Premium { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2a</para>
                /// </summary>
                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Tom</para>
                /// </summary>
                [NameInMap("RegistrantOrganization")]
                [Validation(Required=false)]
                public string RegistrantOrganization { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RegistrantType")]
                [Validation(Required=false)]
                public string RegistrantType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-04-09 17:07:03</para>
                /// </summary>
                [NameInMap("RegistrationDate")]
                [Validation(Required=false)]
                public string RegistrationDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1523264823000</para>
                /// </summary>
                [NameInMap("RegistrationDateLong")]
                [Validation(Required=false)]
                public long? RegistrationDateLong { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rg-aek2yyciz557g3q</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Tag")]
                [Validation(Required=false)]
                public QueryAdvancedDomainListResponseBodyDataDomainTag Tag { get; set; }
                public class QueryAdvancedDomainListResponseBodyDataDomainTag : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<QueryAdvancedDomainListResponseBodyDataDomainTagTag> Tag { get; set; }
                    public class QueryAdvancedDomainListResponseBodyDataDomainTagTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Tom</para>
                /// </summary>
                [NameInMap("ZhRegistrantOrganization")]
                [Validation(Required=false)]
                public string ZhRegistrantOrganization { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D200000-C0B9-4CD3-B92A-9B44A000000</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>549</para>
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>275</para>
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
