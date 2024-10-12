// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListHotTopicsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>下一页的token</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("TopicIds")]
        [Validation(Required=false)]
        public string TopicIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>根据热榜主题全文检索</para>
        /// </summary>
        [NameInMap("TopicQuery")]
        [Validation(Required=false)]
        public string TopicQuery { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>热榜源筛选，支持的热榜源。热榜源详见API：ListHotSources</para>
        /// </summary>
        [NameInMap("TopicSource")]
        [Validation(Required=false)]
        public string TopicSource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>数据版本筛选</para>
        /// </summary>
        [NameInMap("TopicVersion")]
        [Validation(Required=false)]
        public string TopicVersion { get; set; }

        [NameInMap("Topics")]
        [Validation(Required=false)]
        public string TopicsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WithNews")]
        [Validation(Required=false)]
        public bool? WithNews { get; set; }

    }

}
