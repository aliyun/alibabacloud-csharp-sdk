// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitSnapshotJobShrinkRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string InputShrink { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string OutputShrink { get; set; }

        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public string ScheduleConfigShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfigShrink { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
