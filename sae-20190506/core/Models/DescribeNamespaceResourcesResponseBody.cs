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
        public DescribeNamespaceResourcesResponseBodyData Data { get; set; }
        public class DescribeNamespaceResourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The version of the APM Java agent.</para>
            /// </summary>
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
            /// <para>The region of the namespace.</para>
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
            /// <para>The release order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>afedb3c4-63f8-4a3d-aaa3-2c30363f****</para>
            /// </summary>
            [NameInMap("LastChangeOrderId")]
            [Validation(Required=false)]
            public string LastChangeOrderId { get; set; }

            /// <summary>
            /// <para>Indicates whether a release order is running in the namespace. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: A release order is running.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: No release order is running.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("LastChangeOrderRunning")]
            [Validation(Required=false)]
            public bool? LastChangeOrderRunning { get; set; }

            /// <summary>
            /// <para>The status of the last release order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>READY</b>: The release order is ready.</para>
            /// </description></item>
            /// <item><description><para><b>RUNNING</b>: The release order is running.</para>
            /// </description></item>
            /// <item><description><para><b>SUCCESS</b>: The release order was successful.</para>
            /// </description></item>
            /// <item><description><para><b>FAIL</b>: The release order failed.</para>
            /// </description></item>
            /// <item><description><para><b>ABORT</b>: The release order was aborted.</para>
            /// </description></item>
            /// <item><description><para><b>WAIT_BATCH_CONFIRM</b>: The release order is waiting for manual batch confirmation.</para>
            /// </description></item>
            /// <item><description><para><b>AUTO_BATCH_WAIT</b>: The release order is in an automatic batch-wait state.</para>
            /// </description></item>
            /// <item><description><para><b>SYSTEM_FAIL</b>: A system error occurred.</para>
            /// </description></item>
            /// <item><description><para><b>WAIT_APPROVAL</b>: The release order is pending approval.</para>
            /// </description></item>
            /// <item><description><para><b>APPROVED</b>: The release order is approved and pending execution.</para>
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
            /// <para>The short-format namespace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("NameSpaceShortId")]
            [Validation(Required=false)]
            public string NameSpaceShortId { get; set; }

            /// <summary>
            /// <para>The namespace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shangha:test</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The namespace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("NamespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

            /// <summary>
            /// <para>Indicates whether the notification for the release order has expired. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The notification has expired.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The notification has not expired.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NotificationExpired")]
            [Validation(Required=false)]
            public bool? NotificationExpired { get; set; }

            /// <summary>
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-wz969ngg2e49q5i4****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The configuration for collecting logs to Simple Log Service (SLS).</para>
            /// <list type="bullet">
            /// <item><description><para>To use SLS resources that are automatically created by SAE: <c>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</c>.</para>
            /// </description></item>
            /// <item><description><para>To use custom SLS resources: <c>[{&quot;projectName&quot;:&quot;test-sls&quot;,&quot;logType&quot;:&quot;stdout&quot;,&quot;logDir&quot;:&quot;&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;},{&quot;projectName&quot;:&quot;test&quot;,&quot;logDir&quot;:&quot;/tmp/a.log&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;}]</c>.</para>
            /// </description></item>
            /// </list>
            /// <para>The configuration includes the following parameters:</para>
            /// <list type="bullet">
            /// <item><description><para><b>projectName</b>: The project name in SLS.</para>
            /// </description></item>
            /// <item><description><para><b>logDir</b>: The log path.</para>
            /// </description></item>
            /// <item><description><para><b>logType</b>: The log type. <b>stdout</b> indicates the standard output of the container. Only one stdout entry is allowed. If you omit this parameter, file logs are collected.</para>
            /// </description></item>
            /// <item><description><para><b>logstoreName</b>: The Logstore name in SLS.</para>
            /// </description></item>
            /// <item><description><para><b>logtailName</b>: The Logtail name in SLS. If you omit this parameter, SAE creates a Logtail.</para>
            /// </description></item>
            /// </list>
            /// <para>You do not need to set this parameter if the SLS log collection configuration is unchanged for subsequent deployments. To disable log collection, set this parameter to an empty string (&quot;&quot;).</para>
            /// </summary>
            [NameInMap("SlsConfigs")]
            [Validation(Required=false)]
            public string SlsConfigs { get; set; }

            /// <summary>
            /// <para>The tenant ID of the SAE namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>838cad95-973f-48fe-830b-2a8546d7****</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@aliyun.com">test@aliyun.com</a></para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2ze559r1z1bpwqxwp****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The vSwitch name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("VSwitchName")]
            [Validation(Required=false)]
            public string VSwitchName { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2ze0i263cnn311nvj****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The VPC name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

        }

        /// <summary>
        /// <para>The error code. This parameter is returned only if the request fails. For more information, see the <b>Error codes</b> section of this topic.</para>
        /// <list type="bullet">
        /// <item><description><para>A successful request does not return the <b>ErrorCode</b> field.</para>
        /// </description></item>
        /// <item><description><para>A failed request returns the <b>ErrorCode</b> field. For more information, see the list of <b>error codes</b> in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, <b>success</b> is returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, an error code is returned.</para>
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
        /// <para>Indicates whether the namespace resources were queried successfully.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The query was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The query failed.</para>
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
        /// <para>The trace ID. You can use this ID to query the details of the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
