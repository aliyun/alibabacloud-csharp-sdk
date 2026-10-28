// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class EditZeroCreditShutdownRequest : TeaModel {
        /// <summary>
        /// <h3><b>Shutdown policy</b></h3>
        /// <para>For more information, refer to the official documentation: <a href="https://www.alibabacloud.com/help/zh/channel-platform/latest/shutdowndelayprivilege">https://www.alibabacloud.com/help/zh/channel-platform/latest/shutdowndelayprivilege</a></para>
        /// <list type="bullet">
        /// <item><description><b>immediatelyStop</b>——When the active credit of the distributor customer account is less than 0, the account enters the overdue payment state. New resources cannot be purchased. Pay-as-you-go instances are stopped and no longer incur charges. Upfront instances can be used until they expire. After the instances remain stopped for 15 days, pay-as-you-go instances are released. Because of billing delays, credits may continue to be deducted even after instances are successfully stopped.</description></item>
        /// <item><description><b>delayStop</b>——The overdraft quota in the delayed shutdown policy is calculated by Alibaba Cloud based on the historical consumption of the account. The minimum overdraft quota is 600 USD, and instances can continue to run for approximately 15 days after the overdue payment occurs. The overdraft quota applies to pay-as-you-go products. After this policy is enabled, when the customer has an overdue payment (active credit &lt; 0) and the overdue amount is within the overdraft quota, instance shutdown is not triggered. The overdraft quota is not the upper limit of the overdue amount. Because of billing delays, credits may continue to be deducted even after instances are successfully stopped. After the instances remain stopped for 15 days, pay-as-you-go instances are released. When the delayed shutdown quota &lt;= remaining credit &lt; 0, you can manually trigger an immediate shutdown.</description></item>
        /// <item><description><b>noStop</b>——If you select this option, instances are not stopped when the customer has an overdue payment. When the customer has an overdue payment (remaining credit &lt; 0), instance shutdown is not triggered. There is no upper limit on the overdue amount. You must perform a manual operation of &quot;Immediate Shutdown&quot; in ACPN to change the instance status. Use this option with caution.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>noStop</para>
        /// </summary>
        [NameInMap("ShutdownPolicy")]
        [Validation(Required=false)]
        public string ShutdownPolicy { get; set; }

        /// <summary>
        /// <para>The UID of the distributor customer whose shutdown policy you want to modify.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1263644979775567</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
