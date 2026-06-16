// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class QueryAsyncTaskResultRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the asynchronous task. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b67f6089-085a-9402-93c6-bac0561b3a06</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
