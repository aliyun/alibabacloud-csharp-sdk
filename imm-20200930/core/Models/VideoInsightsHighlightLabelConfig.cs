// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class VideoInsightsHighlightLabelConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether highlight labels are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The list of labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<InsightsLabel> Labels { get; set; }

    }

}
