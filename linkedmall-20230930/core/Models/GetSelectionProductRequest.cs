// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class GetSelectionProductRequest : TeaModel {
        /// <summary>
        /// <para>Region code (use a five-level township or subdistrict address code)</para>
        /// 
        /// <b>Example:</b>
        /// <para>330106109</para>
        /// </summary>
        [NameInMap("divisionCode")]
        [Validation(Required=false)]
        public string DivisionCode { get; set; }

        /// <summary>
        /// <para>Purchaser ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PID22000009</para>
        /// </summary>
        [NameInMap("purchaserId")]
        [Validation(Required=false)]
        public string PurchaserId { get; set; }

    }

}
