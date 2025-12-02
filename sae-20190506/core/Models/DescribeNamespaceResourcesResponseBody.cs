// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeNamespaceResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: indicates that the request was successful.</description></item>
        /// <item><description><b>3xx</b>: indicates that the request was redirected.</description></item>
        /// <item><description><b>4xx</b>: indicates that the request failed.</description></item>
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
        public DescribeNamespaceResourcesResponseBodyData Data { get; set; }
        public class DescribeNamespaceResourcesResponseBodyData : TeaModel {
            [NameInMap("ApmJavaAgentVersion")]
            [Validation(Required=false)]
            public string ApmJavaAgentVersion { get; set; }

            /// <summary>
            /// <para>The number of applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AppCount")]
            [Validation(Required=false)]
            public long? AppCount { get; set; }

            /// <summary>
            /// <para>The region to which the namespace belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("BelongRegion")]
            [Validation(Required=false)]
            public string BelongRegion { get; set; }

            /// <summary>
            /// <para>The description of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>decs</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the jump server application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5ec46468-6b26-4a3c-9f7c-bf88761a****</para>
            /// </summary>
            [NameInMap("JumpServerAppId")]
            [Validation(Required=false)]
            public string JumpServerAppId { get; set; }

            /// <summary>
            /// <para>The IP address of the jump server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.78.XXX.XX</para>
            /// </summary>
            [NameInMap("JumpServerIp")]
            [Validation(Required=false)]
            public string JumpServerIp { get; set; }

            /// <summary>
            /// <para>The ID of the change order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>afedb3c4-63f8-4a3d-aaa3-2c30363f****</para>
            /// </summary>
            [NameInMap("LastChangeOrderId")]
            [Validation(Required=false)]
            public string LastChangeOrderId { get; set; }

            /// <summary>
            /// <para>Indicates whether a change order is being executed in the namespace. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: indicates that a change order is being executed in the namespace.</description></item>
            /// <item><description><b>false</b>: indicates that no change orders are being executed in the namespace.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("LastChangeOrderRunning")]
            [Validation(Required=false)]
            public bool? LastChangeOrderRunning { get; set; }

            /// <summary>
            /// <para>The status of the latest change order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>READY</b>: The change order is ready.</description></item>
            /// <item><description><b>RUNNING</b>: The change order is being executed.</description></item>
            /// <item><description><b>SUCCESS</b>: The change order was executed.</description></item>
            /// <item><description><b>FAIL</b>: The change order could not be executed.</description></item>
            /// <item><description><b>ABORT</b>: The change order was terminated.</description></item>
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
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("NameSpaceShortId")]
            [Validation(Required=false)]
            public string NameSpaceShortId { get; set; }

            /// <summary>
            /// <para>The ID of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shangha:test</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The name of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("NamespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

            /// <summary>
            /// <para>Indicates whether the notification of a change order is expired. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: indicates that the notification is expired.</description></item>
            /// <item><description><b>false</b>: indicates that the notification is not expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NotificationExpired")]
            [Validation(Required=false)]
            public bool? NotificationExpired { get; set; }

            /// <summary>
            /// <para>The ID of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-wz969ngg2e49q5i4****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("SlsConfigs")]
            [Validation(Required=false)]
            public string SlsConfigs { get; set; }

            /// <summary>
            /// <para>The ID of the tenant in the SAE namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>838cad95-973f-48fe-830b-2a8546d7****</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@aliyun.com">test@aliyun.com</a></para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2ze559r1z1bpwqxwp****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The name of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("VSwitchName")]
            [Validation(Required=false)]
            public string VSwitchName { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2ze0i263cnn311nvj****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The name of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description>The <b>ErrorCode</b> parameter is not returned when the request succeeds.</description></item>
        /// <item><description>The <b>ErrorCode</b> parameter is returned when the request fails. For more information, see <b>Error codes</b> in this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
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
        /// <para>Indicates whether the information about resources in the namespace was queried successfully. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: indicates that the query was successful.</description></item>
        /// <item><description><b>false</b>: indicates that the query failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The ID of the trace. It can be used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
