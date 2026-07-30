// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class BtripBillInfoAdjustRequest : TeaModel {
        /// <summary>
        /// <para>The bill ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1002************464</para>
        /// </summary>
        [NameInMap("primary_id")]
        [Validation(Required=false)]
        public long? PrimaryId { get; set; }

        /// <summary>
        /// <para>The third-party cost center ID associated with this bill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cost_1234</para>
        /// </summary>
        [NameInMap("third_part_cost_center_id")]
        [Validation(Required=false)]
        public string ThirdPartCostCenterId { get; set; }

        /// <summary>
        /// <para>The third-party department ID associated with this bill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>depart_1234</para>
        /// </summary>
        [NameInMap("third_part_department_id")]
        [Validation(Required=false)]
        public string ThirdPartDepartmentId { get; set; }

        /// <summary>
        /// <para>The third-party invoice header ID associated with this bill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>invoice_1234</para>
        /// </summary>
        [NameInMap("third_part_invoice_id")]
        [Validation(Required=false)]
        public string ThirdPartInvoiceId { get; set; }

        /// <summary>
        /// <para>The third-party project ID associated with this bill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project_1234</para>
        /// </summary>
        [NameInMap("third_part_project_id")]
        [Validation(Required=false)]
        public string ThirdPartProjectId { get; set; }

        /// <summary>
        /// <para>The employee ID associated with this bill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_1234</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
