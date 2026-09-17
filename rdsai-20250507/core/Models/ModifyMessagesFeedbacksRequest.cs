// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ModifyMessagesFeedbacksRequest : TeaModel {
        /// <summary>
        /// <para>The feedback content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unable to understand context; irrelevant answer</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The message ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yy9rkn6q-js75-0dka-0cc2-6b5o86uj****</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The rating.</para>
        /// 
        /// <b>Example:</b>
        /// <para>like</para>
        /// </summary>
        [NameInMap("Rating")]
        [Validation(Required=false)]
        public string Rating { get; set; }

        /// <summary>
        /// <para>The ContextDB workspace ID. Required only for ContextDB Manager App requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
