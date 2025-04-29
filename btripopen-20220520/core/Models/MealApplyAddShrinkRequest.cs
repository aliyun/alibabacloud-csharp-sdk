// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MealApplyAddShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("apply_user")]
        [Validation(Required=false)]
        public string ApplyUserShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("cost_center_id")]
        [Validation(Required=false)]
        public long? CostCenterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("invoice_id")]
        [Validation(Required=false)]
        public long? InvoiceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("itinerary_list")]
        [Validation(Required=false)]
        public string ItineraryListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("meal_amount")]
        [Validation(Required=false)]
        public long? MealAmount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("meal_cause")]
        [Validation(Required=false)]
        public string MealCause { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>project123</para>
        /// </summary>
        [NameInMap("project_code")]
        [Validation(Required=false)]
        public string ProjectCode { get; set; }

        [NameInMap("project_title")]
        [Validation(Required=false)]
        public string ProjectTitle { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("third_part_apply_id")]
        [Validation(Required=false)]
        public string ThirdPartApplyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1200F00010</para>
        /// </summary>
        [NameInMap("third_part_cost_center_id")]
        [Validation(Required=false)]
        public string ThirdPartCostCenterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GA15131</para>
        /// </summary>
        [NameInMap("third_part_invoice_id")]
        [Validation(Required=false)]
        public string ThirdPartInvoiceId { get; set; }

    }

}
