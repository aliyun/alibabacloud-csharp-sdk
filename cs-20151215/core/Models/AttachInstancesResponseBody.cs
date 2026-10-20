// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class AttachInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of node addition information.</para>
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<AttachInstancesResponseBodyList> List { get; set; }
        public class AttachInstancesResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The status code of the node addition result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The ECS instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2ze0lgm3y6iylcbt****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The description of the node addition result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>successful</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>T-5a544aff80282e39ea00****</para>
        /// </summary>
        [NameInMap("task_id")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
