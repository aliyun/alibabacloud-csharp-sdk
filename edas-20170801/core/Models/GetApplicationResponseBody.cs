// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the application.</para>
        /// </summary>
        [NameInMap("Application")]
        [Validation(Required=false)]
        public GetApplicationResponseBodyApplication Application { get; set; }
        public class GetApplicationResponseBodyApplication : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cfac****-847e-4325-ad56-b5c2bc54****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The current status of the Kubernetes application, which is used to determine whether the application is in a stable state. If the application is in an unstable state, related configuration operations are prohibited. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ready: The application is in the ready state and can be changed.</description></item>
            /// <item><description>progressive: The application is being changed.</description></item>
            /// <item><description>pending: The application change is blocked.</description></item>
            /// <item><description>failed: The application fails to be changed.</description></item>
            /// </list>
            /// <para>In these states, ready is a stable state and other states are unstable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ready</para>
            /// </summary>
            [NameInMap("AppPhase")]
            [Validation(Required=false)]
            public string AppPhase { get; set; }

            /// <summary>
            /// <para>The deployment type of the application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>War: The application is deployed by using a WAR package.</description></item>
            /// <item><description>FatJar: The application is deployed by using a JAR package.</description></item>
            /// <item><description>Empty: The application is not deployed.</description></item>
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
            /// <para>59</para>
            /// </summary>
            [NameInMap("BuildPackageId")]
            [Validation(Required=false)]
            public long? BuildPackageId { get; set; }

            /// <summary>
            /// <para>The ID of the ECS cluster in which the application is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5ffc5895-<b><b>-b03a-c223c6c3</b></b></para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The type of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: regular Docker cluster</description></item>
            /// <item><description>1: Swarm cluster</description></item>
            /// <item><description>2: ECS cluster</description></item>
            /// <item><description>3: Kubernetes cluster</description></item>
            /// <item><description>4: cluster in which Pandora automatically registers applications</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The time when the application was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1610550324226</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the application is a Docker application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false: The application is not a Docker application.</description></item>
            /// <item><description>true: The application is a Docker application.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Dockerize")]
            [Validation(Required=false)]
            public bool? Dockerize { get; set; }

            /// <summary>
            /// <para>The email address of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:xxxx@gmail.com">xxxx@gmail.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>Indicates whether the port health check is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The port health check is enabled.</description></item>
            /// <item><description>false: The port health check is disabled.</description></item>
            /// </list>
            /// <para>If the port health check is enabled, EDAS checks whether a port exists during application startup. If the port exists, the application is considered to have started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnablePortCheck")]
            [Validation(Required=false)]
            public bool? EnablePortCheck { get; set; }

            /// <summary>
            /// <para>Indicates whether the URL health check is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The URL health check is enabled.</description></item>
            /// <item><description>false: The URL health check is disabled.</description></item>
            /// </list>
            /// <para>If the URL health check is enabled, EDAS attempts to detect the specified URL during application startup. If EDAS detects the specified URL, the application is considered to have started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableUrlCheck")]
            [Validation(Required=false)]
            public bool? EnableUrlCheck { get; set; }

            /// <summary>
            /// <para>The ID of the Internet-facing SLB instance that is bound to the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-bp1vceck3s3b9xs6x****</para>
            /// </summary>
            [NameInMap("ExtSlbId")]
            [Validation(Required=false)]
            public string ExtSlbId { get; set; }

            /// <summary>
            /// <para>The IP address of the Internet-facing Server Load Balancer (SLB) instance that is bound to the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.114.xxx.xx</para>
            /// </summary>
            [NameInMap("ExtSlbIp")]
            [Validation(Required=false)]
            public string ExtSlbIp { get; set; }

            /// <summary>
            /// <para>The name of the Internet-facing SLB instance that is bound to the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aa8eee383db084f42aebc4d9f52c****</para>
            /// </summary>
            [NameInMap("ExtSlbName")]
            [Validation(Required=false)]
            public string ExtSlbName { get; set; }

            [NameInMap("HaveManageAccess")]
            [Validation(Required=false)]
            public string HaveManageAccess { get; set; }

            /// <summary>
            /// <para>The health check URL of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://127.0.0.1:8080/xyz.html">http://127.0.0.1:8080/xyz.html</a></para>
            /// </summary>
            [NameInMap("HealthCheckUrl")]
            [Validation(Required=false)]
            public string HealthCheckUrl { get; set; }

            /// <summary>
            /// <para>The number of instances deployed with the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// <para>The memory size of the application instance. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace to which the application belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>doc-test</para>
            /// </summary>
            [NameInMap("NameSpace")]
            [Validation(Required=false)]
            public string NameSpace { get; set; }

            /// <summary>
            /// <para>The ID of the user who created the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ouou@117274586608****</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

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
            /// <para>The ID of the region in which the application is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The number of running instances for the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RunningInstanceCount")]
            [Validation(Required=false)]
            public int? RunningInstanceCount { get; set; }

            /// <summary>
            /// <para>The ID of the internal-facing SLB instance that is bound to the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-bp<b><b>ck3s3b9xs6x</b></b></para>
            /// </summary>
            [NameInMap("SlbId")]
            [Validation(Required=false)]
            public string SlbId { get; set; }

            /// <summary>
            /// <para>The information about the internal-facing SLB instance that is bound to the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("SlbInfo")]
            [Validation(Required=false)]
            public string SlbInfo { get; set; }

            /// <summary>
            /// <para>The IP address of the internal-facing SLB instance that is bound to the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.100</para>
            /// </summary>
            [NameInMap("SlbIp")]
            [Validation(Required=false)]
            public string SlbIp { get; set; }

            /// <summary>
            /// <para>The name of the internal-facing SLB instance that is bound to the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("SlbName")]
            [Validation(Required=false)]
            public string SlbName { get; set; }

            /// <summary>
            /// <para>The port of the internal-facing SLB instance that is bound to the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("SlbPort")]
            [Validation(Required=false)]
            public int? SlbPort { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test@dd******</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("WorkloadType")]
            [Validation(Required=false)]
            public string WorkloadType { get; set; }

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
        /// <para>The additional information that is returned.</para>
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
        /// <para>F8DFGED-K98***************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
