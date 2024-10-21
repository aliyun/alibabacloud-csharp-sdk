// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainListResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        /// <summary>
        /// <para>The domain names.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDomainListResponseBodyData Data { get; set; }
        public class QueryDomainListResponseBodyData : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public List<QueryDomainListResponseBodyDataDomain> Domain { get; set; }
            public class QueryDomainListResponseBodyDataDomain : TeaModel {
                /// <summary>
                /// <para>The name of the domain name registrant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Guangzhou Forest Advertising Decoration Co., LTD</para>
                /// </summary>
                [NameInMap("Ccompany")]
                [Validation(Required=false)]
                public string Ccompany { get; set; }

                [NameInMap("ChgholderStatus")]
                [Validation(Required=false)]
                public string ChgholderStatus { get; set; }

                /// <summary>
                /// <para>The state of real-name verification for the domain name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>FAILED</b>: Real-name verification for the domain name fails.</description></item>
                /// <item><description><b>SUCCEED</b>: Real-name verification for the domain name is successful.</description></item>
                /// <item><description><b>NONAUDIT</b>: Real-name verification for the domain name is not performed.</description></item>
                /// <item><description><b>AUDITING</b>: Real-name verification for the domain name is in progress.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FAILED</para>
                /// </summary>
                [NameInMap("DomainAuditStatus")]
                [Validation(Required=false)]
                public string DomainAuditStatus { get; set; }

                /// <summary>
                /// <para>The ID of the domain name group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("DomainGroupId")]
                [Validation(Required=false)]
                public string DomainGroupId { get; set; }

                /// <summary>
                /// <para>The name of the domain name group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试分组</para>
                /// </summary>
                [NameInMap("DomainGroupName")]
                [Validation(Required=false)]
                public string DomainGroupName { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The state of the domain name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The domain name needs to be renewed.</description></item>
                /// <item><description><b>2</b>: The domain name needs to be redeemed.</description></item>
                /// <item><description><b>3</b>: The domain name is normal.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                /// <summary>
                /// <para>The type of the domain name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>New gTLD</b></description></item>
                /// <item><description><b>gTLD</b></description></item>
                /// <item><description><b>ccTLD</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>gTLD</para>
                /// </summary>
                [NameInMap("DomainType")]
                [Validation(Required=false)]
                public string DomainType { get; set; }

                /// <summary>
                /// <para>The number of days from the expiration date of the domain name to the current date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-30</para>
                /// </summary>
                [NameInMap("ExpirationCurrDateDiff")]
                [Validation(Required=false)]
                public int? ExpirationCurrDateDiff { get; set; }

                /// <summary>
                /// <para>The time when the domain name expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-11-02 04:00:45</para>
                /// </summary>
                [NameInMap("ExpirationDate")]
                [Validation(Required=false)]
                public string ExpirationDate { get; set; }

                /// <summary>
                /// <para>The validity period of the domain name. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1522080000000</para>
                /// </summary>
                [NameInMap("ExpirationDateLong")]
                [Validation(Required=false)]
                public long? ExpirationDateLong { get; set; }

                /// <summary>
                /// <para>Indicates whether the domain name expires. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The domain name does not expire.</description></item>
                /// <item><description><b>2</b>: The domain name expires.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ExpirationDateStatus")]
                [Validation(Required=false)]
                public string ExpirationDateStatus { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ST20151102120031118</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Indicates whether the domain name is a premium domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Premium")]
                [Validation(Required=false)]
                public bool? Premium { get; set; }

                /// <summary>
                /// <para>The service ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2a</para>
                /// </summary>
                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                /// <summary>
                /// <para>The registration type of the domain name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: individual</description></item>
                /// <item><description><b>2</b>: enterprise</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RegistrantType")]
                [Validation(Required=false)]
                public string RegistrantType { get; set; }

                /// <summary>
                /// <para>The time when the domain name was registered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-11-02 04:00:45</para>
                /// </summary>
                [NameInMap("RegistrationDate")]
                [Validation(Required=false)]
                public string RegistrationDate { get; set; }

                /// <summary>
                /// <para>Indicates how long the domain name has been registered. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1522080000000</para>
                /// </summary>
                [NameInMap("RegistrationDateLong")]
                [Validation(Required=false)]
                public long? RegistrationDateLong { get; set; }

                /// <summary>
                /// <para>The remarks of the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>备注</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the domain name belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aek2yyciz557g3q</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The tags added to the resource.</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public QueryDomainListResponseBodyDataDomainTag Tag { get; set; }
                public class QueryDomainListResponseBodyDataDomainTag : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<QueryDomainListResponseBodyDataDomainTagTag> Tag { get; set; }
                    public class QueryDomainListResponseBodyDataDomainTagTag : TeaModel {
                        /// <summary>
                        /// <para>The key of the tag added to the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testKey</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the tag added to the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testValue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>Indicates whether the current page is followed by a page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Indicates whether the current page is preceded by a page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B7AB5469-5E38-4AA9-A920-C65B7A9C8E6E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of domain names returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
