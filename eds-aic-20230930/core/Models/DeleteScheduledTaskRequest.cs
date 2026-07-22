// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DeleteScheduledTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the scheduled task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sch-260705-agbx1eev</para>
        /// </summary>
        [NameInMap("ScheduledId")]
        [Validation(Required=false)]
        public string ScheduledId { get; set; }

    }

}
