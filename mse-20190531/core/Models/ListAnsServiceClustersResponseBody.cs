// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListAnsServiceClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAnsServiceClustersResponseBodyData Data { get; set; }
        public class ListAnsServiceClustersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the associated application for which Microservices Governance is enabled when the Source parameter is set to governance.</para>
            /// </summary>
            [NameInMap("AppDetail")]
            [Validation(Required=false)]
            public ListAnsServiceClustersResponseBodyDataAppDetail AppDetail { get; set; }
            public class ListAnsServiceClustersResponseBodyDataAppDetail : TeaModel {
                /// <summary>
                /// <para>The ID of the application for which Microservices Governance is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hkhon1po62@904cba2c0xxxxxx</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The name of the application for which Microservices Governance is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spring-cloud-b</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The health check interval. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CheckInternal")]
                [Validation(Required=false)]
                public int? CheckInternal { get; set; }

                /// <summary>
                /// <para>The path of the health check. This parameter is required only when the CheckType parameter is set to http.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/health</para>
                /// </summary>
                [NameInMap("CheckPath")]
                [Validation(Required=false)]
                public string CheckPath { get; set; }

                /// <summary>
                /// <para>The timeout period of the health check response. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("CheckTimeout")]
                [Validation(Required=false)]
                public int? CheckTimeout { get; set; }

                /// <summary>
                /// <para>The type of the health check. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>connection: connection status check</description></item>
                /// <item><description>tcp: TCP connection check</description></item>
                /// <item><description>http: HTTP connection check</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>connection</para>
                /// </summary>
                [NameInMap("CheckType")]
                [Validation(Required=false)]
                public string CheckType { get; set; }

                /// <summary>
                /// <para>The maximum number of health check retries when the instance state changes from unhealthy to healthy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("HealthyCheckTimes")]
                [Validation(Required=false)]
                public int? HealthyCheckTimes { get; set; }

                /// <summary>
                /// <para>The port number of the application for which Microservices Governance is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6001</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The maximum number of health check retries when the instance state changes from healthy to unhealthy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("UnhealthyCheckTimes")]
                [Validation(Required=false)]
                public int? UnhealthyCheckTimes { get; set; }

            }

            /// <summary>
            /// <para>The cluster information.</para>
            /// </summary>
            [NameInMap("Clusters")]
            [Validation(Required=false)]
            public List<ListAnsServiceClustersResponseBodyDataClusters> Clusters { get; set; }
            public class ListAnsServiceClustersResponseBodyDataClusters : TeaModel {
                /// <summary>
                /// <para>The default port used for a health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("DefaultCheckPort")]
                [Validation(Required=false)]
                public int? DefaultCheckPort { get; set; }

                /// <summary>
                /// <para>The default port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("DefaultPort")]
                [Validation(Required=false)]
                public int? DefaultPort { get; set; }

                /// <summary>
                /// <para>The type of the health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Heartbeat Reporting</para>
                /// </summary>
                [NameInMap("HealthCheckerType")]
                [Validation(Required=false)]
                public string HealthCheckerType { get; set; }

                /// <summary>
                /// <para>The metadata of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public Dictionary<string, object> Metadata { get; set; }

                /// <summary>
                /// <para>The cluster name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The full name of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT_GROUP@@nacos.test.3</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// <para>Indicates whether an end-to-end health check was initiated by the server. This parameter is valid only if the service is not a temporary service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("UseIPPort4Check")]
                [Validation(Required=false)]
                public bool? UseIPPort4Check { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the service is a temporary service. Valid values:</para>
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
            /// <para>The service group to which the service belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEFAULT_GROUP</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The metadata of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <para>The name of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nacos.test.3</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The protection threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ProtectThreshold")]
            [Validation(Required=false)]
            public float? ProtectThreshold { get; set; }

            /// <summary>
            /// <para>The election mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("SelectorType")]
            [Validation(Required=false)]
            public string SelectorType { get; set; }

            /// <summary>
            /// <para>The source type of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>console: The service was registered in the console.</description></item>
            /// <item><description>sdk: The service was registered by using the SDK.</description></item>
            /// <item><description>governance: The service was registered on Microservices Governance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>console</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

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
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
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

    }

}
