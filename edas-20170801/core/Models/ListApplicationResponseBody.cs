// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListApplicationResponseBody : TeaModel {
        /// <summary>
        /// The information about applications.
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
                /// The ID of the application.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The deployment type of the application. Valid values:
                /// 
                /// *   War: The application is deployed by using a WAR package.
                /// *   FatJar: The application is deployed by using a JAR package.
                /// *   Image: The application is deployed by using an image.
                /// *   If this parameter is empty, the application is not deployed.
                /// </summary>
                [NameInMap("ApplicationType")]
                [Validation(Required=false)]
                public string ApplicationType { get; set; }

                /// <summary>
                /// The build package number of Enterprise Distributed Application Service (EDAS) Container.
                /// </summary>
                [NameInMap("BuildPackageId")]
                [Validation(Required=false)]
                public long? BuildPackageId { get; set; }

                /// <summary>
                /// The ID of the cluster.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The type of the cluster in which the application is deployed. Valid values:
                /// 
                /// *   **2**: Elastic Compute Service (ECS) cluster
                /// *   **3**: self-managed Kubernetes cluster in EDAS
                /// *   **5**: Container Service for Kubernetes (ACK) cluster
                /// </summary>
                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public int? ClusterType { get; set; }

                /// <summary>
                /// The time when the application was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The IP address of the Internet-facing SLB instance.
                /// </summary>
                [NameInMap("ExtSlbIp")]
                [Validation(Required=false)]
                public string ExtSlbIp { get; set; }

                /// <summary>
                /// The listener port of the Internet-facing SLB instance.
                /// </summary>
                [NameInMap("ExtSlbListenerPort")]
                [Validation(Required=false)]
                public int? ExtSlbListenerPort { get; set; }

                /// <summary>
                /// The number of application instances.
                /// </summary>
                [NameInMap("Instances")]
                [Validation(Required=false)]
                public int? Instances { get; set; }

                /// <summary>
                /// The namespace of the Kubernetes cluster.
                /// </summary>
                [NameInMap("K8sNamespace")]
                [Validation(Required=false)]
                public string K8sNamespace { get; set; }

                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the microservices namespace.
                /// </summary>
                [NameInMap("NamespaceId")]
                [Validation(Required=false)]
                public string NamespaceId { get; set; }

                /// <summary>
                /// The service port of the application.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The region ID of the application.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The number of running application instances.
                /// </summary>
                [NameInMap("RunningInstanceCount")]
                [Validation(Required=false)]
                public int? RunningInstanceCount { get; set; }

                /// <summary>
                /// The IP address of the internal-facing Server Load Balancer (SLB) instance.
                /// </summary>
                [NameInMap("SlbIp")]
                [Validation(Required=false)]
                public string SlbIp { get; set; }

                /// <summary>
                /// The listener port of the internal-facing SLB instance.
                /// </summary>
                [NameInMap("SlbListenerPort")]
                [Validation(Required=false)]
                public int? SlbListenerPort { get; set; }

                /// <summary>
                /// The port of the internal-facing SLB instance.
                /// </summary>
                [NameInMap("SlbPort")]
                [Validation(Required=false)]
                public int? SlbPort { get; set; }

                /// <summary>
                /// The state of the application. Valid values:
                /// 
                /// *   RUNNING: The application is running.
                /// *   STOPPED: The application is stopped.
                /// *   DEPLOYING: The application is being deployed.
                /// *   DELETING: The application is being deleted.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The message that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
