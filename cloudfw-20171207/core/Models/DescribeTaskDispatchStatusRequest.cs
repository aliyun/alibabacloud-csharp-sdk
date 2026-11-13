// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTaskDispatchStatusRequest : TeaModel {
        /// <summary>
        /// <para>The task ID. It is the unique identifier of the log configuration modification task. You can obtain the task ID from the TaskId parameter in the response of the ModifySlsDispatchConfig operation.</para>
        /// <para><b>Note</b>: This parameter is required. If it is not provided, the server returns a 400 error and rejects the request. Make sure to specify a valid TaskId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65db4ce2418b44b3be7c3xxxxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
