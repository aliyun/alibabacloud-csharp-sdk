// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class CreateServiceWorkOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>Interface status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data returned by the interface.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateServiceWorkOrderResponseBodyData Data { get; set; }
        public class CreateServiceWorkOrderResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Completion time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-07 16:45:01</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public long? CompleteTime { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-04T02:19:55Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>426556</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>Customer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1477832102462645</para>
            /// </summary>
            [NameInMap("CustomerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            /// <summary>
            /// <para>End time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24-03-11 00:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>Primary key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1978941</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>426556</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>Start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-21 15:25:25</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>Work order details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;questionDetail&quot;:&quot;测试工单&quot;,&quot;answerDetail&quot;:&quot;&quot;}</para>
            /// </summary>
            [NameInMap("WorkOrderDetail")]
            [Validation(Required=false)]
            public string WorkOrderDetail { get; set; }

            /// <summary>
            /// <para>Work order name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>安全月报交付任务</para>
            /// </summary>
            [NameInMap("WorkOrderName")]
            [Validation(Required=false)]
            public string WorkOrderName { get; set; }

            /// <summary>
            /// <para>Work order source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>工单迁移</para>
            /// </summary>
            [NameInMap("WorkOrderSource")]
            [Validation(Required=false)]
            public string WorkOrderSource { get; set; }

            /// <summary>
            /// <para>Work order status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UNPROCESSED</para>
            /// </summary>
            [NameInMap("WorkOrderStatus")]
            [Validation(Required=false)]
            public string WorkOrderStatus { get; set; }

            /// <summary>
            /// <para>Work order type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MONTH_REPORT</para>
            /// </summary>
            [NameInMap("WorkOrderType")]
            [Validation(Required=false)]
            public string WorkOrderType { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The prompt message of the returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7DC44321-7AAE-51CD-8E5F-CEB968569042</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the call was successful.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful. - <b>false</b>: The call failed.</description></item>
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
