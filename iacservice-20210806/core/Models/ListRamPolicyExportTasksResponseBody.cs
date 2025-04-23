// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListRamPolicyExportTasksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ramPolicyExportTasks")]
        [Validation(Required=false)]
        public List<ListRamPolicyExportTasksResponseBodyRamPolicyExportTasks> RamPolicyExportTasks { get; set; }
        public class ListRamPolicyExportTasksResponseBodyRamPolicyExportTasks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-09-16T03:59:27Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("currentPolicyStatus")]
            [Validation(Required=false)]
            public string CurrentPolicyStatus { get; set; }

            [NameInMap("currentPolicyVersion")]
            [Validation(Required=false)]
            public string CurrentPolicyVersion { get; set; }

            [NameInMap("elapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            [NameInMap("exportTime")]
            [Validation(Required=false)]
            public string ExportTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mod-51fdfefa8788e82c9</para>
            /// </summary>
            [NameInMap("moduleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("moduleVersion")]
            [Validation(Required=false)]
            public string ModuleVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rpe-457ffe0252e48f9286a</para>
            /// </summary>
            [NameInMap("ramPolicyExportTaskId")]
            [Validation(Required=false)]
            public string RamPolicyExportTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345678/default/rampolicytask/rpe-4399111870d7e6b0f11a</para>
            /// </summary>
            [NameInMap("taskOutputPath")]
            [Validation(Required=false)]
            public string TaskOutputPath { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B6ED9F71-7FA8-598E-B64D-4606FB3FCCC9</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
