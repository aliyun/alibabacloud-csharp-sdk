// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeInstanceGroupPriceRequest : TeaModel {
        /// <summary>
        /// <para>The number of instance groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>The ID of the bandwidth plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np-shdbbkdubb****</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imgc-0aae4rgm5umzo****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The instance group specifications.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acp.basic.small</para>
        /// </summary>
        [NameInMap("InstanceGroupSpec")]
        [Validation(Required=false)]
        public string InstanceGroupSpec { get; set; }

        /// <summary>
        /// <para>The instance version. You do not need to specify this parameter. The system automatically matches the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("InstanceVersion")]
        [Validation(Required=false)]
        public string InstanceVersion { get; set; }

        /// <summary>
        /// <para>The number of instances in the instance group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("NumberOfInstances")]
        [Validation(Required=false)]
        public int? NumberOfInstances { get; set; }

        /// <summary>
        /// <para>The order type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The subscription period. The unit is specified by PeriodUnit. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription period. Default value: Month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The ID of the promotion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88436689****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The sales mode. You do not need to specify this parameter. The system automatically matches the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("SaleMode")]
        [Validation(Required=false)]
        public string SaleMode { get; set; }

    }

}
