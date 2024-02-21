// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetAutoThrottleRulesResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAutoThrottleRulesResponseBodyData Data { get; set; }
        public class GetAutoThrottleRulesResponseBodyData : TeaModel {
            /// <summary>
            /// The number of database instances for which the automatic SQL throttling feature is currently enabled.
            /// </summary>
            [NameInMap("EnableAutoThrottleCount")]
            [Validation(Required=false)]
            public long? EnableAutoThrottleCount { get; set; }

            /// <summary>
            /// The database instances for which the automatic SQL throttling feature is currently enabled.
            /// </summary>
            [NameInMap("EnableAutoThrottleList")]
            [Validation(Required=false)]
            public List<GetAutoThrottleRulesResponseBodyDataEnableAutoThrottleList> EnableAutoThrottleList { get; set; }
            public class GetAutoThrottleRulesResponseBodyDataEnableAutoThrottleList : TeaModel {
                /// <summary>
                /// The maximum period of time during which an exception occurs when automatic SQL throttling is triggered. Unit: minutes.
                /// </summary>
                [NameInMap("AbnormalDuration")]
                [Validation(Required=false)]
                public double? AbnormalDuration { get; set; }

                /// <summary>
                /// The maximum number of active sessions.
                /// </summary>
                [NameInMap("ActiveSessions")]
                [Validation(Required=false)]
                public long? ActiveSessions { get; set; }

                /// <summary>
                /// The end time of the throttling window. The value of this parameter is in UTC.
                /// </summary>
                [NameInMap("AllowThrottleEndTime")]
                [Validation(Required=false)]
                public string AllowThrottleEndTime { get; set; }

                /// <summary>
                /// The start time of the throttling window. The value of this parameter is in UTC.
                /// </summary>
                [NameInMap("AllowThrottleStartTime")]
                [Validation(Required=false)]
                public string AllowThrottleStartTime { get; set; }

                /// <summary>
                /// Indicates whether abnormal SQL statements in execution are terminated at a time. Valid values:
                /// 
                /// > Abnormal SQL statements use the same template as the SQL statements that need to be throttled.
                /// 
                /// * **true**
                /// * **false**
                /// </summary>
                [NameInMap("AutoKillSession")]
                [Validation(Required=false)]
                public bool? AutoKillSession { get; set; }

                /// <summary>
                /// The logical relationship between the CPU utilization threshold and the maximum number of active sessions. Valid values:
                /// 
                /// * **AND**
                /// * **OR**
                /// </summary>
                [NameInMap("CpuSessionRelation")]
                [Validation(Required=false)]
                public string CpuSessionRelation { get; set; }

                /// <summary>
                /// The CPU utilization threshold.
                /// </summary>
                [NameInMap("CpuUsage")]
                [Validation(Required=false)]
                public double? CpuUsage { get; set; }

                /// <summary>
                /// The database instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The maximum throttling duration. Unit: minutes.
                /// </summary>
                [NameInMap("MaxThrottleTime")]
                [Validation(Required=false)]
                public double? MaxThrottleTime { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account that is used to create the database instance.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// Indicates whether the automatic SQL throttling feature is enabled. Valid values:
                /// 
                /// * **true**
                /// * **false**
                /// </summary>
                [NameInMap("Visible")]
                [Validation(Required=false)]
                public bool? Visible { get; set; }

            }

            /// <summary>
            /// The number of database instances that do not exist or for which the automatic SQL throttling feature has never been enabled.
            /// 
            /// >  If a database instance does not exist, the instance has been released or the specified instance ID is invalid.
            /// </summary>
            [NameInMap("NeverEnableAutoThrottleOrReleasedInstanceCount")]
            [Validation(Required=false)]
            public long? NeverEnableAutoThrottleOrReleasedInstanceCount { get; set; }

            /// <summary>
            /// The number of database instances that do not exist or for which the automatic SQL throttling feature has never been enabled.
            /// 
            /// >  If a database instance does not exist, the instance has been released or the specified instance ID is invalid.
            /// </summary>
            [NameInMap("NeverEnableAutoThrottleOrReleasedInstanceIdList")]
            [Validation(Required=false)]
            public List<string> NeverEnableAutoThrottleOrReleasedInstanceIdList { get; set; }

            /// <summary>
            /// The number of databases for which the automatic SQL throttling feature has been enabled.
            /// </summary>
            [NameInMap("TotalAutoThrottleRulesCount")]
            [Validation(Required=false)]
            public long? TotalAutoThrottleRulesCount { get; set; }

            /// <summary>
            /// The number of database instances for which the automatic SQL throttling feature was once enabled but is currently disabled.
            /// </summary>
            [NameInMap("TurnOffAutoThrottleCount")]
            [Validation(Required=false)]
            public long? TurnOffAutoThrottleCount { get; set; }

            /// <summary>
            /// The database instances for which the automatic SQL throttling feature was once enabled but is currently disabled.
            /// </summary>
            [NameInMap("TurnOffAutoThrottleList")]
            [Validation(Required=false)]
            public List<GetAutoThrottleRulesResponseBodyDataTurnOffAutoThrottleList> TurnOffAutoThrottleList { get; set; }
            public class GetAutoThrottleRulesResponseBodyDataTurnOffAutoThrottleList : TeaModel {
                /// <summary>
                /// The maximum period of time during which the automatic SQL throttling feature is triggered. Unit: minutes.
                /// </summary>
                [NameInMap("AbnormalDuration")]
                [Validation(Required=false)]
                public double? AbnormalDuration { get; set; }

                /// <summary>
                /// The maximum number of active sessions.
                /// </summary>
                [NameInMap("ActiveSessions")]
                [Validation(Required=false)]
                public long? ActiveSessions { get; set; }

                /// <summary>
                /// The end time of the throttling window. The value of this parameter is in UTC.
                /// </summary>
                [NameInMap("AllowThrottleEndTime")]
                [Validation(Required=false)]
                public string AllowThrottleEndTime { get; set; }

                /// <summary>
                /// The start time of the throttling window. The value of this parameter is in UTC.
                /// </summary>
                [NameInMap("AllowThrottleStartTime")]
                [Validation(Required=false)]
                public string AllowThrottleStartTime { get; set; }

                /// <summary>
                /// Indicates whether abnormal SQL statements in execution are terminated at a time. Valid values:
                /// 
                /// > Abnormal SQL statements use the same template as the SQL statements that need to be throttled.
                /// 
                /// * **true**
                /// * **false**
                /// </summary>
                [NameInMap("AutoKillSession")]
                [Validation(Required=false)]
                public bool? AutoKillSession { get; set; }

                /// <summary>
                /// The logical relationship between the CPU utilization threshold and the maximum number of active sessions. Valid values:
                /// 
                /// * **AND**
                /// * **OR**
                /// </summary>
                [NameInMap("CpuSessionRelation")]
                [Validation(Required=false)]
                public string CpuSessionRelation { get; set; }

                /// <summary>
                /// The CPU utilization threshold.
                /// </summary>
                [NameInMap("CpuUsage")]
                [Validation(Required=false)]
                public double? CpuUsage { get; set; }

                /// <summary>
                /// The database instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The maximum throttling duration. Unit: minutes.
                /// </summary>
                [NameInMap("MaxThrottleTime")]
                [Validation(Required=false)]
                public double? MaxThrottleTime { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account that is used to create the database instance.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// Indicates whether the automatic SQL throttling feature is enabled. Valid values:
                /// 
                /// * **true**
                /// * **false**
                /// </summary>
                [NameInMap("Visible")]
                [Validation(Required=false)]
                public bool? Visible { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, **Successful** is returned. If the request failed, an error message that contains information such as an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
