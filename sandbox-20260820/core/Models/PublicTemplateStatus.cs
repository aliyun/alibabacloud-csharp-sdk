// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicTemplateStatus : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-08-20T08:35:12Z</para>
        /// </summary>
        [NameInMap("finishedAt")]
        [Validation(Required=false)]
        public string FinishedAt { get; set; }

        [NameInMap("reason")]
        [Validation(Required=false)]
        public PublicTemplateStatusReason Reason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ready</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
