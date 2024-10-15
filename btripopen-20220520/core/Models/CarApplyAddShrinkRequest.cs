// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CarApplyAddShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("cause")]
        [Validation(Required=false)]
        public string Cause { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("city_code_set")]
        [Validation(Required=false)]
        public string CityCodeSet { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-12 14:52:52</para>
        /// </summary>
        [NameInMap("date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-07-12 18:51:25</para>
        /// </summary>
        [NameInMap("finished_date")]
        [Validation(Required=false)]
        public string FinishedDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>project1413</para>
        /// </summary>
        [NameInMap("project_code")]
        [Validation(Required=false)]
        public string ProjectCode { get; set; }

        [NameInMap("project_name")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

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
        /// <para>IRGS1413</para>
        /// </summary>
        [NameInMap("third_part_apply_id")]
        [Validation(Required=false)]
        public string ThirdPartApplyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>QA1411</para>
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("times_total")]
        [Validation(Required=false)]
        public int? TimesTotal { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("times_type")]
        [Validation(Required=false)]
        public int? TimesType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("times_used")]
        [Validation(Required=false)]
        public int? TimesUsed { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("traveler_standard")]
        [Validation(Required=false)]
        public string TravelerStandardShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OPEN1415614</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
