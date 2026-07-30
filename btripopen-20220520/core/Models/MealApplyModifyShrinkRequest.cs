// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MealApplyModifyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The applicant.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("apply_user")]
        [Validation(Required=false)]
        public string ApplyUserShrink { get; set; }

        /// <summary>
        /// <para>The internal cost center ID in Alibaba Business Travel associated with the application. You can specify either this parameter or the third-party cost center ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("cost_center_id")]
        [Validation(Required=false)]
        public long? CostCenterId { get; set; }

        /// <summary>
        /// <para>The extended information.</para>
        /// <para>You can pass supplementary descriptions in this field. The corresponding content is displayed in the bill. This field is typically used for enterprise travel statistics and reconciliation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;extend_key&quot;:&quot;extend_value&quot;}</para>
        /// </summary>
        [NameInMap("extend_field")]
        [Validation(Required=false)]
        public string ExtendField { get; set; }

        /// <summary>
        /// <para>The internal invoice header ID in Alibaba Business Travel. You can specify either this parameter or the third-party invoice header ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("invoice_id")]
        [Validation(Required=false)]
        public long? InvoiceId { get; set; }

        /// <summary>
        /// <para>The meal itinerary.</para>
        /// </summary>
        [NameInMap("itinerary_list")]
        [Validation(Required=false)]
        public string ItineraryListShrink { get; set; }

        /// <summary>
        /// <para>The meal amount limit.</para>
        /// <remarks>
        /// <para>Currency: CNY. Unit: cents.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("meal_amount")]
        [Validation(Required=false)]
        public long? MealAmount { get; set; }

        /// <summary>
        /// <para>The reason for the meal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("meal_cause")]
        [Validation(Required=false)]
        public string MealCause { get; set; }

        /// <summary>
        /// <para>The project code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project123</para>
        /// </summary>
        [NameInMap("project_code")]
        [Validation(Required=false)]
        public string ProjectCode { get; set; }

        /// <summary>
        /// <para>The project name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>项目1</para>
        /// </summary>
        [NameInMap("project_title")]
        [Validation(Required=false)]
        public string ProjectTitle { get; set; }

        /// <summary>
        /// <para>The status of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The third-party approval ID.</para>
        /// <remarks>
        /// <para>We recommend that you enter a unique identifier. It is displayed in the application, order, and bill in Alibaba Business Travel.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("third_part_apply_id")]
        [Validation(Required=false)]
        public string ThirdPartApplyId { get; set; }

        /// <summary>
        /// <para>The third-party cost center ID associated with the application. You can specify either this parameter or the Alibaba Business Travel cost center ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1200F00010</para>
        /// </summary>
        [NameInMap("third_part_cost_center_id")]
        [Validation(Required=false)]
        public string ThirdPartCostCenterId { get; set; }

        /// <summary>
        /// <para>The third-party invoice header ID. You can specify either this parameter or the Alibaba Business Travel invoice header ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GA15131</para>
        /// </summary>
        [NameInMap("third_part_invoice_id")]
        [Validation(Required=false)]
        public string ThirdPartInvoiceId { get; set; }

    }

}
