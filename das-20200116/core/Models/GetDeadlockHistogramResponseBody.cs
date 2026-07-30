// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetDeadlockHistogramResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetDeadlockHistogramResponseBodyData> Data { get; set; }
        public class GetDeadlockHistogramResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The end time of the analysis task range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1729998000000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-bp1u5mas9exx7****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The number of deadlocks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("LockNumber")]
            [Validation(Required=false)]
            public int? LockNumber { get; set; }

            /// <summary>
            /// <para>The node ID, used for PolarDB MySQL clusters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-bp16v3824rt73****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The start time of the analysis task range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1729994400000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The task status:</para>
            /// <list type="bullet">
            /// <item><description><para><b>SUCCESS</b>: The analysis was successful.</para>
            /// </description></item>
            /// <item><description><para><b>FAILED</b>: The analysis was abnormal or failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the full deadlock analysis task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B6D17591-B48B-4D31-9CD6-1321B394****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>108************</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// <remarks>
        /// <para>When the request is successful, this parameter returns <b>Successful</b>. When the request fails, this parameter returns exception information such as error codes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A74B755-98B7-59DB-8724-1321B394****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
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
