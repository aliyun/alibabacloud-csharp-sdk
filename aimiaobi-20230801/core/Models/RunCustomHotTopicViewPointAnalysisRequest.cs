// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunCustomHotTopicViewPointAnalysisRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>模型反问</para>
        /// </summary>
        [NameInMap("AskUser")]
        [Validation(Required=false)]
        public string AskUser { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>自定义选题视角的Prompt</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>改写后的Query</para>
        /// </summary>
        [NameInMap("SearchQuery")]
        [Validation(Required=false)]
        public string SearchQuery { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SkipAskUser")]
        [Validation(Required=false)]
        public bool? SkipAskUser { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>热点主题</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>热点主题ID</para>
        /// </summary>
        [NameInMap("TopicId")]
        [Validation(Required=false)]
        public string TopicId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>热点主题来源</para>
        /// </summary>
        [NameInMap("TopicSource")]
        [Validation(Required=false)]
        public string TopicSource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>热点主题版本</para>
        /// </summary>
        [NameInMap("TopicVersion")]
        [Validation(Required=false)]
        public string TopicVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>用户反馈</para>
        /// </summary>
        [NameInMap("UserBack")]
        [Validation(Required=false)]
        public string UserBack { get; set; }

        /// <summary>
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
