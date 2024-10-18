// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class UpdateScheduleConfSettingsShrinkRequest : TeaModel {
        [NameInMap("ScheduleConfSettingModel")]
        [Validation(Required=false)]
        public string ScheduleConfSettingModelShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>f6fb627e-a7e8-403e-b1f8-26e85450f4a9</para>
        /// </summary>
        [NameInMap("ScheduleConferenceId")]
        [Validation(Required=false)]
        public string ScheduleConferenceId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

    }

}
