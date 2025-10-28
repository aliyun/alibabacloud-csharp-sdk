// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about applications.</para>
        /// </summary>
        [NameInMap("ApplicationList")]
        [Validation(Required=false)]
        public ListApplicationResponseBodyApplicationList ApplicationList { get; set; }
        public class ListApplicationResponseBodyApplicationList : TeaModel {
            [NameInMap("Application")]
            [Validation(Required=false)]
            public List<ListApplicationResponseBodyApplicationListApplication> Application { get; set; }
            public class ListApplicationResponseBodyApplicationListApplication : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00ee517d-dd7d-4d4e-<b><b>-</b></b>********</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The deployment type of the application. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>War: The application is deployed by using a WAR package.</description></item>
                /// <item><description>FatJar: The application is deployed by using a JAR package.</description></item>
                /// <item><description>Image: The application is deployed by using an image.</description></item>
                /// <item><description>If this parameter is empty, the application is not deployed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FatJar</para>
                /// </summary>
                [NameInMap("ApplicationType")]
                [Validation(Required=false)]
                public string ApplicationType { get; set; }

                /// <summary>
                /// <para>The build package number of Enterprise Distributed Application Service (EDAS) Container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>58</para>
                /// </summary>
                [NameInMap("BuildPackageId")]
                [Validation(Required=false)]
                public long? BuildPackageId { get; set; }

                /// <summary>
                /// <para>The ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c37aec2a-bcca-4ec1-<b><b>-</b></b>********</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The type of the cluster in which the application is deployed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>2</b>: Elastic Compute Service (ECS) cluster</description></item>
                /// <item><description><b>3</b>: self-managed Kubernetes cluster in EDAS</description></item>
                /// <item><description><b>5</b>: Container Service for Kubernetes (ACK) cluster</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public int? ClusterType { get; set; }

                /// <summary>
                /// <para>The time when the application was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1664208000000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The IP address of the Internet-facing SLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.100.70.***</para>
                /// </summary>
                [NameInMap("ExtSlbIp")]
                [Validation(Required=false)]
                public string ExtSlbIp { get; set; }

                /// <summary>
                /// <para>The listener port of the Internet-facing SLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("ExtSlbListenerPort")]
                [Validation(Required=false)]
                public int? ExtSlbListenerPort { get; set; }

                /// <summary>
                /// <para>The number of application instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Instances")]
                [Validation(Required=false)]
                public int? Instances { get; set; }

                /// <summary>
                /// <para>The namespace of the Kubernetes cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("K8sNamespace")]
                [Validation(Required=false)]
                public string K8sNamespace { get; set; }

                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>doc-test-consumer</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the microservices namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou:test</para>
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// <para>The service port of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The region ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing:docTes</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aek24j4s4b*****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The number of running application instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RunningInstanceCount")]
                [Validation(Required=false)]
                public int? RunningInstanceCount { get; set; }

                /// <summary>
                /// <para>The IP address of the internal-facing Server Load Balancer (SLB) instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.***</para>
                /// </summary>
                [NameInMap("SlbIp")]
                [Validation(Required=false)]
                public string SlbIp { get; set; }

                /// <summary>
                /// <para>The listener port of the internal-facing SLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8088</para>
                /// </summary>
                [NameInMap("SlbListenerPort")]
                [Validation(Required=false)]
                public int? SlbListenerPort { get; set; }

                /// <summary>
                /// <para>The port of the internal-facing SLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("SlbPort")]
                [Validation(Required=false)]
                public int? SlbPort { get; set; }

                /// <summary>
                /// <para>The state of the application. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RUNNING: The application is running.</description></item>
                /// <item><description>STOPPED: The application is stopped.</description></item>
                /// <item><description>DEPLOYING: The application is being deployed.</description></item>
                /// <item><description>DELETING: The application is being deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The message that is returned.</para>
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
        /// <para>5d6fa0bc-cc3**********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
