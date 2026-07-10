// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MealApplyModifyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("apply_user")]
        [Validation(Required=false)]
        public string ApplyUserShrink { get; set; }

        [NameInMap("cost_center_id")]
        [Validation(Required=false)]
        public long? CostCenterId { get; set; }

        [NameInMap("extend_field")]
        [Validation(Required=false)]
        public string ExtendField { get; set; }

        [NameInMap("invoice_id")]
        [Validation(Required=false)]
        public long? InvoiceId { get; set; }

        [NameInMap("itinerary_list")]
        [Validation(Required=false)]
        public string ItineraryListShrink { get; set; }

        [NameInMap("meal_amount")]
        [Validation(Required=false)]
        public long? MealAmount { get; set; }

        [NameInMap("meal_cause")]
        [Validation(Required=false)]
        public string MealCause { get; set; }

        [NameInMap("project_code")]
        [Validation(Required=false)]
        public string ProjectCode { get; set; }

        [NameInMap("project_title")]
        [Validation(Required=false)]
        public string ProjectTitle { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("third_part_apply_id")]
        [Validation(Required=false)]
        public string ThirdPartApplyId { get; set; }

        [NameInMap("third_part_cost_center_id")]
        [Validation(Required=false)]
        public string ThirdPartCostCenterId { get; set; }

        [NameInMap("third_part_invoice_id")]
        [Validation(Required=false)]
        public string ThirdPartInvoiceId { get; set; }

    }

}
