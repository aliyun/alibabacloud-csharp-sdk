// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class CreateRestoreTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>13FE89A5-C036-56BF-A0FF-A31C59819FD7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the restore job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>restore-fdsafda</para>
        /// </summary>
        [NameInMap("RestoreTaskId")]
        [Validation(Required=false)]
        public string RestoreTaskId { get; set; }

        /// <summary>
        /// <para>The status of the service instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Restoring: The service instance is being restored.</para>
        /// </description></item>
        /// <item><description><para>Restored: The service instance is restored.</para>
        /// </description></item>
        /// <item><description><para>RestoreFailed: The service instance failed to be restored.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Restoring</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
