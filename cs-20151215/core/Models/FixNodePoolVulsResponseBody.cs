// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class FixNodePoolVulsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the CVE patching task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>T-60fea8ad2e277f087900****</para>
        /// </summary>
        [NameInMap("task_id")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
