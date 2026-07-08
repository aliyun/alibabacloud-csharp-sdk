// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitCustomHotTopicBroadcastJobShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The configuration for the news broadcast job.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("HotTopicBroadcastConfig")]
        [Validation(Required=false)]
        public string HotTopicBroadcastConfigShrink { get; set; }

        /// <summary>
        /// <para>The version of the hot topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>热点版本</para>
        /// </summary>
        [NameInMap("HotTopicVersion")]
        [Validation(Required=false)]
        public string HotTopicVersion { get; set; }

        /// <summary>
        /// <para>The topic filter.</para>
        /// </summary>
        [NameInMap("Topics")]
        [Validation(Required=false)]
        public string TopicsShrink { get; set; }

        /// <summary>
        /// <para>The unique identifier of the Alibaba Cloud Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Get a workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
