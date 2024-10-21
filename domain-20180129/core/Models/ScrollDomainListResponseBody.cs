// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class ScrollDomainListResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain names.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ScrollDomainListResponseBodyData Data { get; set; }
        public class ScrollDomainListResponseBodyData : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public List<ScrollDomainListResponseBodyDataDomain> Domain { get; set; }
            public class ScrollDomainListResponseBodyDataDomain : TeaModel {
                /// <summary>
                /// <para>The Domain Name System (DNS) servers of the domain name.</para>
                /// </summary>
                [NameInMap("DnsList")]
                [Validation(Required=false)]
                public ScrollDomainListResponseBodyDataDomainDnsList DnsList { get; set; }
                public class ScrollDomainListResponseBodyDataDomainDnsList : TeaModel {
                    [NameInMap("Dns")]
                    [Validation(Required=false)]
                    public List<string> Dns { get; set; }

                }

                /// <summary>
                /// <para>The status of real-name verification for the domain name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>FAILED</b>: Real-name verification for the domain name fails.</description></item>
                /// <item><description><b>SUCCEED</b>: Real-name verification for the domain name is successful.</description></item>
                /// <item><description><b>NONAUDIT</b>: Real-name verification for the domain name is not performed.</description></item>
                /// <item><description><b>AUDITING</b>: Real-name verification for the domain name is in progress.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NONAUDIT</para>
                /// </summary>
                [NameInMap("DomainAuditStatus")]
                [Validation(Required=false)]
                public string DomainAuditStatus { get; set; }

                /// <summary>
                /// <para>The ID of the domain name group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("DomainGroupId")]
                [Validation(Required=false)]
                public string DomainGroupId { get; set; }

                /// <summary>
                /// <para>The name of the domain name group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test group</para>
                /// </summary>
                [NameInMap("DomainGroupName")]
                [Validation(Required=false)]
                public string DomainGroupName { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The status of the domain name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The domain name needs to be renewed.</description></item>
                /// <item><description><b>2</b>: The domain name needs to be redeemed.</description></item>
                /// <item><description><b>3</b>: The domain name is normal.</description></item>
                /// <item><description><b>4</b>: The domain name is being transferred out.</description></item>
                /// <item><description><b>5</b>: The information about the domain name registrant is being modified.</description></item>
                /// <item><description><b>6</b>: Real-name verification is not performed on the domain name.</description></item>
                /// <item><description><b>7</b>: Real-name verification for the domain name fails.</description></item>
                /// <item><description><b>8</b>: The real-name verification is being reviewed.</description></item>
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
                /// <para>The email address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The number of days from the expiration date of the domain name to the current date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ExpirationCurrDateDiff")]
                [Validation(Required=false)]
                public int? ExpirationCurrDateDiff { get; set; }

                /// <summary>
                /// <para>The time when the domain name expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-15 17:30:35</para>
                /// </summary>
                [NameInMap("ExpirationDate")]
                [Validation(Required=false)]
                public string ExpirationDate { get; set; }

                /// <summary>
                /// <para>The time when the domain name expires. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1550223035000</para>
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
                /// <para>The instance ID of the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S1234</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Indicates whether the domain name is a premium domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
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
                /// <para>The registrant of the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alibaba cloud</para>
                /// </summary>
                [NameInMap("RegistrantOrganization")]
                [Validation(Required=false)]
                public string RegistrantOrganization { get; set; }

                /// <summary>
                /// <para>The registration type of the domain name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: individual.</description></item>
                /// <item><description><b>2</b>: enterprise.</description></item>
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
                /// <para>2017-02-15 00:00:00</para>
                /// </summary>
                [NameInMap("RegistrationDate")]
                [Validation(Required=false)]
                public string RegistrationDate { get; set; }

                /// <summary>
                /// <para>The time when the domain name was registered. This value is a UNIX timestamp that indicates the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1487088000000</para>
                /// </summary>
                [NameInMap("RegistrationDateLong")]
                [Validation(Required=false)]
                public long? RegistrationDateLong { get; set; }

                /// <summary>
                /// <para>The remarks on the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test domain</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aek2yyciz557g3q</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The resource tag.</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public ScrollDomainListResponseBodyDataDomainTag Tag { get; set; }
                public class ScrollDomainListResponseBodyDataDomainTag : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<ScrollDomainListResponseBodyDataDomainTagTag> Tag { get; set; }
                    public class ScrollDomainListResponseBodyDataDomainTagTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testKey</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testValue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The Chinese name of the domain name registrant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>阿里云</para>
                /// </summary>
                [NameInMap("ZhRegistrantOrganization")]
                [Validation(Required=false)]
                public string ZhRegistrantOrganization { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>722AB7F5-61F0-408C-A012-4784AFD34083</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The scroll ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ScrollId")]
        [Validation(Required=false)]
        public string ScrollId { get; set; }

        /// <summary>
        /// <para>The number of remaining domain names to be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

    }

}
