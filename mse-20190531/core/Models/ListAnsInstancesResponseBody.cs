// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListAnsInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAnsInstancesResponseBodyData> Data { get; set; }
        public class ListAnsInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app</para>
            /// </summary>
            [NameInMap("App")]
            [Validation(Required=false)]
            public string App { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEFAULT</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The reference key.</para>
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
            /// <para>The effective status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: The instance takes effect.</description></item>
            /// <item><description><c>false</c>: The instance does not take effect.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Indicates whether the information about the ephemeral node is obtained. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: yes</description></item>
            /// <item><description><c>false</c>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Ephemeral")]
            [Validation(Required=false)]
            public bool? Ephemeral { get; set; }

            /// <summary>
            /// <para>The number of counted failures.</para>
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
            /// <para>The timeout period of the instance heartbeat.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15000</para>
            /// </summary>
            [NameInMap("InstanceHeartBeatTimeOut")]
            [Validation(Required=false)]
            public int? InstanceHeartBeatTimeOut { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
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
            /// <para>The timeout period for removing an IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000</para>
            /// </summary>
            [NameInMap("IpDeleteTimeout")]
            [Validation(Required=false)]
            public int? IpDeleteTimeout { get; set; }

            /// <summary>
            /// <para>The last heartbeat time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20201010</para>
            /// </summary>
            [NameInMap("LastBeat")]
            [Validation(Required=false)]
            public long? LastBeat { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance was marked. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: The instance marking was successful.</description></item>
            /// <item><description><c>false</c>: The instance marking failed.</description></item>
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
            /// <para>The number of counted successes.</para>
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
            /// <para>The name of the service.</para>
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
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202</para>
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request was successfully processed.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52BA6DA6-A702-4362-A32F-DFF79655****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request was successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of returned instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
