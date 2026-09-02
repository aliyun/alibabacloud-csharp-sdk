// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class PublicTemplateStatus : TeaModel {
        /// <summary>
        /// <para>The time when the build is completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-28T12:00:00.000Z</para>
        /// </summary>
        [NameInMap("finishedAt")]
        [Validation(Required=false)]
        public string FinishedAt { get; set; }

        /// <summary>
        /// <para>The reason for the build failure.</para>
        /// </summary>
        [NameInMap("reason")]
        [Validation(Required=false)]
        public PublicTemplateStatusReason Reason { get; set; }

        /// <summary>
        /// <para>The build status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ready</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
