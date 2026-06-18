// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListTaskRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The current page number. The value must be greater than <b>0</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of items per page. The value must be greater than <b>0</b>. Default value: <b>20</b>.</para>
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
        /// <para>The robot name, which is the script name. You can view the names of scripts that have passed Review in the <a href="https://aiccs.console.aliyun.com/patter/list">Script Management</a> interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>机器人</para>
        /// </summary>
        [NameInMap("RobotName")]
        [Validation(Required=false)]
        public string RobotName { get; set; }

        /// <summary>
        /// <para>Job Status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>INIT</b>: Not started.</description></item>
        /// <item><description><b>RELEASE</b>: Parsing.</description></item>
        /// <item><description><b>RUNNING</b>: Executing.</description></item>
        /// <item><description><b>STOP</b>: Paused manually.</description></item>
        /// <item><description><b>SYSTEM_STOP</b>: Paused by the system.</description></item>
        /// <item><description><b>READY</b>: Pending execution.</description></item>
        /// <item><description><b>CANCEL</b>: Stopped manually.</description></item>
        /// <item><description><b>SYSTEM_CANCEL</b>: Stopped by the system.</description></item>
        /// <item><description><b>DONE</b>: Completed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>STOP</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The unique job ID of the robot calling job. You can view it in the <a href="https://aiccs.console.aliyun.com/job/list">Task Management</a> interface or obtain it by using the <a href="https://help.aliyun.com/document_detail/223556.html">CreateTask</a> API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The job name. You can view the names of created jobs in the <a href="https://aiccs.console.aliyun.com/job/list">Task Management</a> interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>任务测试</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
