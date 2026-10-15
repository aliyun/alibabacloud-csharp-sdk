// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ConvertChargeTypeRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-kasjgfjshgf</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The subscription period in months. If you convert the billing method to subscription, specify the subscription period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1 to 9.</description></item>
        /// <item><description><ol start="12">
        /// <item><description></description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="24">
        /// <item><description></description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="36">
        /// <item><description></description></item>
        /// </ol>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

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
        /// <para>The current billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Subscription: subscription.</description></item>
        /// <item><description>PayAsYouGo: pay-as-you-go.</description></item>
        /// </list>
        /// <remarks>
        /// <para>After a successful call, the resource is changed to the opposite billing method.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Subscription</para>
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

    }

}
