// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainByInstanceIdResponseBody : TeaModel {
        [NameInMap("DnsList")]
        [Validation(Required=false)]
        public QueryDomainByInstanceIdResponseBodyDnsList DnsList { get; set; }
        public class QueryDomainByInstanceIdResponseBodyDnsList : TeaModel {
            [NameInMap("Dns")]
            [Validation(Required=false)]
            public List<string> Dns { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("DomainGroupId")]
        [Validation(Required=false)]
        public long? DomainGroupId { get; set; }

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
        /// <para>false</para>
        /// </summary>
        [NameInMap("DomainNameProxyService")]
        [Validation(Required=false)]
        public bool? DomainNameProxyService { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NONAUDIT</para>
        /// </summary>
        [NameInMap("DomainNameVerificationStatus")]
        [Validation(Required=false)]
        public string DomainNameVerificationStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
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
        /// <para>false</para>
        /// </summary>
        [NameInMap("EmailVerificationClientHold")]
        [Validation(Required=false)]
        public bool? EmailVerificationClientHold { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EmailVerificationStatus")]
        [Validation(Required=false)]
        public int? EmailVerificationStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>356</para>
        /// </summary>
        [NameInMap("ExpirationCurrDateDiff")]
        [Validation(Required=false)]
        public int? ExpirationCurrDateDiff { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-12-07 17:02:13</para>
        /// </summary>
        [NameInMap("ExpirationDate")]
        [Validation(Required=false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1625111915000</para>
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
        /// <para>S20179H1BBI9test</para>
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
        /// <para>NONAUDIT</para>
        /// </summary>
        [NameInMap("RealNameStatus")]
        [Validation(Required=false)]
        public string RealNameStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Test litm</para>
        /// </summary>
        [NameInMap("RegistrantName")]
        [Validation(Required=false)]
        public string RegistrantName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Test litm</para>
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
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("RegistrantUpdatingStatus")]
        [Validation(Required=false)]
        public string RegistrantUpdatingStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2017-12-07 17:02:13</para>
        /// </summary>
        [NameInMap("RegistrationDate")]
        [Validation(Required=false)]
        public string RegistrationDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1625111915000</para>
        /// </summary>
        [NameInMap("RegistrationDateLong")]
        [Validation(Required=false)]
        public long? RegistrationDateLong { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>23C9B3C4-9E2C-4405-A88D-BD33E459D140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-acfmw6bpc6n7zai</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public QueryDomainByInstanceIdResponseBodyTag Tag { get; set; }
        public class QueryDomainByInstanceIdResponseBodyTag : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<QueryDomainByInstanceIdResponseBodyTagTag> Tag { get; set; }
            public class QueryDomainByInstanceIdResponseBodyTagTag : TeaModel {
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
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("TransferOutStatus")]
        [Validation(Required=false)]
        public string TransferOutStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CLOSE</para>
        /// </summary>
        [NameInMap("TransferProhibitionLock")]
        [Validation(Required=false)]
        public string TransferProhibitionLock { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CLOSE</para>
        /// </summary>
        [NameInMap("UpdateProhibitionLock")]
        [Validation(Required=false)]
        public string UpdateProhibitionLock { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>121000000****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("ZhRegistrantName")]
        [Validation(Required=false)]
        public string ZhRegistrantName { get; set; }

        [NameInMap("ZhRegistrantOrganization")]
        [Validation(Required=false)]
        public string ZhRegistrantOrganization { get; set; }

    }

}
