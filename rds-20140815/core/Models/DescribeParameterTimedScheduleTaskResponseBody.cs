// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeParameterTimedScheduleTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A807C95D-410C-5BB5-96C0-C6E09F2C3D36</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of scan jobs.</para>
        /// </summary>
        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<DescribeParameterTimedScheduleTaskResponseBodyTaskList> TaskList { get; set; }
        public class DescribeParameterTimedScheduleTaskResponseBodyTaskList : TeaModel {
            /// <summary>
            /// <para>Instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-2ze2za3is7baay****</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>Modified parameter settings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;auto_increment_increment&quot;:&quot;1000&quot;,&quot;back_log&quot;:&quot;99&quot;}</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            /// <summary>
            /// <para>Status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PENDING</b>: Pending execution.</description></item>
            /// <item><description><b>EXECUTING</b>: Executing.</description></item>
            /// <item><description><b>COMPLETED</b>: Completed.</description></item>
            /// <item><description><b>EXECUTING</b>: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Effective period for the parameter modification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-06T09:24:00Z</para>
            /// </summary>
            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

            /// <summary>
            /// <para>Scheduled task ID for parameter modification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27056921</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
