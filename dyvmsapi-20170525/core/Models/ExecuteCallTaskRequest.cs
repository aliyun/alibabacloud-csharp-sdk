// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ExecuteCallTaskRequest : TeaModel {
        /// <summary>
        /// <para>The time when the call task is executed, in the yyyy-MM-dd HH:mm:ss format.</para>
        /// <remarks>
        /// <para>You can leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-03-09 00:00:00</para>
        /// </summary>
        [NameInMap("FireTime")]
        [Validation(Required=false)]
        public string FireTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The task state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RUNNING</b></description></item>
        /// <item><description><b>STOP</b></description></item>
        /// <item><description><b>CANCEL</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task ID. You can call the <a href="~~CreateCallTask~~">CreateCallTask</a> operation to obtain the task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2256****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
