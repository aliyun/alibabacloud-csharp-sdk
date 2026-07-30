// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ProjectAddRequest : TeaModel {
        /// <summary>
        /// <para>The project code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pro_code_5678</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Specifies whether to set a project manager.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("has_manager")]
        [Validation(Required=false)]
        public bool? HasManager { get; set; }

        /// <summary>
        /// <para>The project name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>商旅出差项目</para>
        /// </summary>
        [NameInMap("project_name")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The cost center ID associated with this project.</para>
        /// <list type="bullet">
        /// <item><description>You can obtain this value by calling the <a href="https://open.alibtrip.com/#/document/server/costcenterquery?handbookId=development-support">Query cost centers</a> operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1****01</para>
        /// </summary>
        [NameInMap("third_part_cost_center_id")]
        [Validation(Required=false)]
        public string ThirdPartCostCenterId { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project_1234</para>
        /// </summary>
        [NameInMap("third_part_id")]
        [Validation(Required=false)]
        public string ThirdPartId { get; set; }

        /// <summary>
        /// <para>The invoice title ID associated with this project.</para>
        /// <list type="bullet">
        /// <item><description>You can obtain this value by calling the <a href="https://open.alibtrip.com/#/document/server/invoicesearch?handbookId=development-support">Query available invoice titles for an enterprise or employee</a> operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4****9</para>
        /// </summary>
        [NameInMap("third_part_invoice_id")]
        [Validation(Required=false)]
        public string ThirdPartInvoiceId { get; set; }

    }

}
