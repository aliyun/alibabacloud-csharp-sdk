// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicTemplateStatus : TeaModel {
        /// <summary>
        /// <para>The time when the template reached the current desired state, in UTC and RFC 3339 format. This parameter is empty when the template is still being built or updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-20T08:35:12Z</para>
        /// </summary>
        [NameInMap("finishedAt")]
        [Validation(Required=false)]
        public string FinishedAt { get; set; }

        /// <summary>
        /// <para>The reason why the template entered a failure state. This parameter is returned only when state is error or updateFailed.</para>
        /// </summary>
        [NameInMap("reason")]
        [Validation(Required=false)]
        public PublicTemplateStatusReason Reason { get; set; }

        /// <summary>
        /// <para>The template status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>building: The template is being built.</description></item>
        /// <item><description>ready: The template is active.</description></item>
        /// <item><description>updating: The template is being updated.</description></item>
        /// <item><description>updateFailed: The template failed to be updated.</description></item>
        /// <item><description>error: The template failed to be built.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ready</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
