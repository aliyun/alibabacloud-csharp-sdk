// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateApplicationBaseInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The applications that you want to modify.</para>
        /// </summary>
        [NameInMap("Applcation")]
        [Validation(Required=false)]
        public UpdateApplicationBaseInfoResponseBodyApplcation Applcation { get; set; }
        public class UpdateApplicationBaseInfoResponseBodyApplcation : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c627c157-560d-43ff-<b><b>-</b></b>********</para>
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
            /// <para>d7730a49-629a-47bd-<b><b>-f45eb01f</b></b></para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The type of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: normal Docker cluster</description></item>
            /// <item><description>1: Swarm cluster</description></item>
            /// <item><description>2: ECS cluster</description></item>
            /// <item><description>3: self-managed Kubernetes cluster in EDAS</description></item>
            /// <item><description>4: cluster in which Pandora automatically registers applications</description></item>
            /// <item><description>5: Container Service for Kubernetes (ACK) clusters</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public int? ClusterType { get; set; }

            /// <summary>
            /// <para>The number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The time when the application was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1577259573911</para>
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
            /// <para>Indicates whether the application is a Docker application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Dockerize")]
            [Validation(Required=false)]
            public bool? Dockerize { get; set; }

            /// <summary>
            /// <para>The ID of the Internet-facing SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ace93*******</para>
            /// </summary>
            [NameInMap("ExtSlbId")]
            [Validation(Required=false)]
            public string ExtSlbId { get; set; }

            /// <summary>
            /// <para>The IP address of the Internet-facing Server Load Balancer (SLB) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>39.97.XX.XX</para>
            /// </summary>
            [NameInMap("ExtSlbIp")]
            [Validation(Required=false)]
            public string ExtSlbIp { get; set; }

            /// <summary>
            /// <para>The name of the Internet-facing SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ExtSlbName")]
            [Validation(Required=false)]
            public string ExtSlbName { get; set; }

            /// <summary>
            /// <para>The health check URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://127.0.XX.XX:8080/_etc.html">http://127.0.XX.XX:8080/_etc.html</a></para>
            /// </summary>
            [NameInMap("HealthCheckUrl")]
            [Validation(Required=false)]
            public string HealthCheckUrl { get; set; }

            /// <summary>
            /// <para>The number of application instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// <para>The size of memory configured for an application instance. Unit: MB.</para>
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
            /// <para>The owner of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@aliyun_XXX.com">test@aliyun_XXX.com</a></para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The port used by the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing:****</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

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
            /// <para>The ID of the internal-facing SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a3d4*******</para>
            /// </summary>
            [NameInMap("SlbId")]
            [Validation(Required=false)]
            public string SlbId { get; set; }

            /// <summary>
            /// <para>The IP address of the internal-facing SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("SlbIp")]
            [Validation(Required=false)]
            public string SlbIp { get; set; }

            /// <summary>
            /// <para>The name of the internal-facing SLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("SlbName")]
            [Validation(Required=false)]
            public string SlbName { get; set; }

            /// <summary>
            /// <para>The port used by the internal-facing SLB instance.</para>
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
            /// <para>edas_com***@****.***</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D16979DC-4D42-**************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
