// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The application information.</para>
        /// </summary>
        [NameInMap("Application")]
        [Validation(Required=false)]
        public GetApplicationResponseBodyApplication Application { get; set; }
        public class GetApplicationResponseBodyApplication : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cfac****-847e-4325-ad56-b5c2bc54****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The current phase of the Kubernetes application. This helps determine if the application is stable. Configuration operations are prohibited when the application is in an unstable state.</para>
            /// <list type="bullet">
            /// <item><description><para>ready: The application is ready and can be changed.</para>
            /// </description></item>
            /// <item><description><para>progressing: The application is being changed.</para>
            /// </description></item>
            /// <item><description><para>pending: The application change is blocked.</para>
            /// </description></item>
            /// <item><description><para>failed: The application change failed.</para>
            /// </description></item>
            /// </list>
            /// <para>The ready phase is stable. Other phases are unstable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ready</para>
            /// </summary>
            [NameInMap("AppPhase")]
            [Validation(Required=false)]
            public string AppPhase { get; set; }

            /// <summary>
            /// <para>The deployment type of the application:</para>
            /// <list type="bullet">
            /// <item><description><para>War: The application is deployed from a WAR package.</para>
            /// </description></item>
            /// <item><description><para>FatJar: The application is deployed from a JAR package.</para>
            /// </description></item>
            /// <item><description><para>Empty: The application is not deployed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FatJar</para>
            /// </summary>
            [NameInMap("ApplicationType")]
            [Validation(Required=false)]
            public string ApplicationType { get; set; }

            /// <summary>
            /// <para>The ID of the container version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>59</para>
            /// </summary>
            [NameInMap("BuildPackageId")]
            [Validation(Required=false)]
            public long? BuildPackageId { get; set; }

            /// <summary>
            /// <para>The ID of the ECS cluster where the application is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5ffc5895-<b><b>-b03a-c223c6c3</b></b></para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The type of the application cluster:</para>
            /// <list type="bullet">
            /// <item><description><para>0: A regular Docker cluster.</para>
            /// </description></item>
            /// <item><description><para>1: A Swarm cluster.</para>
            /// </description></item>
            /// <item><description><para>2: An ECS cluster.</para>
            /// </description></item>
            /// <item><description><para>3: A Kubernetes cluster.</para>
            /// </description></item>
            /// <item><description><para>4: A Pandora application cluster that supports automatic registration.</para>
            /// </description></item>
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
            /// <para>The UNIX timestamp when the application was created.</para>
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
            /// <para>Indicates whether the application is a Docker application:</para>
            /// <list type="bullet">
            /// <item><description><para>false: The application is not a Docker application.</para>
            /// </description></item>
            /// <item><description><para>true: The application is a Docker application.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Dockerize")]
            [Validation(Required=false)]
            public bool? Dockerize { get; set; }

            /// <summary>
            /// <para>The email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>****@***.com</para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>Indicates whether the port health check is enabled:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
            /// </description></item>
            /// </list>
            /// <para>If enabled, EDAS checks if the port is in use during application startup. If the port is in use, the application is considered started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnablePortCheck")]
            [Validation(Required=false)]
            public bool? EnablePortCheck { get; set; }

            /// <summary>
            /// <para>Indicates whether the URL health check is enabled:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
            /// </description></item>
            /// </list>
            /// <para>If enabled, EDAS probes the specified URL during application startup. If the URL is accessible, the application is considered started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableUrlCheck")]
            [Validation(Required=false)]
            public bool? EnableUrlCheck { get; set; }

            /// <summary>
            /// <para>The ID of the public-facing SLB instance attached to the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-bp1vceck3s3b9xs6x****</para>
            /// </summary>
            [NameInMap("ExtSlbId")]
            [Validation(Required=false)]
            public string ExtSlbId { get; set; }

            /// <summary>
            /// <para>The public IP address of the SLB instance attached to the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.114.xxx.xx</para>
            /// </summary>
            [NameInMap("ExtSlbIp")]
            [Validation(Required=false)]
            public string ExtSlbIp { get; set; }

            /// <summary>
            /// <para>The name of the public-facing SLB instance attached to the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aa8eee383db084f42aebc4d9f52c****</para>
            /// </summary>
            [NameInMap("ExtSlbName")]
            [Validation(Required=false)]
            public string ExtSlbName { get; set; }

            /// <summary>
            /// <para>Indicates whether the current user has management permissions on the application. This parameter is available only in RAM authentication mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
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
            /// <para>The number of instances in the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// <para>The memory size for the application instance, in MB.</para>
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
            /// <para>The creator of the application.</para>
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
            /// <para>The ID of the region where the application is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekz****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The number of running application instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RunningInstanceCount")]
            [Validation(Required=false)]
            public int? RunningInstanceCount { get; set; }

            /// <summary>
            /// <para>The ID of the internal-facing SLB instance attached to the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-bp<b><b>ck3s3b9xs6x</b></b></para>
            /// </summary>
            [NameInMap("SlbId")]
            [Validation(Required=false)]
            public string SlbId { get; set; }

            /// <summary>
            /// <para>Information about the internal-facing SLB instance attached to the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("SlbInfo")]
            [Validation(Required=false)]
            public string SlbInfo { get; set; }

            /// <summary>
            /// <para>The IP address of the internal-facing SLB instance attached to the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.<em><b>.</b></em>.***</para>
            /// </summary>
            [NameInMap("SlbIp")]
            [Validation(Required=false)]
            public string SlbIp { get; set; }

            /// <summary>
            /// <para>The name of the internal-facing SLB instance attached to the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("SlbName")]
            [Validation(Required=false)]
            public string SlbName { get; set; }

            /// <summary>
            /// <para>The port of the internal-facing SLB instance attached to the application.</para>
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

            /// <summary>
            /// <para>The workload type used to create the application. Supported types are Deployment and StatefulSet. This parameter does not apply to ECS applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>StatefulSet</para>
            /// </summary>
            [NameInMap("WorkloadType")]
            [Validation(Required=false)]
            public string WorkloadType { get; set; }

        }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information.</para>
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
        /// <para>F8DFGED-K98***************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
