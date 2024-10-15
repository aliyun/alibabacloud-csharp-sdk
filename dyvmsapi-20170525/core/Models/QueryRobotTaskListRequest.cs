// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryRobotTaskListRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The task state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>INIT</b>: The task is not started.</description></item>
        /// <item><description><b>READY</b>: The task is ready to start.</description></item>
        /// <item><description><b>DISPATCH</b>: The task is being parsed.</description></item>
        /// <item><description><b>EXCUTING</b>: The task is being executed.</description></item>
        /// <item><description><b>MANUAL_STOP</b>: The task is manually suspended.</description></item>
        /// <item><description><b>SYSTEM_STOP</b>: The task is suspended by the system.</description></item>
        /// <item><description><b>ARREARS_STOP</b>: The task is suspended due to overdue payments.</description></item>
        /// <item><description><b>CANCEL</b>: The task is manually canceled.</description></item>
        /// <item><description><b>SYSTEM_CANCEL</b>: The task is canceled by the system.</description></item>
        /// <item><description><b>FINISH</b>: The task is complete.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EXCUTING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test Template</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The date when the task is created, in the yyyy-MM-dd format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-06-14</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
