// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListVirusScanTaskStatusesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3D7EC0AF-DB2A-5D9C-90EC-F090A6BAAEA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ListVirusScanTaskStatusesResponseBodyTasks> Tasks { get; set; }
        public class ListVirusScanTaskStatusesResponseBodyTasks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>v1:1024772</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public ListVirusScanTaskStatusesResponseBodyTasksTaskStatus TaskStatus { get; set; }
            public class ListVirusScanTaskStatusesResponseBodyTasksTaskStatus : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("DeviceAckCount")]
                [Validation(Required=false)]
                public int? DeviceAckCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("DeviceResultFailCount")]
                [Validation(Required=false)]
                public int? DeviceResultFailCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DeviceResultSuccessCount")]
                [Validation(Required=false)]
                public int? DeviceResultSuccessCount { get; set; }

                /// <summary>
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
