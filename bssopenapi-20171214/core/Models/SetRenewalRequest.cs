// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class SetRenewalRequest : TeaModel {
        /// <summary>
        /// <para>The instance IDs. You can specify up to 100 subscription instances at a time. Separate multiple instance IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-askjdhaskfjh</para>
        /// </summary>
        [NameInMap("InstanceIDs")]
        [Validation(Required=false)]
        public string InstanceIDs { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The product code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The auto-renewal period of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// <item><description>6</description></item>
        /// <item><description>12</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when RenewalStatus is set to AutoRenewal.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RenewalPeriod")]
        [Validation(Required=false)]
        public int? RenewalPeriod { get; set; }

        /// <summary>
        /// <para>The unit of the auto-renewal cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>M: month.</description></item>
        /// <item><description>Y: year.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when RenewalStatus is set to AutoRenewal.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>M</para>
        /// </summary>
        [NameInMap("RenewalPeriodUnit")]
        [Validation(Required=false)]
        public string RenewalPeriodUnit { get; set; }

        /// <summary>
        /// <para>The renewal status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AutoRenewal: auto-renewal.</description></item>
        /// <item><description>ManualRenewal: manual renewal.</description></item>
        /// <item><description>NotRenewal: no renewal.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AutoRenewal</para>
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

        /// <summary>
        /// <para>The subscription type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Subscription: subscription.</description></item>
        /// <item><description>PayAsYouGo: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

    }

}
