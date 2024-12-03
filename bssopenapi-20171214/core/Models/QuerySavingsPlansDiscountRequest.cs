// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySavingsPlansDiscountRequest : TeaModel {
        /// <summary>
        /// <para>The code of the service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The cycle based on which queries are performed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1:Year</para>
        /// </summary>
        [NameInMap("Cycle")]
        [Validation(Required=false)]
        public string Cycle { get; set; }

        /// <summary>
        /// <para>The identifier of the language.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EN: English.</description></item>
        /// <item><description>ZH: Chinese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ZH</para>
        /// </summary>
        [NameInMap("Locale")]
        [Validation(Required=false)]
        public string Locale { get; set; }

        /// <summary>
        /// <para>The code of the pricing module.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance_type</para>
        /// </summary>
        [NameInMap("ModuleCode")]
        [Validation(Required=false)]
        public string ModuleCode { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The payment mode. Valid values: total: all upfront. half: half upfront. zero: no upfront.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>total</para>
        /// </summary>
        [NameInMap("PayMode")]
        [Validation(Required=false)]
        public string PayMode { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The type of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        [NameInMap("SpnCommodityCode")]
        [Validation(Required=false)]
        public string SpnCommodityCode { get; set; }

        /// <summary>
        /// <para>The type of the savings plan. Valid values: ecs: Elastic Compute Service (ECS) compute type. universal: general-purpose type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>universal</para>
        /// </summary>
        [NameInMap("SpnType")]
        [Validation(Required=false)]
        public string SpnType { get; set; }

    }

}
