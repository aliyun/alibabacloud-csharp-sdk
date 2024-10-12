// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class FeedbackDialogueShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fcb14f25c9ee41ccad33a049de8f941b_p_outbound_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("CustomerResponse")]
        [Validation(Required=false)]
        public string CustomerResponse { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("GoodText")]
        [Validation(Required=false)]
        public string GoodText { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ModifiedResponse")]
        [Validation(Required=false)]
        public string ModifiedResponse { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>thumbsDown</para>
        /// </summary>
        [NameInMap("Rating")]
        [Validation(Required=false)]
        public string Rating { get; set; }

        [NameInMap("RatingTags")]
        [Validation(Required=false)]
        public string RatingTagsShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75bf82fa-b71b-45d7-ae40-0b00e496cd9e</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
