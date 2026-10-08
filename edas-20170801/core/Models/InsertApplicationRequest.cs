// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application. The name can contain only digits, letters, hyphens (-), and underscores (_). It must start with a letter and can be up to 36 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello-edas-test-1</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The build package number of EDAS-Container. This parameter is required when you create a High-speed Service Framework (HSF) application. You can obtain the build package number in one of the following ways:</para>
        /// <list type="bullet">
        /// <item><description><para>Call the ListBuildPack operation. For more information, see <a href="https://help.aliyun.com/document_detail/149391.html">ListBuildPack</a>.</para>
        /// </description></item>
        /// <item><description><para>Obtain the build package number from the <b>Build Package Number</b> column in the <a href="https://help.aliyun.com/document_detail/92614.html">Container versions</a> table.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>59</para>
        /// </summary>
        [NameInMap("BuildPackId")]
        [Validation(Required=false)]
        public int? BuildPackId { get; set; }

        /// <summary>
        /// <para>The ID of the ECS cluster. Specify this parameter to create the application in a specific ECS cluster. If you leave this parameter empty, the application is created in the default cluster. We recommend that you specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13136119-f384-4f50-b76e-xxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the application component. You can call the ListComponents operation to query the component ID. For more information, see <a href="https://help.aliyun.com/document_detail/97502.html">ListComponents</a>.</para>
        /// <para>This parameter is required if the application runs in an Apache Tomcat container (for Dubbo applications that are deployed in a WAR package) or a standard Java application runtime environment (for Spring Boot or Spring Cloud applications that are deployed in a JAR package).</para>
        /// <para>The following application component IDs are commonly used:</para>
        /// <list type="bullet">
        /// <item><description><para>4: Apache Tomcat 7.0.91</para>
        /// </description></item>
        /// <item><description><para>7: Apache Tomcat 8.5.42</para>
        /// </description></item>
        /// <item><description><para>5: OpenJDK 1.8.x</para>
        /// </description></item>
        /// <item><description><para>6: OpenJDK 1.7.x</para>
        /// </description></item>
        /// </list>
        /// <para>To set this parameter, you must update the Java or Python software development kit (SDK) to version 2.57.3 or later. If you do not use an EDAS SDK, such as aliyun-python-sdk-core, aliyun-java-sdk-core, or Alibaba Cloud CLI, you can set this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("ComponentIds")]
        [Validation(Required=false)]
        public string ComponentIds { get; set; }

        /// <summary>
        /// <para>\<em>\</em>(Deprecated)\<em>\</em> The number of CPU cores for the application container in a Swarm cluster.</para>
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
        /// <para>The \<c>ecu_id\\</c> of the ECS instance to which you want to scale out the application. The \<c>ecu_id\\</c> is the unique ID of an ECS instance that is imported to EDAS. To specify multiple \<c>ecu_id\\</c>s, separate them with commas (,). You can call the ListScaleOutEcu operation to query the \<c>ecu_id\\</c>. For more information, see <a href="https://help.aliyun.com/document_detail/149371.html">ListScaleOutEcu</a>.</para>
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
        /// <item><description><para><b>true</b>: Enabled</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnablePortCheck")]
        [Validation(Required=false)]
        public bool? EnablePortCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the health check URL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enabled</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled</para>
        /// </description></item>
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
        /// <para>The configuration of the mounted script. The value is a JSON string. Example:
        /// <c>[{&quot;ignoreFail&quot;:false,&quot;name&quot;:&quot;postprepareInstanceEnvironmentOnScaleOut&quot;,&quot;script&quot;:&quot;ls&quot;},{&quot;ignoreFail&quot;:true,&quot;name&quot;:&quot;postdeleteInstanceDataOnScaleIn&quot;,&quot;script&quot;:&quot;&quot;},{&quot;ignoreFail&quot;:true,&quot;name&quot;:&quot;prestartInstance&quot;,&quot;script&quot;:&quot;&quot;},{&quot;ignoreFail&quot;:true,&quot;name&quot;:&quot;poststartInstance&quot;,&quot;script&quot;:&quot;&quot;},{&quot;ignoreFail&quot;:true,&quot;name&quot;:&quot;prestopInstance&quot;,&quot;script&quot;:&quot;&quot;},{&quot;ignoreFail&quot;:true,&quot;name&quot;:&quot;poststopInstance&quot;,&quot;script&quot;:&quot;&quot;}]</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ignoreFail&quot;:false,&quot;name&quot;:&quot;postprepareInstanceEnvironmentOnScaleOut&quot;,&quot;script&quot;:&quot;ls&quot;}]</para>
        /// </summary>
        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public string Hooks { get; set; }

        /// <summary>
        /// <para><b>(Deprecated)</b> The version of the Java Development Kit (JDK) that the application uses.</para>
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
        /// <para>The ID of the microservices namespace. In the EDAS console, choose <b>Resource Management</b> &gt; <b>Microservices Namespace</b> in the navigation pane on the left to view the ID of the microservices namespace. You can also call the ListUserDefineRegion operation to query the ID. For more information, see <a href="https://help.aliyun.com/document_detail/149377.html">ListUserDefineRegion</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>If the specified cluster is not in the default microservices namespace, you must specify this parameter. Otherwise, the \<c>application regionId is different with cluster regionId!\\</c> error is reported.</para>
        /// </description></item>
        /// <item><description><para>If the cluster is in the default microservices namespace, you do not need to specify this parameter. The microservices namespace of the application must be the same as the microservices namespace of the specified cluster.</para>
        /// </description></item>
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
        /// <para>The size of the permanent generation memory. Unit: MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("MaxPermSize")]
        [Validation(Required=false)]
        public int? MaxPermSize { get; set; }

        /// <summary>
        /// <para>\<em>\</em>(Deprecated)\<em>\</em> The memory size for the application container in a Swarm cluster.</para>
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
        /// <para>The format of the application deployment package. Valid values: war and jar.</para>
        /// 
        /// <b>Example:</b>
        /// <para>war</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>\<em>\</em>(Deprecated)\<em>\</em> The reserved port of the application.</para>
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
        /// <para><b>(Deprecated)</b> The version of Apache Tomcat.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("WebContainer")]
        [Validation(Required=false)]
        public string WebContainer { get; set; }

    }

}
