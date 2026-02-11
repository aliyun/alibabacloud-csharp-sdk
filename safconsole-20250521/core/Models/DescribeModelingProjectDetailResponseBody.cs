// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20250521.Models
{
    public class DescribeModelingProjectDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. A return value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4A91D2D1-AEC9-1658-ABCE-5A39DE66A5C2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeModelingProjectDetailResponseBodyResultObject ResultObject { get; set; }
        public class DescribeModelingProjectDetailResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>End time of the security modeling project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-02-07T02:22:30Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>Security environment status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("EnvStatus")]
            [Validation(Required=false)]
            public string EnvStatus { get; set; }

            /// <summary>
            /// <para>Login account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("LoginAccount")]
            [Validation(Required=false)]
            public string LoginAccount { get; set; }

            /// <summary>
            /// <para>Machine specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SECURE_ENV_LITE</para>
            /// </summary>
            [NameInMap("MachineSpec")]
            [Validation(Required=false)]
            public string MachineSpec { get; set; }

            /// <summary>
            /// <para>Manual operation phase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INIT</para>
            /// </summary>
            [NameInMap("ManualPhase")]
            [Validation(Required=false)]
            public string ManualPhase { get; set; }

            /// <summary>
            /// <para>Modeling project status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PREPARING</para>
            /// </summary>
            [NameInMap("ModelingStatus")]
            [Validation(Required=false)]
            public string ModelingStatus { get; set; }

            /// <summary>
            /// <para>Associated POC tasks.</para>
            /// </summary>
            [NameInMap("PocTasks")]
            [Validation(Required=false)]
            public List<DescribeModelingProjectDetailResponseBodyResultObjectPocTasks> PocTasks { get; set; }
            public class DescribeModelingProjectDetailResponseBodyResultObjectPocTasks : TeaModel {
                /// <summary>
                /// <para>Retrospective file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx.csv</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>Service code</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("ServiceCode")]
                [Validation(Required=false)]
                public string ServiceCode { get; set; }

                /// <summary>
                /// <para>File synchronization status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Retrospective task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

            }

            /// <summary>
            /// <para>Project ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>01</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>Project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project_01</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>Remark information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>remark</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>Start time of the security modeling project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-13T01:09:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>Synchronized files.</para>
            /// </summary>
            [NameInMap("SyncedFiles")]
            [Validation(Required=false)]
            public List<DescribeModelingProjectDetailResponseBodyResultObjectSyncedFiles> SyncedFiles { get; set; }
            public class DescribeModelingProjectDetailResponseBodyResultObjectSyncedFiles : TeaModel {
                /// <summary>
                /// <para>Whether deployment is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Deployable")]
                [Validation(Required=false)]
                public bool? Deployable { get; set; }

                /// <summary>
                /// <para>Files generated by modeling.</para>
                /// </summary>
                [NameInMap("Files")]
                [Validation(Required=false)]
                public List<DescribeModelingProjectDetailResponseBodyResultObjectSyncedFilesFiles> Files { get; set; }
                public class DescribeModelingProjectDetailResponseBodyResultObjectSyncedFilesFiles : TeaModel {
                    /// <summary>
                    /// <para>Whether it is downloadable.</para>
                    /// </summary>
                    [NameInMap("Downloadable")]
                    [Validation(Required=false)]
                    public bool? Downloadable { get; set; }

                    /// <summary>
                    /// <para>The ID of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>376920</para>
                    /// </summary>
                    [NameInMap("FileId")]
                    [Validation(Required=false)]
                    public long? FileId { get; set; }

                    /// <summary>
                    /// <para>The name of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>融山-个贷-精催-演示-0625.json</para>
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <para>Visibility:</para>
                    /// <para><b>true</b>: Visible</para>
                    /// <para><b>false</b>: Not visible</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Visible")]
                    [Validation(Required=false)]
                    public bool? Visible { get; set; }

                }

                /// <summary>
                /// <para>Application group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>56790766</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// <para>File group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>am</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>Synchronization time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1770607862000</para>
                /// </summary>
                [NameInMap("SyncedTime")]
                [Validation(Required=false)]
                public string SyncedTime { get; set; }

            }

        }

        /// <summary>
        /// <para>Whether the call was successful.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Call succeeded.</description></item>
        /// <item><description><b>false</b>: Call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
