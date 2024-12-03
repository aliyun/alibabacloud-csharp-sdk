// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class SetRenewalRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance. You can enable auto-renewal for up to 100 subscription instances at a time. Separate multiple instance IDs with commas (,).</para>
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
        /// <para>The code of the service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The type of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The auto-renewal period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// <item><description>6</description></item>
        /// <item><description>12</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if the RenewalStatus parameter is set to AutoRenewal.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RenewalPeriod")]
        [Validation(Required=false)]
        public int? RenewalPeriod { get; set; }

        /// <summary>
        /// <para>The unit of the auto-renewal period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>M: months</description></item>
        /// <item><description>Y: years</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if the RenewalStatus parameter is set to AutoRenewal.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>M</para>
        /// </summary>
        [NameInMap("RenewalPeriodUnit")]
        [Validation(Required=false)]
        public string RenewalPeriodUnit { get; set; }

        /// <summary>
        /// <para>The status of renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AutoRenewal: The instance is automatically renewed.</description></item>
        /// <item><description>ManualRenewal: The instance is manually renewed.</description></item>
        /// <item><description>NotRenewal: The instance is not renewed.</description></item>
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
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Subscription: subscription</description></item>
        /// <item><description>PayAsYouGo: pay-as-you-go</description></item>
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
