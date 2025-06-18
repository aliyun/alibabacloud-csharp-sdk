// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class AsyncUploadVideoRequest : TeaModel {
        [NameInMap("AnlysisPrompt")]
        [Validation(Required=false)]
        public string AnlysisPrompt { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SourceVideos")]
        [Validation(Required=false)]
        public List<AsyncUploadVideoRequestSourceVideos> SourceVideos { get; set; }
        public class AsyncUploadVideoRequestSourceVideos : TeaModel {
            [NameInMap("VideoExtraInfo")]
            [Validation(Required=false)]
            public string VideoExtraInfo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123.mp4</para>
            /// </summary>
            [NameInMap("VideoName")]
            [Validation(Required=false)]
            public string VideoName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("VideoUrl")]
            [Validation(Required=false)]
            public string VideoUrl { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
