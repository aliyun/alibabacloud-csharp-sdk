// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class InviteSubResellerRequest : TeaModel {
        /// <summary>
        /// <para>List of invited account information, up to 5 at a time.</para>
        /// </summary>
        [NameInMap("AccountInfoList")]
        [Validation(Required=false)]
        public List<InviteSubResellerRequestAccountInfoList> AccountInfoList { get; set; }
        public class InviteSubResellerRequestAccountInfoList : TeaModel {
            /// <summary>
            /// <para>Name of the distribution customer:</para>
            /// <list type="bullet">
            /// <item><description>If the distribution customer is a company, this is the company name.</description></item>
            /// <item><description>If the distribution customer is a T2 reseller partner, this is the partner name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>XXX技术有限公司</para>
            /// </summary>
            [NameInMap("AccountNickname")]
            [Validation(Required=false)]
            public string AccountNickname { get; set; }

            /// <summary>
            /// <para>Total budget quota allocated by the partner to the distribution customer (quota).</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CreditLine")]
            [Validation(Required=false)]
            public string CreditLine { get; set; }

            /// <summary>
            /// <para>Reason for applying for cross-regional association.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XXX</para>
            /// </summary>
            [NameInMap("CrossScopeRemark")]
            [Validation(Required=false)]
            public string CrossScopeRemark { get; set; }

            /// <summary>
            /// <para>Customer Business Manager (limited to 50 characters).</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("CustomerBd")]
            [Validation(Required=false)]
            public string CustomerBd { get; set; }

            /// <summary>
            /// <para>The email address to which the invitation email will be sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:nejatox206@getasail.com">nejatox206@getasail.com</a></para>
            /// </summary>
            [NameInMap("EmailAddress")]
            [Validation(Required=false)]
            public string EmailAddress { get; set; }

            /// <summary>
            /// <para>Initial order status:</para>
            /// <list type="bullet">
            /// <item><description>ban: Purchase Ban - The customer cannot place orders immediately after successful registration and association. The \&quot;Order Control\&quot; must be set to \&quot;Normal\&quot; before placing orders.</description></item>
            /// <item><description>normal: Normal - The customer can place orders immediately after successful registration and association.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("NewBuyStatus")]
            [Validation(Required=false)]
            public string NewBuyStatus { get; set; }

            /// <summary>
            /// <para>Country or region of the invited T2 Reseller. The parameter should comply with the ISO 3166-1 two-letter code (Alpha-2). You can use the ListCountries API to get the current UID contract coverage area list.</para>
            /// <para>The system will automatically determine if the invitation is cross-regional based on whether the <c>registerNation</c> parameter is within the T1 contract coverage area:</para>
            /// <list type="bullet">
            /// <item><description>If it\&quot;s a cross-regional invitation, a cross-regional approval process will be initiated. After approval by Alibaba Cloud, an invitation registration email will be sent to the invited email address.</description></item>
            /// <item><description>If it\&quot;s not a cross-regional invitation, an invitation registration email will be sent directly.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SG</para>
            /// </summary>
            [NameInMap("RegisterNation")]
            [Validation(Required=false)]
            public string RegisterNation { get; set; }

            /// <summary>
            /// <para>Description of the distribution customer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>发展xx为客户的邀请</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>Do not fill in, deprecated parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SubAccountType")]
            [Validation(Required=false)]
            public string SubAccountType { get; set; }

            /// <summary>
            /// <para>Management of the shutdown policy for the distribution customer by the partner.</para>
            /// <list type="bullet">
            /// <item><description>1: delayStop - Enjoy delayed shutdown with a grace period: Alibaba Cloud takes over the resources, and when the grace period quota is exhausted, the instance will be shut down. If payment is not made within 15 days, the storage resources will be released.</description></item>
            /// <item><description>2: noStop - Manual management of overdue without stopping: The system does not manage the lifecycle of the sub-account\&quot;s resources. The partner needs to manually manage the shutdown status of the customer\&quot;s instances.</description></item>
            /// <item><description>3: immediatelyStop - Immediate shutdown upon overdue: When the available quota of the customer\&quot;s account is less than 0, the account enters an overdue state, triggering the shutdown of the instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ZeroCreditShutdownPolicy")]
            [Validation(Required=false)]
            public string ZeroCreditShutdownPolicy { get; set; }

        }

    }

}
