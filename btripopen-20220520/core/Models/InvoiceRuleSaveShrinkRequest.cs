// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InvoiceRuleSaveShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the invoice title applies to all employees. Valid values: true and false. This parameter is deprecated. Use the new field scope instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("all_employe")]
        [Validation(Required=false)]
        public bool? AllEmploye { get; set; }

        /// <summary>
        /// <para>This parameter is not required when all_employe is set to true. Otherwise, this parameter is required.</para>
        /// </summary>
        [NameInMap("entities")]
        [Validation(Required=false)]
        public string EntitiesShrink { get; set; }

        /// <summary>
        /// <para>The applicable scope. Valid values: 1 (all employees), 2 (partial), 3 (disabled). Either scope or all_employe is required. If scope has a value, all_employe does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public int? Scope { get; set; }

        /// <summary>
        /// <para>The third-party invoice ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i123</para>
        /// </summary>
        [NameInMap("third_part_id")]
        [Validation(Required=false)]
        public string ThirdPartId { get; set; }

    }

}
