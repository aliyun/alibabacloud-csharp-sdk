// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListVirusScanTaskStatusesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3D7EC0AF-DB2A-5D9C-90EC-F090A6BAAEA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of execution progress for virus scan tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ListVirusScanTaskStatusesResponseBodyTasks> Tasks { get; set; }
        public class ListVirusScanTaskStatusesResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The virus scan task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1:1024772</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The execution progress measured by device count.</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public ListVirusScanTaskStatusesResponseBodyTasksTaskStatus TaskStatus { get; set; }
            public class ListVirusScanTaskStatusesResponseBodyTasksTaskStatus : TeaModel {
                /// <summary>
                /// <para>The number of user terminal devices that have received the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("DeviceAckCount")]
                [Validation(Required=false)]
                public int? DeviceAckCount { get; set; }

                /// <summary>
                /// <para>The number of user terminal devices on which the scan execution failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("DeviceResultFailCount")]
                [Validation(Required=false)]
                public int? DeviceResultFailCount { get; set; }

                /// <summary>
                /// <para>The number of user terminal devices on which the scan was executed successfully.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DeviceResultSuccessCount")]
                [Validation(Required=false)]
                public int? DeviceResultSuccessCount { get; set; }

                /// <summary>
                /// <para>The number of user terminal devices that are currently executing the scan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("DeviceStartCount")]
                [Validation(Required=false)]
                public int? DeviceStartCount { get; set; }

            }

        }

    }

}
