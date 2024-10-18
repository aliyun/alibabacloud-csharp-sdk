// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class AssignTicketShrinkRequest : TeaModel {
        [NameInMap("Notify")]
        [Validation(Required=false)]
        public string NotifyShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eKWh3xxxxiE</para>
        /// </summary>
        [NameInMap("OpenTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dq9hP8Sk2v6vQxxxxiE</para>
        /// </summary>
        [NameInMap("OpenTicketId")]
        [Validation(Required=false)]
        public string OpenTicketId { get; set; }

        [NameInMap("ProcessorUserIds")]
        [Validation(Required=false)]
        public string ProcessorUserIdsShrink { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        [NameInMap("TicketMemo")]
        [Validation(Required=false)]
        public string TicketMemoShrink { get; set; }

    }

}
