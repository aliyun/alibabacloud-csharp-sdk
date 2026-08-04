// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetWmEmbedTaskRequest : TeaModel {
        /// <summary>
        /// <para>The job ID obtained when creating the embedding job. Source of the value:  </para>
        /// <list type="bullet">
        /// <item><description><a href="~~CreateWmEmbedTask~~">CreateWmEmbedTask</a>: Create a watermark embedding job.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job:5GfrJYsoaffmCE7Z5bZtjU********</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
