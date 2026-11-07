// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListAnsInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The data overview.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAnsInstancesResponseBodyData> Data { get; set; }
        public class ListAnsInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app</para>
            /// </summary>
            [NameInMap("App")]
            [Validation(Required=false)]
            public string App { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEFAULT</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The datum key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30.5.XX.XX:unknown:DEFAULT</para>
            /// </summary>
            [NameInMap("DatumKey")]
            [Validation(Required=false)]
            public string DatumKey { get; set; }

            /// <summary>
            /// <para>The default key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30.5.XX.XX:unknown</para>
            /// </summary>
            [NameInMap("DefaultKey")]
            [Validation(Required=false)]
            public string DefaultKey { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Enabled.</description></item>
            /// <item><description><c>false</c>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Indicates whether the node is ephemeral. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Obtained successfully.</description></item>
            /// <item><description><c>false</c>: Failed to obtain.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Ephemeral")]
            [Validation(Required=false)]
            public bool? Ephemeral { get; set; }

            /// <summary>
            /// <para>The failure count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            /// <summary>
            /// <para>The health status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: The instance is healthy.</description></item>
            /// <item><description><c>false</c>: The instance is unhealthy.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Healthy")]
            [Validation(Required=false)]
            public bool? Healthy { get; set; }

            /// <summary>
            /// <para>The heartbeat interval of the instance. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("InstanceHeartBeatInterval")]
            [Validation(Required=false)]
            public int? InstanceHeartBeatInterval { get; set; }

            /// <summary>
            /// <para>The instance heartbeat timeout.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15000</para>
            /// </summary>
            [NameInMap("InstanceHeartBeatTimeOut")]
            [Validation(Required=false)]
            public int? InstanceHeartBeatTimeOut { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30.5.XX.XX#0#DEFAULT#DEFAULT_GROUP@@consumers:com.alibaba.edas.IHelloService</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30.5.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The IP address deletion timeout.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000</para>
            /// </summary>
            [NameInMap("IpDeleteTimeout")]
            [Validation(Required=false)]
            public int? IpDeleteTimeout { get; set; }

            /// <summary>
            /// <para>The time of the last heartbeat.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20201010</para>
            /// </summary>
            [NameInMap("LastBeat")]
            [Validation(Required=false)]
            public long? LastBeat { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance is marked. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Marked successfully.</description></item>
            /// <item><description><c>false</c>: Failed to mark.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Marked")]
            [Validation(Required=false)]
            public bool? Marked { get; set; }

            /// <summary>
            /// <para>The metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[int]</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <para>The success count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OkCount")]
            [Validation(Required=false)]
            public int? OkCount { get; set; }

            /// <summary>
            /// <para>The port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEFAULT_GROUP@@consumers:com.alibaba.edas.IHelloService::</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The weight.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202</para>
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request is processed successfully.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of instances to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52BA6DA6-A702-4362-A32F-DFF79655****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
