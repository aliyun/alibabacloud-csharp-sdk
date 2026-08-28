// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class ModifyDasOpsConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>SqlLogConfig</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyDasOpsConfigResponseBodyData Data { get; set; }
        public class ModifyDasOpsConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The payment method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prepay</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Managed Services instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-2zelo5v5u0678jx04</para>
            /// </summary>
            [NameInMap("CommodityInstanceId")]
            [Validation(Required=false)]
            public string CommodityInstanceId { get; set; }

            /// <summary>
            /// <para>Indicates whether DAS Economy Edition is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EcoEnable")]
            [Validation(Required=false)]
            public bool? EcoEnable { get; set; }

            /// <summary>
            /// <para>Indicates whether the Alibaba Cloud Managed Services feature is enabled (including DAS Economy Edition).</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The end time. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1608888296000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>Indicates whether Alibaba Cloud Managed Services is enabled.</para>
            /// </summary>
            [NameInMap("OpsEnable")]
            [Validation(Required=false)]
            public bool? OpsEnable { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>285412912420536</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1672531200000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: Pending scheduling.</description></item>
            /// <item><description><b>RUNNING</b>: Running.</description></item>
            /// <item><description><b>FAILED</b>: Failed.</description></item>
            /// <item><description><b>CANCELED</b>: Canceled.</description></item>
            /// <item><description><b>COMPLETED</b>: Completed.</description></item>
            /// </list>
            /// <remarks>
            /// <para>When the task is in the <b>COMPLETED</b> state, you can view the task result.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
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
