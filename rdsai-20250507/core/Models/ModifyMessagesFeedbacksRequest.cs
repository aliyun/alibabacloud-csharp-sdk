// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ModifyMessagesFeedbacksRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>app-iBuGU1VxEY42zrQRQfNA****</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>yy9rkn6q-js75-0dka-0cc2-6b5o86uj****</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>like</para>
        /// </summary>
        [NameInMap("Rating")]
        [Validation(Required=false)]
        public string Rating { get; set; }

    }

}
