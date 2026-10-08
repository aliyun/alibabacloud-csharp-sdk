// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class VideoInsightsConfig : TeaModel {
        /// <summary>
        /// <para>The video synopsis configuration.</para>
        /// </summary>
        [NameInMap("Caption")]
        [Validation(Required=false)]
        public VideoInsightsCaptionConfig Caption { get; set; }

        /// <summary>
        /// <para>The label configuration.</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public VideoInsightsLabelConfig Label { get; set; }

        /// <summary>
        /// <para>The video multi-stream configuration.</para>
        /// </summary>
        [NameInMap("MultiStream")]
        [Validation(Required=false)]
        public VideoInsightsMultiStreamConfig MultiStream { get; set; }

    }

}
