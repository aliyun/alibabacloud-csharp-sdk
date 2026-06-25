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
        /// <item><description><para><b>2xx</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request was redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: The request was invalid.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: A server error occurred.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationStatusResponseBodyData Data { get; set; }
        public class DescribeApplicationStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0099b7be-5f5b-4512-a7fc-56049ef1****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>Indicates whether ARMS Advanced Edition is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disabled.</para>
            /// </description></item>
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
            /// <para>The time when the application was created. This value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1563373372746</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The current status of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RUNNING</b>: The application is running.</para>
            /// </description></item>
            /// <item><description><para><b>STOPPED</b>: The application is stopped.</para>
            /// </description></item>
            /// <item><description><para><b>UNKNOWN</b>: The application status is unknown.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("CurrentStatus")]
            [Validation(Required=false)]
            public string CurrentStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the SAE agent is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b></para>
            /// </description></item>
            /// <item><description><para><b>false</b></para>
            /// </description></item>
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
            /// <para>The ID of the most recently executed change order. This parameter is empty if no change order was executed or if the information about the change order has expired.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1ccc2339-fc19-49aa-bda0-1e7b8497****</para>
            /// </summary>
            [NameInMap("LastChangeOrderId")]
            [Validation(Required=false)]
            public string LastChangeOrderId { get; set; }

            /// <summary>
            /// <para>Indicates whether the most recent change order is being executed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b></para>
            /// </description></item>
            /// <item><description><para><b>false</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("LastChangeOrderRunning")]
            [Validation(Required=false)]
            public bool? LastChangeOrderRunning { get; set; }

            /// <summary>
            /// <para>The status of the most recent change order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>READY</b>: The change order is ready.</para>
            /// </description></item>
            /// <item><description><para><b>RUNNING</b>: The change order is being executed.</para>
            /// </description></item>
            /// <item><description><para><b>SUCCESS</b>: The change order was successful.</para>
            /// </description></item>
            /// <item><description><para><b>FAIL</b>: The change order failed.</para>
            /// </description></item>
            /// <item><description><para><b>ABORT</b>: The change order was aborted.</para>
            /// </description></item>
            /// <item><description><para><b>WAIT_BATCH_CONFIRM</b>: The change order is waiting for manual confirmation for the next batch.</para>
            /// </description></item>
            /// <item><description><para><b>AUTO_BATCH_WAIT</b>: The change order is in a waiting state for an automatic batch.</para>
            /// </description></item>
            /// <item><description><para><b>SYSTEM_FAIL</b>: A system error occurred.</para>
            /// </description></item>
            /// <item><description><para><b>WAIT_APPROVAL</b>: The change order is pending approval.</para>
            /// </description></item>
            /// <item><description><para><b>APPROVED</b>: The change order is approved and is pending execution.</para>
            /// </description></item>
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
            /// <para>The substatus of the change order. This parameter is used to determine whether an exception occurs during the release process. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>NORMAL</b>: The release is normal.</para>
            /// </description></item>
            /// <item><description><para><b>RUNNING_BUT_HAS_ERROR</b>: The release is abnormal. For example, if an error occurs during a phased release, you must manually roll back the release. In this case, the change order cannot be completed and the status of the change order remains <b>RUNNING</b>.</para>
            /// </description></item>
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
        /// <item><description><para>If the request is successful, this parameter is not returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, this parameter is returned. For more information, see the <b>Error codes</b> section in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// <list type="bullet">
        /// <item><description><para>If the call is successful, <b>success</b> is returned.</para>
        /// </description></item>
        /// <item><description><para>If the call fails, an error message is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the application status was obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID that is used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
