// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class CancelC2paBucketSignTaskRequest : TeaModel {
        /// <summary>
        /// <para>The parent task ID of the bucket returned by CreateC2paBucketSignTask.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>047b8305-9572-4eed-b7fb-8588b989b6e5</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
