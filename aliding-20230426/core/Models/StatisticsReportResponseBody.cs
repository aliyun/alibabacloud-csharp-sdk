// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class StatisticsReportResponseBody : TeaModel {
        [NameInMap("commentNum")]
        [Validation(Required=false)]
        public long? CommentNum { get; set; }

        [NameInMap("commentUserNum")]
        [Validation(Required=false)]
        public long? CommentUserNum { get; set; }

        [NameInMap("likeNum")]
        [Validation(Required=false)]
        public long? LikeNum { get; set; }

        [NameInMap("readNum")]
        [Validation(Required=false)]
        public long? ReadNum { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
