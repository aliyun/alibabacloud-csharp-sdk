// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetAutoThrottleRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAutoThrottleRulesResponseBodyData Data { get; set; }
        public class GetAutoThrottleRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of database instances for which the automatic SQL throttling feature is currently enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EnableAutoThrottleCount")]
            [Validation(Required=false)]
            public long? EnableAutoThrottleCount { get; set; }

            /// <summary>
            /// <para>The database instances for which the automatic SQL throttling feature is currently enabled.</para>
            /// </summary>
            [NameInMap("EnableAutoThrottleList")]
            [Validation(Required=false)]
            public List<GetAutoThrottleRulesResponseBodyDataEnableAutoThrottleList> EnableAutoThrottleList { get; set; }
            public class GetAutoThrottleRulesResponseBodyDataEnableAutoThrottleList : TeaModel {
                /// <summary>
                /// <para>The maximum period of time during which an exception occurs when automatic SQL throttling is triggered. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("AbnormalDuration")]
                [Validation(Required=false)]
                public double? AbnormalDuration { get; set; }

                /// <summary>
                /// <para>The maximum number of active sessions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("ActiveSessions")]
                [Validation(Required=false)]
                public long? ActiveSessions { get; set; }

                /// <summary>
                /// <para>The end time of the throttling window. The value of this parameter is in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23:59Z</para>
                /// </summary>
                [NameInMap("AllowThrottleEndTime")]
                [Validation(Required=false)]
                public string AllowThrottleEndTime { get; set; }

                /// <summary>
                /// <para>The start time of the throttling window. The value of this parameter is in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00Z</para>
                /// </summary>
                [NameInMap("AllowThrottleStartTime")]
                [Validation(Required=false)]
                public string AllowThrottleStartTime { get; set; }

                /// <summary>
                /// <para>Indicates whether abnormal SQL statements in execution are terminated at a time. Valid values:</para>
                /// <remarks>
                /// <para>Abnormal SQL statements use the same template as the SQL statements that need to be throttled.</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoKillSession")]
                [Validation(Required=false)]
                public bool? AutoKillSession { get; set; }

                /// <summary>
                /// <para>The logical relationship between the CPU utilization threshold and the maximum number of active sessions. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>AND</b></description></item>
                /// <item><description><b>OR</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("CpuSessionRelation")]
                [Validation(Required=false)]
                public string CpuSessionRelation { get; set; }

                /// <summary>
                /// <para>The CPU utilization threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("CpuUsage")]
                [Validation(Required=false)]
                public double? CpuUsage { get; set; }

                /// <summary>
                /// <para>The database instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-2ze8g2am97624****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The maximum throttling duration. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MaxThrottleTime")]
                [Validation(Required=false)]
                public double? MaxThrottleTime { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that is used to create the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>140692647406****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>Indicates whether the automatic SQL throttling feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Visible")]
                [Validation(Required=false)]
                public bool? Visible { get; set; }

            }

            /// <summary>
            /// <para>The number of database instances that do not exist or for which the automatic SQL throttling feature has never been enabled.</para>
            /// <remarks>
            /// <para> If a database instance does not exist, the instance has been released or the specified instance ID is invalid.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NeverEnableAutoThrottleOrReleasedInstanceCount")]
            [Validation(Required=false)]
            public long? NeverEnableAutoThrottleOrReleasedInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of database instances that do not exist or for which the automatic SQL throttling feature has never been enabled.</para>
            /// <remarks>
            /// <para> If a database instance does not exist, the instance has been released or the specified instance ID is invalid.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("NeverEnableAutoThrottleOrReleasedInstanceIdList")]
            [Validation(Required=false)]
            public List<string> NeverEnableAutoThrottleOrReleasedInstanceIdList { get; set; }

            /// <summary>
            /// <para>The number of databases for which the automatic SQL throttling feature has been enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalAutoThrottleRulesCount")]
            [Validation(Required=false)]
            public long? TotalAutoThrottleRulesCount { get; set; }

            /// <summary>
            /// <para>The number of database instances for which the automatic SQL throttling feature was once enabled but is currently disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TurnOffAutoThrottleCount")]
            [Validation(Required=false)]
            public long? TurnOffAutoThrottleCount { get; set; }

            /// <summary>
            /// <para>The database instances for which the automatic SQL throttling feature was once enabled but is currently disabled.</para>
            /// </summary>
            [NameInMap("TurnOffAutoThrottleList")]
            [Validation(Required=false)]
            public List<GetAutoThrottleRulesResponseBodyDataTurnOffAutoThrottleList> TurnOffAutoThrottleList { get; set; }
            public class GetAutoThrottleRulesResponseBodyDataTurnOffAutoThrottleList : TeaModel {
                /// <summary>
                /// <para>The maximum period of time during which the automatic SQL throttling feature is triggered. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("AbnormalDuration")]
                [Validation(Required=false)]
                public double? AbnormalDuration { get; set; }

                /// <summary>
                /// <para>The maximum number of active sessions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64</para>
                /// </summary>
                [NameInMap("ActiveSessions")]
                [Validation(Required=false)]
                public long? ActiveSessions { get; set; }

                /// <summary>
                /// <para>The end time of the throttling window. The value of this parameter is in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23:59Z</para>
                /// </summary>
                [NameInMap("AllowThrottleEndTime")]
                [Validation(Required=false)]
                public string AllowThrottleEndTime { get; set; }

                /// <summary>
                /// <para>The start time of the throttling window. The value of this parameter is in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00Z</para>
                /// </summary>
                [NameInMap("AllowThrottleStartTime")]
                [Validation(Required=false)]
                public string AllowThrottleStartTime { get; set; }

                /// <summary>
                /// <para>Indicates whether abnormal SQL statements in execution are terminated at a time. Valid values:</para>
                /// <remarks>
                /// <para>Abnormal SQL statements use the same template as the SQL statements that need to be throttled.</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoKillSession")]
                [Validation(Required=false)]
                public bool? AutoKillSession { get; set; }

                /// <summary>
                /// <para>The logical relationship between the CPU utilization threshold and the maximum number of active sessions. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>AND</b></description></item>
                /// <item><description><b>OR</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OR</para>
                /// </summary>
                [NameInMap("CpuSessionRelation")]
                [Validation(Required=false)]
                public string CpuSessionRelation { get; set; }

                /// <summary>
                /// <para>The CPU utilization threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("CpuUsage")]
                [Validation(Required=false)]
                public double? CpuUsage { get; set; }

                /// <summary>
                /// <para>The database instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-2ze9xrhze0709****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The maximum throttling duration. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MaxThrottleTime")]
                [Validation(Required=false)]
                public double? MaxThrottleTime { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that is used to create the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>140692647406****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>Indicates whether the automatic SQL throttling feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Visible")]
                [Validation(Required=false)]
                public bool? Visible { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message that contains information such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7172BECE-588A-5961-8126-C216E16B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
