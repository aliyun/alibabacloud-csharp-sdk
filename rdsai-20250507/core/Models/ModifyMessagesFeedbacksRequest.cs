// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ModifyMessagesFeedbacksRequest : TeaModel {
        /// <summary>
        /// <para>The rating of the message.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>like</description></item>
        /// <item><description>dislike</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform. Set the value to <b>ModifyMessagesFeedbacks</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yy9rkn6q-js75-0dka-0cc2-6b5o86uj****</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The message ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>like</para>
        /// </summary>
        [NameInMap("Rating")]
        [Validation(Required=false)]
        public string Rating { get; set; }

    }

}
