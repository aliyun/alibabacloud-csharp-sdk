// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListAppServicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code or a POP error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: The request is successful.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: The request is redirected.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: The request is invalid.</para>
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
        /// <para>The list of services.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAppServicesResponseBodyData> Data { get; set; }
        public class ListAppServicesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The app ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0099b7be-5f5b-4512-a7fc-56049ef1****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The name of the app.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo-app</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The number of instances of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public string InstanceCount { get; set; }

            /// <summary>
            /// <para>The ID of the namespace that contains the app.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing:test</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The name of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test namespace</para>
            /// </summary>
            [NameInMap("NamespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

            /// <summary>
            /// <para>The type of the service registry. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: SAE Nacos</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: self-managed registry</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: MSE Nacos</para>
            /// </description></item>
            /// <item><description><para><b>9</b>: SAE K8s Service</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RegistryType")]
            [Validation(Required=false)]
            public string RegistryType { get; set; }

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
            /// <para>The service group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEFAULT_GROUP</para>
            /// </summary>
            [NameInMap("ServiceGroup")]
            [Validation(Required=false)]
            public string ServiceGroup { get; set; }

            /// <summary>
            /// <para>The name of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>frontend</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>A map of ports and protocols.</para>
            /// </summary>
            [NameInMap("ServicePortAndProtocol")]
            [Validation(Required=false)]
            public Dictionary<string, string> ServicePortAndProtocol { get; set; }

            /// <summary>
            /// <para>A list of ports.</para>
            /// </summary>
            [NameInMap("ServicePorts")]
            [Validation(Required=false)]
            public List<int?> ServicePorts { get; set; }

            /// <summary>
            /// <para>The protocol used by the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("ServiceProtocol")]
            [Validation(Required=false)]
            public string ServiceProtocol { get; set; }

            /// <summary>
            /// <para>The type of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>dubbo</b></para>
            /// </description></item>
            /// <item><description><para><b>springCloud</b></para>
            /// </description></item>
            /// <item><description><para><b>hsf</b></para>
            /// </description></item>
            /// <item><description><para><b>k8sService</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>springCloud</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>The version of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("ServiceVersion")]
            [Validation(Required=false)]
            public string ServiceVersion { get; set; }

        }

        /// <summary>
        /// <para>The error code. This parameter is returned only if the request fails. For more information, see the <b>Error codes</b> section.</para>
        /// <list type="bullet">
        /// <item><description><para>Successful requests do not return the <b>ErrorCode</b> field.</para>
        /// </description></item>
        /// <item><description><para>Failed requests return the <b>ErrorCode</b> field. For more information, see the <b>error code</b> list in this topic.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, <b>success</b> is returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, an error message is returned.</para>
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
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The call was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The call failed.</para>
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
        /// <para>The trace ID. You can use this ID to query the details of a call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
