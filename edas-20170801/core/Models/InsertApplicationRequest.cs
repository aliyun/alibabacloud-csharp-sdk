// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application. The name can contain only digits, letters, hyphens (-), and underscores (_) and must start with a letter. The name can be up to 36 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello-edas-test-1</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The build package number of EDAS Container. This parameter is required if you create a High-Speed Service Framework (HSF) application. You can query the build package number by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Call the ListBuildPack operation. For more information, see <a href="https://help.aliyun.com/document_detail/149391.html">ListBuildPack</a>.</description></item>
        /// <item><description>Obtain the value in the <b>Build package number</b> column of the <a href="https://help.aliyun.com/document_detail/92614.html">Release notes for EDAS Container</a> topic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>59</para>
        /// </summary>
        [NameInMap("BuildPackId")]
        [Validation(Required=false)]
        public int? BuildPackId { get; set; }

        /// <summary>
        /// <para>The ID of the ECS cluster in which you want to create the application. If you specify an ID, the application is created in the specified ECS cluster. If you leave this parameter empty, the application is created in the default cluster. We recommend that you specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13136119-f384-4f50-b76e-xxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the application component. You can call the ListComponents operation to query the component IDs. For more information, see <a href="https://help.aliyun.com/document_detail/97502.html">ListComponents</a>.</para>
        /// <para>This parameter is required if the application runs in Apache Tomcat or in a standard Java application runtime environment. The Apache Tomcat application runtime environment is applicable to Dubbo applications that are deployed by using WAR packages. A standard Java application runtime environment is applicable to Spring Boot or Spring Cloud applications that are deployed by using JAR packages.</para>
        /// <para>Valid values for common application components:</para>
        /// <list type="bullet">
        /// <item><description>4: Apache Tomcat 7.0.91</description></item>
        /// <item><description>7: Apache Tomcat 8.5.42</description></item>
        /// <item><description>5: OpenJDK 1.8.x</description></item>
        /// <item><description>6: OpenJDK 1.7.x</description></item>
        /// </list>
        /// <para>This parameter is available only for Java SDK 2.57.3 or later, or Python SDK 2.57.3 or later. Assume that you use an SDK that is not provided by EDAS, for example, aliyun-python-sdk-core, aliyun-java-sdk-core, and Alibaba Cloud CLI. In this case, you can directly specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("ComponentIds")]
        [Validation(Required=false)]
        public string ComponentIds { get; set; }

        /// <summary>
        /// <para>The number of CPU cores that can be used by the application container in a Swarm cluster. \<em>\<em>This parameter is deprecated.\</em>\</em></para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// <para>The description of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create by edas pop api</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The value of <c>ecu_id</c> of the ECS instance to be added during scale-out. The ECU ID is the unique identity for an ECS instance that is imported to EDAS. Separate multiple values of <c>ecu_id</c> with commas (,). You can call the ListScaleOutEcu operation to query the value of <c>ecu_id</c>. For more information, see <a href="https://help.aliyun.com/document_detail/149371.html">ListScaleOutEcu</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>07bd417a-b863-477d-<b><b>-</b></b>********</para>
        /// </summary>
        [NameInMap("EcuInfo")]
        [Validation(Required=false)]
        public string EcuInfo { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the port health check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enable the port health check.</description></item>
        /// <item><description><b>false</b>: does not enable the port health check.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnablePortCheck")]
        [Validation(Required=false)]
        public bool? EnablePortCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the URL health check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the URL health check.</description></item>
        /// <item><description><b>false</b>: does not enable the URL health check.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableUrlCheck")]
        [Validation(Required=false)]
        public bool? EnableUrlCheck { get; set; }

        /// <summary>
        /// <para>The health check URL of the application. This parameter is equivalent to the HealthCheckURL parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://127.0.0.1:8080/_ehc.html">http://127.0.0.1:8080/_ehc.html</a></para>
        /// </summary>
        [NameInMap("HealthCheckUrl")]
        [Validation(Required=false)]
        public string HealthCheckUrl { get; set; }

        /// <summary>
        /// <para>The script to mount. Set the value in the JSON format. Example: <c>[{&quot;ignoreFail&quot;:false,&quot;name&quot;:&quot;postprepareInstanceEnvironmentOnScaleOut&quot;,&quot;script&quot;:&quot;ls&quot;},{&quot;ignoreFail&quot;:true,&quot;name&quot;:&quot;postdeleteInstanceDataOnScaleIn&quot;,&quot;script&quot;:&quot;&quot;},{&quot;ignoreFail&quot;:true,&quot;name&quot;:&quot;prestartInstance&quot;,&quot;script&quot;:&quot;&quot;},{&quot;ignoreFail&quot;:true,&quot;name&quot;:&quot;poststartInstance&quot;,&quot;script&quot;:&quot;&quot;},{&quot;ignoreFail&quot;:true,&quot;name&quot;:&quot;prestopInstance&quot;,&quot;script&quot;:&quot;&quot;},{&quot;ignoreFail&quot;:true,&quot;name&quot;:&quot;poststopInstance&quot;,&quot;script&quot;:&quot;&quot;}]</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ignoreFail&quot;:false,&quot;name&quot;:&quot;postprepareInstanceEnvironmentOnScaleOut&quot;,&quot;script&quot;:&quot;ls&quot;}]</para>
        /// </summary>
        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public string Hooks { get; set; }

        /// <summary>
        /// <para>The version of the Java Development Kit (JDK) used to deploy the application. **This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Jdk")]
        [Validation(Required=false)]
        public string Jdk { get; set; }

        /// <summary>
        /// <para>The custom parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-Dproperty=value</para>
        /// </summary>
        [NameInMap("JvmOptions")]
        [Validation(Required=false)]
        public string JvmOptions { get; set; }

        /// <summary>
        /// <para>The ID of the microservices namespace. To query the ID of a microservices namespace, you can choose <b>Resource Management</b> &gt; <b>Microservice Namespaces</b> in the left-side navigation pane of the EDAS console or call the ListUserDefineRegion operation. For more information, see <a href="https://help.aliyun.com/document_detail/149377.html">ListUserDefineRegion</a>.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is required if the cluster you specify is not deployed in the default microservices namespace. Otherwise, the message <c>application regionId is different with cluster regionId!</c> appears.</description></item>
        /// <item><description>If the cluster you specify is deployed in the default microservices namespace, you do not need to specify this parameter. Set this parameter to the ID of the microservices namespace in which the cluster you specify is deployed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:prod</para>
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

        /// <summary>
        /// <para>The maximum size of the heap memory. Unit: MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxHeapSize")]
        [Validation(Required=false)]
        public int? MaxHeapSize { get; set; }

        /// <summary>
        /// <para>The size of the permanent generation heap memory. Unit: MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("MaxPermSize")]
        [Validation(Required=false)]
        public int? MaxPermSize { get; set; }

        /// <summary>
        /// <para>The memory size that can be used by the application container in a Swarm cluster. \<em>\<em>This parameter is deprecated.\</em>\</em></para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("Mem")]
        [Validation(Required=false)]
        public int? Mem { get; set; }

        /// <summary>
        /// <para>The initial size of the heap memory. Unit: MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MinHeapSize")]
        [Validation(Required=false)]
        public int? MinHeapSize { get; set; }

        /// <summary>
        /// <para>The type of the application deployment package. Valid values: war and jar.</para>
        /// 
        /// <b>Example:</b>
        /// <para>war</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>The reserved port for the application. This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8090</para>
        /// </summary>
        [NameInMap("ReservedPortStr")]
        [Validation(Required=false)]
        public string ReservedPortStr { get; set; }

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
        /// <para>The version of Apache Tomcat. **This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("WebContainer")]
        [Validation(Required=false)]
        public string WebContainer { get; set; }

    }

}
