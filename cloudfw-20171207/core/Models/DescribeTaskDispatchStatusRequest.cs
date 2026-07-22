// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTaskDispatchStatusRequest : TeaModel {
        /// <summary>
        /// <para>The task ID, which is the unique identifier of the log configuration modification task. Obtain this value from the TaskId response parameter of the ModifySlsDispatchConfig operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65db4ce2418b44b3be7c3xxxxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
