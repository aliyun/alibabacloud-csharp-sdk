// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: indicates that the request was successful.</description></item>
        /// <item><description><b>3xx</b>: indicates that the request was redirected.</description></item>
        /// <item><description><b>4xx</b>: indicates that the request was invalid.</description></item>
        /// <item><description><b>5xx</b>: indicates that a server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationStatusResponseBodyData Data { get; set; }
        public class DescribeApplicationStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0099b7be-5f5b-4512-a7fc-56049ef1****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>Indicates whether Application Real-Time Monitoring Service (ARMS) advanced monitoring is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ArmsAdvancedEnabled")]
            [Validation(Required=false)]
            public string ArmsAdvancedEnabled { get; set; }

            /// <summary>
            /// <para>The metadata of the application in ARMS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;appId&quot;:&quot;0099b7be-5f5b-4512-a7fc-56049ef1****&quot;,&quot;licenseKey&quot;:&quot;d5cgdt5pu0@7303f55292a****&quot;}</para>
            /// </summary>
            [NameInMap("ArmsApmInfo")]
            [Validation(Required=false)]
            public string ArmsApmInfo { get; set; }

            /// <summary>
            /// <para>The time when the application was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1563373372746</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The current state of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RUNNING</b></description></item>
            /// <item><description><b>STOPPED</b></description></item>
            /// <item><description><b>UNKNOWN</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("CurrentStatus")]
            [Validation(Required=false)]
            public string CurrentStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether SAE agent is enabled.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableAgent")]
            [Validation(Required=false)]
            public bool? EnableAgent { get; set; }

            /// <summary>
            /// <para>The file size limit. Unit: KB. Valid values: 0 to 10240.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10240</para>
            /// </summary>
            [NameInMap("FileSizeLimit")]
            [Validation(Required=false)]
            public long? FileSizeLimit { get; set; }

            /// <summary>
            /// <para>The ID of the latest change order that is executed. If no change orders have been executed or if change orders have expired, an empty parameter is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1ccc2339-fc19-49aa-bda0-1e7b8497****</para>
            /// </summary>
            [NameInMap("LastChangeOrderId")]
            [Validation(Required=false)]
            public string LastChangeOrderId { get; set; }

            /// <summary>
            /// <para>Indicates whether the latest change order is being executed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("LastChangeOrderRunning")]
            [Validation(Required=false)]
            public bool? LastChangeOrderRunning { get; set; }

            /// <summary>
            /// <para>The state of the latest change order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>READY</b>: The change order is ready.</description></item>
            /// <item><description><b>RUNNING</b>: The change order is being executed.</description></item>
            /// <item><description><b>SUCCESS</b>: The change order was executed successfully.</description></item>
            /// <item><description><b>FAIL</b>: The change order failed to be executed.</description></item>
            /// <item><description><b>ABORT</b>: The change order is stopped.</description></item>
            /// <item><description><b>WAIT_BATCH_CONFIRM</b>: The change order is pending execution. You must manually confirm the release batch.</description></item>
            /// <item><description><b>AUTO_BATCH_WAIT</b>: The change order is pending execution. SAE will automatically confirm the release batch.</description></item>
            /// <item><description><b>SYSTEM_FAIL</b>: A system exception occurred.</description></item>
            /// <item><description><b>WAIT_APPROVAL</b>: The change order is pending approval.</description></item>
            /// <item><description><b>APPROVED</b>: The change order is approved and is pending execution.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("LastChangeOrderStatus")]
            [Validation(Required=false)]
            public string LastChangeOrderStatus { get; set; }

            /// <summary>
            /// <para>The number of running instances of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RunningInstances")]
            [Validation(Required=false)]
            public int? RunningInstances { get; set; }

            /// <summary>
            /// <para>Indicates whether an error occurred while the change order was being executed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NORMAL</b></description></item>
            /// <item><description><b>RUNNING_BUT_HAS_ERROR</b> If an error occurs during a batch release, you must manually perform a rollback. In this case, the change order is still running because the task is not completed, but the state of the change order is RUNNING_BUT_HAS_ERROR.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("SubStatus")]
            [Validation(Required=false)]
            public string SubStatus { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description>If the request is successful, this parameter is not returned.****</description></item>
        /// <item><description>This parameter is returned only if the request failed.**** For more information, see <b>Error codes</b> in this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b> is returned when the request succeeds.</description></item>
        /// <item><description>An error code is returned when the request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether information of the application is successfully obtained. Valid values:</para>
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

        /// <summary>
        /// <para>The ID of the trace. It is used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
