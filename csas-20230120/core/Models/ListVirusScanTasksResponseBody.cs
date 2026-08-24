// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListVirusScanTasksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3D7EC0AF-DB2A-5D9C-90EC-F090A6BAAEA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<ListVirusScanTasksResponseBodyTasks> Tasks { get; set; }
        public class ListVirusScanTasksResponseBodyTasks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-08-21 10:24:31</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CustomMatchGroup")]
            [Validation(Required=false)]
            public List<ListVirusScanTasksResponseBodyTasksCustomMatchGroup> CustomMatchGroup { get; set; }
            public class ListVirusScanTasksResponseBodyTasksCustomMatchGroup : TeaModel {
                [NameInMap("Group")]
                [Validation(Required=false)]
                public List<string> Group { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>idp-7c3f9a2e5b18****</para>
                /// </summary>
                [NameInMap("IdpId")]
                [Validation(Required=false)]
                public string IdpId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1786377600</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Quarantine</para>
            /// </summary>
            [NameInMap("HighRiskOperation")]
            [Validation(Required=false)]
            public string HighRiskOperation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("LowRiskOperation")]
            [Validation(Required=false)]
            public string LowRiskOperation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UserGroupNormal</para>
            /// </summary>
            [NameInMap("MatchMode")]
            [Validation(Required=false)]
            public string MatchMode { get; set; }

            [NameInMap("MatchTargetInfos")]
            [Validation(Required=false)]
            public List<ListVirusScanTasksResponseBodyTasksMatchTargetInfos> MatchTargetInfos { get; set; }
            public class ListVirusScanTasksResponseBodyTasksMatchTargetInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>usergroup-9d4f2a7b3c1e****</para>
                /// </summary>
                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public string TargetId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>研发部门</para>
                /// </summary>
                [NameInMap("TargetName")]
                [Validation(Required=false)]
                public string TargetName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("MaxCpuUsage")]
            [Validation(Required=false)]
            public long? MaxCpuUsage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Notify</para>
            /// </summary>
            [NameInMap("MidRiskOperation")]
            [Validation(Required=false)]
            public string MidRiskOperation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Balance</para>
            /// </summary>
            [NameInMap("PerformanceMode")]
            [Validation(Required=false)]
            public string PerformanceMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Quick</para>
            /// </summary>
            [NameInMap("ScanMode")]
            [Validation(Required=false)]
            public string ScanMode { get; set; }

            [NameInMap("ScanPath")]
            [Validation(Required=false)]
            public List<string> ScanPath { get; set; }

            [NameInMap("ScanTargets")]
            [Validation(Required=false)]
            public List<string> ScanTargets { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>研发部门全盘扫描</para>
            /// </summary>
            [NameInMap("TaskDescription")]
            [Validation(Required=false)]
            public string TaskDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v1:1024772</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("Whitelist")]
            [Validation(Required=false)]
            public List<string> Whitelist { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
