// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetAsyncTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the asynchronous task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>000e89fb-cf8f-11e9-8ab4-b6e980803a3b</para>
        /// </summary>
        [NameInMap("async_task_id")]
        [Validation(Required=false)]
        public string AsyncTaskId { get; set; }

    }

}
