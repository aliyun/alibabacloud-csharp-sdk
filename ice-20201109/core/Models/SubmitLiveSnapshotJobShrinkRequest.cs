// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitLiveSnapshotJobShrinkRequest : TeaModel {
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SnapshotOutput")]
        [Validation(Required=false)]
        public string SnapshotOutputShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StreamInput")]
        [Validation(Required=false)]
        public string StreamInputShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
