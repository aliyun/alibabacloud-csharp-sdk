// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetApplicationResponseBody : TeaModel {
        /// <summary>
        /// The details of the application.
        /// </summary>
        [NameInMap("Application")]
        [Validation(Required=false)]
        public GetApplicationResponseBodyApplication Application { get; set; }
        public class GetApplicationResponseBodyApplication : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The current status of the Kubernetes application, which is used to determine whether the application is in a stable state. If the application is in an unstable state, related configuration operations are prohibited. Valid values:
            /// 
            /// *   ready: The application is in the ready state and can be changed.
            /// *   progressive: The application is being changed.
            /// *   pending: The application change is blocked.
            /// *   failed: The application fails to be changed.
            /// 
            /// In these states, ready is a stable state and other states are unstable.
            /// </summary>
            [NameInMap("AppPhase")]
            [Validation(Required=false)]
            public string AppPhase { get; set; }

            /// <summary>
            /// The deployment type of the application. Valid values:
            /// 
            /// *   War: The application is deployed by using a WAR package.
            /// *   FatJar: The application is deployed by using a JAR package.
            /// *   Empty: The application is not deployed.
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
            /// The ID of the ECS cluster in which the application is deployed.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The type of the cluster. Valid values:
            /// 
            /// *   0: regular Docker cluster
            /// *   1: Swarm cluster
            /// *   2: ECS cluster
            /// *   3: Kubernetes cluster
            /// *   4: cluster in which Pandora automatically registers applications
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// The number of CPU cores.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// The time when the application was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The description of the application.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// Indicates whether the application is a Docker application. Valid values:
            /// 
            /// *   false: The application is not a Docker application.
            /// *   true: The application is a Docker application.
            /// </summary>
            [NameInMap("Dockerize")]
            [Validation(Required=false)]
            public bool? Dockerize { get; set; }

            /// <summary>
            /// The email address of the account.
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// Indicates whether the port health check is enabled. Valid values:
            /// 
            /// *   true: The port health check is enabled.
            /// *   false: The port health check is disabled.
            /// 
            /// If the port health check is enabled, EDAS checks whether a port exists during application startup. If the port exists, the application is considered to have started.
            /// </summary>
            [NameInMap("EnablePortCheck")]
            [Validation(Required=false)]
            public bool? EnablePortCheck { get; set; }

            /// <summary>
            /// Indicates whether the URL health check is enabled. Valid values:
            /// 
            /// *   true: The URL health check is enabled.
            /// *   false: The URL health check is disabled.
            /// 
            /// If the URL health check is enabled, EDAS attempts to detect the specified URL during application startup. If EDAS detects the specified URL, the application is considered to have started.
            /// </summary>
            [NameInMap("EnableUrlCheck")]
            [Validation(Required=false)]
            public bool? EnableUrlCheck { get; set; }

            /// <summary>
            /// The ID of the Internet-facing SLB instance that is bound to the application.
            /// </summary>
            [NameInMap("ExtSlbId")]
            [Validation(Required=false)]
            public string ExtSlbId { get; set; }

            /// <summary>
            /// The IP address of the Internet-facing Server Load Balancer (SLB) instance that is bound to the application.
            /// </summary>
            [NameInMap("ExtSlbIp")]
            [Validation(Required=false)]
            public string ExtSlbIp { get; set; }

            /// <summary>
            /// The name of the Internet-facing SLB instance that is bound to the application.
            /// </summary>
            [NameInMap("ExtSlbName")]
            [Validation(Required=false)]
            public string ExtSlbName { get; set; }

            [NameInMap("HaveManageAccess")]
            [Validation(Required=false)]
            public string HaveManageAccess { get; set; }

            /// <summary>
            /// The health check URL of the application.
            /// </summary>
            [NameInMap("HealthCheckUrl")]
            [Validation(Required=false)]
            public string HealthCheckUrl { get; set; }

            /// <summary>
            /// The number of instances deployed with the application.
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// The memory size of the application instance. Unit: MB.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// The name of the application.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The namespace to which the application belongs.
            /// </summary>
            [NameInMap("NameSpace")]
            [Validation(Required=false)]
            public string NameSpace { get; set; }

            /// <summary>
            /// The ID of the user who created the application.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// The service port of the application.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The ID of the region in which the application is deployed.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The number of running instances for the application.
            /// </summary>
            [NameInMap("RunningInstanceCount")]
            [Validation(Required=false)]
            public int? RunningInstanceCount { get; set; }

            /// <summary>
            /// The ID of the internal-facing SLB instance that is bound to the application.
            /// </summary>
            [NameInMap("SlbId")]
            [Validation(Required=false)]
            public string SlbId { get; set; }

            /// <summary>
            /// The information about the internal-facing SLB instance that is bound to the application.
            /// </summary>
            [NameInMap("SlbInfo")]
            [Validation(Required=false)]
            public string SlbInfo { get; set; }

            /// <summary>
            /// The IP address of the internal-facing SLB instance that is bound to the application.
            /// </summary>
            [NameInMap("SlbIp")]
            [Validation(Required=false)]
            public string SlbIp { get; set; }

            /// <summary>
            /// The name of the internal-facing SLB instance that is bound to the application.
            /// </summary>
            [NameInMap("SlbName")]
            [Validation(Required=false)]
            public string SlbName { get; set; }

            /// <summary>
            /// The port of the internal-facing SLB instance that is bound to the application.
            /// </summary>
            [NameInMap("SlbPort")]
            [Validation(Required=false)]
            public int? SlbPort { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("WorkloadType")]
            [Validation(Required=false)]
            public string WorkloadType { get; set; }

        }

        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
