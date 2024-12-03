// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ConvertChargeTypeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
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
        /// <para>The subscription duration. Unit: months. This parameter is required if you switch the billing method to subscription. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1 to 9</description></item>
        /// <item><description>12</description></item>
        /// <item><description>24</description></item>
        /// <item><description>36</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The code of the service to which the instance belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The type of the service to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Subscription: subscription</description></item>
        /// <item><description>PayAsYouGo: pay-as-you-go</description></item>
        /// </list>
        /// <remarks>
        /// <para> After the call is successful, the billing method of the instance is switched.</para>
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
