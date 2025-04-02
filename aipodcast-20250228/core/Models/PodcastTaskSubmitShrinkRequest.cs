// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIPodcast20250228.Models
{
    public class PodcastTaskSubmitShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("counts")]
        [Validation(Required=false)]
        public int? Counts { get; set; }

        [NameInMap("fileUrls")]
        [Validation(Required=false)]
        public string FileUrlsShrink { get; set; }

        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        [NameInMap("topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        [NameInMap("voices")]
        [Validation(Required=false)]
        public string VoicesShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-ep8ba0dr6seiddxx</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
