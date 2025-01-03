// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitSmartClipTaskShrinkRequest : TeaModel {
        [NameInMap("EditingConfig")]
        [Validation(Required=false)]
        public string EditingConfigShrink { get; set; }

        [NameInMap("ExtendParam")]
        [Validation(Required=false)]
        public string ExtendParam { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfigShrink { get; set; }

        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfigShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
