// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class SubscriptionDTO : TeaModel {
        /// <summary>
        /// <para>The balance type (permanent/monthly).</para>
        /// 
        /// <b>Example:</b>
        /// <para>permanent</para>
        /// </summary>
        [NameInMap("balanceType")]
        [Validation(Required=false)]
        public string BalanceType { get; set; }

        /// <summary>
        /// <para>The department ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public long? ClientId { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-15T10:00:00Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The subscription ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The subscription status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>active: The subscription is active.</description></item>
        /// <item><description>stopped: The subscription is stopped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The stop time. This value is empty if the subscription has not been stopped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-07-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("stopTime")]
        [Validation(Required=false)]
        public string StopTime { get; set; }

        /// <summary>
        /// <para>The subscription recharge amount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.00</para>
        /// </summary>
        [NameInMap("subscriptionAmount")]
        [Validation(Required=false)]
        public double? SubscriptionAmount { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-15T10:00:00Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The effective period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("validFrom")]
        [Validation(Required=false)]
        public string ValidFrom { get; set; }

    }

}
