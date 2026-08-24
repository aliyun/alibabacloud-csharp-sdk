// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeAutoScalingHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The elastic scaling history records.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAutoScalingHistoryResponseBodyData Data { get; set; }
        public class DescribeAutoScalingHistoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Redis bandwidth elastic scaling history records. This parameter is not supported.</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Bandwidth { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-2ze1jdv45i7l6****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The Redis resource scaling history records. This parameter is not supported.</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Resource { get; set; }

            /// <summary>
            /// <para>The Redis automatic shard scaling history records. This parameter is not supported.</para>
            /// </summary>
            [NameInMap("Shard")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Shard { get; set; }

            /// <summary>
            /// <para>The automatic performance extension history records.</para>
            /// </summary>
            [NameInMap("SpecHistory")]
            [Validation(Required=false)]
            public List<DescribeAutoScalingHistoryResponseBodyDataSpecHistory> SpecHistory { get; set; }
            public class DescribeAutoScalingHistoryResponseBodyDataSpecHistory : TeaModel {
                /// <summary>
                /// <para>The error code returned by the internal scaling task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Insufficient_Balance</b>: The account balance is insufficient or there are unpaid orders.</description></item>
                /// <item><description><b>REACH_SPEC_UPPERBOUND</b>: The upper limit of the instance specification has been reached.</description></item>
                /// <item><description><b>Control_Error_Timeout_Msg</b>: The control task timed out.</description></item>
                /// <item><description><b>Invoke_Rds_Api_Error_Msg</b>: Failed to call the RDS API.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Insufficient_Balance</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The number of CPU cores of the original instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("OriginCore")]
                [Validation(Required=false)]
                public int? OriginCore { get; set; }

                /// <summary>
                /// <para>The original instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql.n2.large.2c</para>
                /// </summary>
                [NameInMap("OriginInstanceClass")]
                [Validation(Required=false)]
                public string OriginInstanceClass { get; set; }

                /// <summary>
                /// <para>The memory size of the original instance. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("OriginMemory")]
                [Validation(Required=false)]
                public double? OriginMemory { get; set; }

                /// <summary>
                /// <para>The type of the automatic performance extension task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SCALE_UP</b>: Automatic specification extension.</description></item>
                /// <item><description><b>SCALE_DOWN</b>: Automatic specification scale-down.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SCALE_UP</para>
                /// </summary>
                [NameInMap("ScaleType")]
                [Validation(Required=false)]
                public string ScaleType { get; set; }

                /// <summary>
                /// <para>The number of CPU cores of the target instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("TargetCore")]
                [Validation(Required=false)]
                public int? TargetCore { get; set; }

                /// <summary>
                /// <para>The target instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql.n2.xlarge.2c</para>
                /// </summary>
                [NameInMap("TargetInstanceClass")]
                [Validation(Required=false)]
                public string TargetInstanceClass { get; set; }

                /// <summary>
                /// <para>The memory size of the target instance. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("TargetMemory")]
                [Validation(Required=false)]
                public double? TargetMemory { get; set; }

                /// <summary>
                /// <para>The task execution status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The task was executed successfully.</description></item>
                /// <item><description><b>false</b>: The task failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TaskExcuteStatus")]
                [Validation(Required=false)]
                public bool? TaskExcuteStatus { get; set; }

                /// <summary>
                /// <para>The task execution time. The value is a UNIX timestamp. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1684830763000</para>
                /// </summary>
                [NameInMap("TaskTime")]
                [Validation(Required=false)]
                public long? TaskTime { get; set; }

            }

            /// <summary>
            /// <para>The storage expansion history records. This parameter is not supported.</para>
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Storage { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, an error message such as an error code is returned.</para>
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
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
