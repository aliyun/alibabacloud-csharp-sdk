// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetAliDingMinutesContentRequest : TeaModel {
        /// <summary>
        /// <para>The DingTalk minutes ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76327569643231383535353939365f3436383537393431335f32</para>
        /// </summary>
        [NameInMap("minutesId")]
        [Validation(Required=false)]
        public string MinutesId { get; set; }

        /// <summary>
        /// <para>The ID of the effective tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
