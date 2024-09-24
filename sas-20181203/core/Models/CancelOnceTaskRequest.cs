// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CancelOnceTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the task.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~GenerateOnceTask~~">GenerateOnceTask</a> operation to query the IDs of tasks.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ec9c0d88f36cc27765a98c554ee2****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
