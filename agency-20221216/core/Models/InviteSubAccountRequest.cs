// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class InviteSubAccountRequest : TeaModel {
        /// <summary>
        /// <para>The list of account information for the invitation. A maximum of five accounts can be invited at a time.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AccountInfoList")]
        [Validation(Required=false)]
        public List<InviteSubAccountRequestAccountInfoList> AccountInfoList { get; set; }
        public class InviteSubAccountRequestAccountInfoList : TeaModel {
            /// <summary>
            /// <para>The name of the distribution customer. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If the distribution customer is an enterprise, this is the company name.</description></item>
            /// <item><description>If the distribution customer is a T2 reseller partner, this is the partner name.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XXX技术有限公司</para>
            /// </summary>
            [NameInMap("AccountNickname")]
            [Validation(Required=false)]
            public string AccountNickname { get; set; }

            /// <summary>
            /// <para>The total budget quota that the partner allocates to the distribution customer.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CreditLine")]
            [Validation(Required=false)]
            public string CreditLine { get; set; }

            /// <summary>
            /// <para>The account manager of the customer. Maximum length: 50 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("CustomerBd")]
            [Validation(Required=false)]
            public string CustomerBd { get; set; }

            /// <summary>
            /// <para>The customer ID returned by the CreateCustomer API.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("CustomerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            /// <summary>
            /// <para>The email address of the distribution customer account. The invitation email is sent to this address.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:12345@163.com">12345@163.com</a></para>
            /// </summary>
            [NameInMap("EmailAddress")]
            [Validation(Required=false)]
            public string EmailAddress { get; set; }

            /// <summary>
            /// <para>The initial order placement status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ban: Purchase is prohibited. After the customer is registered and associated, the customer cannot immediately place orders to purchase cloud resources. You must set the order control to normal before the customer can place orders.</description></item>
            /// <item><description>normal: Normal. After the customer is registered and associated, the customer can immediately place orders to purchase cloud resources.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ban</para>
            /// </summary>
            [NameInMap("NewBuyStatus")]
            [Validation(Required=false)]
            public string NewBuyStatus { get; set; }

            /// <summary>
            /// <para>The description of the distribution customer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>发展xx为客户的邀请</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The type of the sub-account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: end user of Agency.</description></item>
            /// <item><description>2: end user of Reseller. </description></item>
            /// <item><description>5: T2 partner of Reseller.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SubAccountType")]
            [Validation(Required=false)]
            public string SubAccountType { get; set; }

            /// <summary>
            /// <para>The shutdown policy that the partner manages for the distribution customer. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: delayStop. Alibaba Cloud takes over the resources and the customer enjoys a delayed shutdown quota. When the delayed shutdown quota is exhausted, instance shutdown is triggered. If payment is not made within 15 days, storage resources are released.</description></item>
            /// <item><description>2: noStop. Manual management with no shutdown on overdue payment. The system does not manage the resource lifecycle of the non-trusteeship linked account. The partner must manually manage the instance shutdown status of the customer.</description></item>
            /// <item><description>3: immediatelyStop. Instances are immediately shut down on overdue payment. When the available quota of the customer account is less than 0, the account enters the overdue payment status and instance shutdown is triggered.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
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
