// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class PublicTemplateStatus : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-08-28T12:00:00.000Z</para>
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
