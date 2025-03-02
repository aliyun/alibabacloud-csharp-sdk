// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class GetFoTaskStatusRequest : TeaModel {
        /// <summary>
        /// <para>The disaster recovery switchover task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2615</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public int? TaskId { get; set; }

    }

}
