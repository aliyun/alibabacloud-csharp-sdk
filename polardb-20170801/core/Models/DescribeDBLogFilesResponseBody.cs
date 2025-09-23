// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBLogFilesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pi-****************</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>polardb_mysql_rw</para>
        /// </summary>
        [NameInMap("DBInstanceType")]
        [Validation(Required=false)]
        public string DBInstanceType { get; set; }

        [NameInMap("HaLogItems")]
        [Validation(Required=false)]
        public List<DescribeDBLogFilesResponseBodyHaLogItems> HaLogItems { get; set; }
        public class DescribeDBLogFilesResponseBodyHaLogItems : TeaModel {
            [NameInMap("AffectedSessions")]
            [Validation(Required=false)]
            public long? AffectedSessions { get; set; }

            [NameInMap("FromDBType")]
            [Validation(Required=false)]
            public string FromDBType { get; set; }

            [NameInMap("SwitchCauseCode")]
            [Validation(Required=false)]
            public string SwitchCauseCode { get; set; }

            [NameInMap("SwitchCauseDetail")]
            [Validation(Required=false)]
            public string SwitchCauseDetail { get; set; }

            [NameInMap("SwitchFinishTime")]
            [Validation(Required=false)]
            public string SwitchFinishTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e571f897-9b3c-4012-9470-88333832dec4</para>
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

            [NameInMap("SwitchStartTime")]
            [Validation(Required=false)]
            public string SwitchStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SwitchType")]
            [Validation(Required=false)]
            public long? SwitchType { get; set; }

            [NameInMap("TotalSessions")]
            [Validation(Required=false)]
            public long? TotalSessions { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HaStatus")]
        [Validation(Required=false)]
        public int? HaStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ItemsNumbers")]
        [Validation(Required=false)]
        public int? ItemsNumbers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>24A1990B-4F6E-482B-B8CB-75C612******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SwitchListItems")]
        [Validation(Required=false)]
        public List<DescribeDBLogFilesResponseBodySwitchListItems> SwitchListItems { get; set; }
        public class DescribeDBLogFilesResponseBodySwitchListItems : TeaModel {
            [NameInMap("DBNodeCrashList")]
            [Validation(Required=false)]
            public List<string> DBNodeCrashList { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("EventFinishTime")]
            [Validation(Required=false)]
            public string EventFinishTime { get; set; }

            [NameInMap("EventStartTime")]
            [Validation(Required=false)]
            public string EventStartTime { get; set; }

            [NameInMap("FaultInjectionType")]
            [Validation(Required=false)]
            public string FaultInjectionType { get; set; }

            [NameInMap("SimulateListId")]
            [Validation(Required=false)]
            public string SimulateListId { get; set; }

            [NameInMap("SimulateMode")]
            [Validation(Required=false)]
            public string SimulateMode { get; set; }

            [NameInMap("SimulateStatus")]
            [Validation(Required=false)]
            public string SimulateStatus { get; set; }

            [NameInMap("SimulateTaskId")]
            [Validation(Required=false)]
            public string SimulateTaskId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("SwitchLogItems")]
            [Validation(Required=false)]
            public List<DescribeDBLogFilesResponseBodySwitchListItemsSwitchLogItems> SwitchLogItems { get; set; }
            public class DescribeDBLogFilesResponseBodySwitchListItemsSwitchLogItems : TeaModel {
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                [NameInMap("DstDbType")]
                [Validation(Required=false)]
                public string DstDbType { get; set; }

                [NameInMap("EventFinishTime")]
                [Validation(Required=false)]
                public string EventFinishTime { get; set; }

                [NameInMap("EventStartTime")]
                [Validation(Required=false)]
                public string EventStartTime { get; set; }

                [NameInMap("SimulateListId")]
                [Validation(Required=false)]
                public string SimulateListId { get; set; }

                [NameInMap("SimulateLogId")]
                [Validation(Required=false)]
                public string SimulateLogId { get; set; }

                [NameInMap("SimulateStatus")]
                [Validation(Required=false)]
                public string SimulateStatus { get; set; }

                [NameInMap("SrcDbType")]
                [Validation(Required=false)]
                public string SrcDbType { get; set; }

                [NameInMap("SwitchStepItems")]
                [Validation(Required=false)]
                public List<DescribeDBLogFilesResponseBodySwitchListItemsSwitchLogItemsSwitchStepItems> SwitchStepItems { get; set; }
                public class DescribeDBLogFilesResponseBodySwitchListItemsSwitchLogItemsSwitchStepItems : TeaModel {
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("IsSuccess")]
                    [Validation(Required=false)]
                    public string IsSuccess { get; set; }

                    [NameInMap("SimulatePhase")]
                    [Validation(Required=false)]
                    public string SimulatePhase { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("StepName")]
                    [Validation(Required=false)]
                    public string StepName { get; set; }

                    [NameInMap("TimeCost")]
                    [Validation(Required=false)]
                    public string TimeCost { get; set; }

                }

            }

            [NameInMap("SwitchStepItems")]
            [Validation(Required=false)]
            public List<DescribeDBLogFilesResponseBodySwitchListItemsSwitchStepItems> SwitchStepItems { get; set; }
            public class DescribeDBLogFilesResponseBodySwitchListItemsSwitchStepItems : TeaModel {
                [NameInMap("DBNodeId")]
                [Validation(Required=false)]
                public string DBNodeId { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("IsSuccess")]
                [Validation(Required=false)]
                public string IsSuccess { get; set; }

                [NameInMap("SimulatePhase")]
                [Validation(Required=false)]
                public string SimulatePhase { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("StepName")]
                [Validation(Required=false)]
                public string StepName { get; set; }

                [NameInMap("TimeCost")]
                [Validation(Required=false)]
                public string TimeCost { get; set; }

            }

        }

        [NameInMap("SwitchLogItems")]
        [Validation(Required=false)]
        public List<DescribeDBLogFilesResponseBodySwitchLogItems> SwitchLogItems { get; set; }
        public class DescribeDBLogFilesResponseBodySwitchLogItems : TeaModel {
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            [NameInMap("DstDbType")]
            [Validation(Required=false)]
            public string DstDbType { get; set; }

            [NameInMap("EventFinishTime")]
            [Validation(Required=false)]
            public string EventFinishTime { get; set; }

            [NameInMap("EventStartTime")]
            [Validation(Required=false)]
            public string EventStartTime { get; set; }

            [NameInMap("SimulateListId")]
            [Validation(Required=false)]
            public string SimulateListId { get; set; }

            [NameInMap("SimulateStatus")]
            [Validation(Required=false)]
            public string SimulateStatus { get; set; }

            [NameInMap("Simulatecode")]
            [Validation(Required=false)]
            public string Simulatecode { get; set; }

            [NameInMap("SrcDbType")]
            [Validation(Required=false)]
            public string SrcDbType { get; set; }

            [NameInMap("SwitchStepItems")]
            [Validation(Required=false)]
            public List<DescribeDBLogFilesResponseBodySwitchLogItemsSwitchStepItems> SwitchStepItems { get; set; }
            public class DescribeDBLogFilesResponseBodySwitchLogItemsSwitchStepItems : TeaModel {
                [NameInMap("DBNodeId")]
                [Validation(Required=false)]
                public string DBNodeId { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("IsSuccess")]
                [Validation(Required=false)]
                public string IsSuccess { get; set; }

                [NameInMap("SimulatePhase")]
                [Validation(Required=false)]
                public string SimulatePhase { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("StepMsg")]
                [Validation(Required=false)]
                public string StepMsg { get; set; }

                [NameInMap("StepName")]
                [Validation(Required=false)]
                public string StepName { get; set; }

                [NameInMap("TimeCost")]
                [Validation(Required=false)]
                public string TimeCost { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>160</para>
        /// </summary>
        [NameInMap("TotalRecords")]
        [Validation(Required=false)]
        public int? TotalRecords { get; set; }

    }

}
