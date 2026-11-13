// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateModelOperatorServiceRequest : TeaModel {
        /// <summary>
        /// <para>The number of compute resource CUs for the model creation operator sub-service. The value must be an integer greater than 0. The available specifications and prices are subject to the actual sales configurations in the target region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Cu")]
        [Validation(Required=false)]
        public int? Cu { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PostPay: pay-as-you-go. This is the default value.</description></item>
        /// <item><description>PrePay: subscription. You must also specify UsedTime and Period.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPay</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. This parameter is required when PayType is set to PrePay. Valid values: Month and Year. This parameter is used together with UsedTime and is not required for pay-as-you-go.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the service belongs. This parameter is required and must be consistent with the request endpoint and the purchase region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The subscription duration. This parameter is required when PayType is set to PrePay. The value must be a positive integer string, and the unit is specified by Period. The actual available duration is subject to the sales configurations. This parameter is not required for pay-as-you-go.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

    }

}
