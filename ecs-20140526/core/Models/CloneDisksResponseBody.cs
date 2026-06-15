// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CloneDisksResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the disk clone task group. You can call the <a href="https://help.aliyun.com/zh/ecs/developer-reference/api-ecs-2014-05-26-describetasks">DescribeTasks</a> operation to query the execution result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g-2ze2op2grqpclwu7****</para>
        /// </summary>
        [NameInMap("TaskGroupId")]
        [Validation(Required=false)]
        public string TaskGroupId { get; set; }

    }

}
