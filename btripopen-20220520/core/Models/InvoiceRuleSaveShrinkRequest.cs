// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InvoiceRuleSaveShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("all_employe")]
        [Validation(Required=false)]
        public bool? AllEmploye { get; set; }

        [NameInMap("entities")]
        [Validation(Required=false)]
        public string EntitiesShrink { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public int? Scope { get; set; }

        /// <summary>
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
