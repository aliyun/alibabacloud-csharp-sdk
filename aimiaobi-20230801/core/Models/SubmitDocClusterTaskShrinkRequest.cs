// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitDocClusterTaskShrinkRequest : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Documents")]
        [Validation(Required=false)]
        public string DocumentsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>49</para>
        /// </summary>
        [NameInMap("SummaryLength")]
        [Validation(Required=false)]
        public int? SummaryLength { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>69</para>
        /// </summary>
        [NameInMap("TitleLength")]
        [Validation(Required=false)]
        public int? TitleLength { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TopicCount")]
        [Validation(Required=false)]
        public int? TopicCount { get; set; }

    }

}
