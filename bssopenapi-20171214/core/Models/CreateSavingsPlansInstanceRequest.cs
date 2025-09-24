// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class CreateSavingsPlansInstanceRequest : TeaModel {
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The code of the service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>savingplan_common_public_cn</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The service duration. This parameter is used together with the PricingCycle parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The time when the savings plan takes effect. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-31T00:00:00Z</para>
        /// </summary>
        [NameInMap("EffectiveDate")]
        [Validation(Required=false)]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// <para>The extended parameters.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("ExtendMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtendMap { get; set; }

        /// <summary>
        /// <para>The payment mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>total: all upfront</description></item>
        /// <item><description>half: partial upfront</description></item>
        /// <item><description>zero: no upfront</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>total</para>
        /// </summary>
        [NameInMap("PayMode")]
        [Validation(Required=false)]
        public string PayMode { get; set; }

        /// <summary>
        /// <para>The contracted amount. unit: CNY</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1</para>
        /// </summary>
        [NameInMap("PoolValue")]
        [Validation(Required=false)]
        public string PoolValue { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. This parameter is used together with Duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Year</description></item>
        /// <item><description>Month</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The ID of the region in which you create the savings plan. You must specify this parameter if the Type parameter is not set to universal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The specification type. This parameter is used together with the Specification parameter. You must specify this parameter if the Type parameter is not set to universal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>group: specification group</description></item>
        /// <item><description>family: specification family</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>family</para>
        /// </summary>
        [NameInMap("SpecType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

        /// <summary>
        /// <para>The specifications of the savings plan. This parameter is used together with the SpecType parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6</para>
        /// </summary>
        [NameInMap("Specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

        /// <summary>
        /// <para>The type of the savings plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>universal: general-purpose type</description></item>
        /// <item><description>ecs: Elastic Compute Service (ECS) compute type</description></item>
        /// <item><description>elasticy: elastic type</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>universal</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
