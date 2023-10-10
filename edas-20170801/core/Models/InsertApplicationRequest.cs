// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertApplicationRequest : TeaModel {
        /// <summary>
        /// The name of the application. The name can contain only digits, letters, hyphens (-), and underscores (\_) and must start with a letter. The name can be up to 36 characters in length.
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The build package number of EDAS Container. This parameter is required if you create a High-Speed Service Framework (HSF) application. You can query the build package number by using one of the following methods:
        /// 
        /// *   Call the ListBuildPack operation. For more information, see [ListBuildPack](~~149391~~).
        /// *   Obtain the value in the **Build package number** column of the [Release notes for EDAS Container](~~92614~~) topic.
        /// </summary>
        [NameInMap("BuildPackId")]
        [Validation(Required=false)]
        public int? BuildPackId { get; set; }

        /// <summary>
        /// The ID of the ECS cluster in which you want to create the application. If you specify an ID, the application is created in the specified ECS cluster. If you leave this parameter empty, the application is created in the default cluster. We recommend that you specify this parameter.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The ID of the application component. You can call the ListComponents operation to query the component IDs. For more information, see [ListComponents](~~97502~~).
        /// 
        /// This parameter is required if the application runs in Apache Tomcat or in a standard Java application runtime environment. The Apache Tomcat application runtime environment is applicable to Dubbo applications that are deployed by using WAR packages. A standard Java application runtime environment is applicable to Spring Boot or Spring Cloud applications that are deployed by using JAR packages.
        /// 
        /// Valid values for common application components:
        /// 
        /// *   4: Apache Tomcat 7.0.91
        /// *   7: Apache Tomcat 8.5.42
        /// *   5: OpenJDK 1.8.x
        /// *   6: OpenJDK 1.7.x
        /// 
        /// This parameter is available only for Java SDK 2.57.3 or later, or Python SDK 2.57.3 or later. Assume that you use an SDK that is not provided by EDAS, for example, aliyun-python-sdk-core, aliyun-java-sdk-core, and Alibaba Cloud CLI. In this case, you can directly specify this parameter.
        /// </summary>
        [NameInMap("ComponentIds")]
        [Validation(Required=false)]
        public string ComponentIds { get; set; }

        /// <summary>
        /// The number of CPU cores that can be used by the application container in a Swarm cluster. \*\*This parameter is deprecated.\*\*
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// The description of the application.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The value of `ecu_id` of the ECS instance to be added during scale-out. The ECU ID is the unique identity for an ECS instance that is imported to EDAS. Separate multiple values of `ecu_id` with commas (,). You can call the ListScaleOutEcu operation to query the value of `ecu_id`. For more information, see [ListScaleOutEcu](~~149371~~).
        /// </summary>
        [NameInMap("EcuInfo")]
        [Validation(Required=false)]
        public string EcuInfo { get; set; }

        /// <summary>
        /// Specifies whether to enable the port health check. Valid values:
        /// 
        /// *   **true**: enable the port health check.
        /// *   **false**: does not enable the port health check.
        /// </summary>
        [NameInMap("EnablePortCheck")]
        [Validation(Required=false)]
        public bool? EnablePortCheck { get; set; }

        /// <summary>
        /// Specifies whether to enable the URL health check. Valid values:
        /// 
        /// *   **true**: enables the URL health check.
        /// *   **false**: does not enable the URL health check.
        /// </summary>
        [NameInMap("EnableUrlCheck")]
        [Validation(Required=false)]
        public bool? EnableUrlCheck { get; set; }

        /// <summary>
        /// The health check URL of the application.
        /// </summary>
        [NameInMap("HealthCheckURL")]
        [Validation(Required=false)]
        public string HealthCheckURL { get; set; }

        /// <summary>
        /// The health check URL of the application. This parameter is equivalent to the HealthCheckURL parameter.
        /// </summary>
        [NameInMap("HealthCheckUrl")]
        [Validation(Required=false)]
        public string HealthCheckUrl { get; set; }

        /// <summary>
        /// The script to mount. Set the value in the JSON format. Example: `[{"ignoreFail":false,"name":"postprepareInstanceEnvironmentOnScaleOut","script":"ls"},{"ignoreFail":true,"name":"postdeleteInstanceDataOnScaleIn","script":""},{"ignoreFail":true,"name":"prestartInstance","script":""},{"ignoreFail":true,"name":"poststartInstance","script":""},{"ignoreFail":true,"name":"prestopInstance","script":""},{"ignoreFail":true,"name":"poststopInstance","script":""}]`
        /// </summary>
        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public string Hooks { get; set; }

        /// <summary>
        /// The version of the Java Development Kit (JDK) used to deploy the application. **This parameter is deprecated.
        /// </summary>
        [NameInMap("Jdk")]
        [Validation(Required=false)]
        public string Jdk { get; set; }

        /// <summary>
        /// The custom parameters.
        /// </summary>
        [NameInMap("JvmOptions")]
        [Validation(Required=false)]
        public string JvmOptions { get; set; }

        /// <summary>
        /// The ID of the microservices namespace. To query the ID of a microservices namespace, you can choose **Resource Management** > **Microservice Namespaces** in the left-side navigation pane of the EDAS console or call the ListUserDefineRegion operation. For more information, see [ListUserDefineRegion](~~149377~~).
        /// 
        /// *   This parameter is required if the cluster you specify is not deployed in the default microservices namespace. Otherwise, the message `application regionId is different with cluster regionId!` appears.
        /// *   If the cluster you specify is deployed in the default microservices namespace, you do not need to specify this parameter. Set this parameter to the ID of the microservices namespace in which the cluster you specify is deployed.
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

        /// <summary>
        /// The maximum size of the heap memory. Unit: MB.
        /// </summary>
        [NameInMap("MaxHeapSize")]
        [Validation(Required=false)]
        public int? MaxHeapSize { get; set; }

        /// <summary>
        /// The size of the permanent generation heap memory. Unit: MB.
        /// </summary>
        [NameInMap("MaxPermSize")]
        [Validation(Required=false)]
        public int? MaxPermSize { get; set; }

        /// <summary>
        /// The memory size that can be used by the application container in a Swarm cluster. \*\*This parameter is deprecated.\*\*
        /// </summary>
        [NameInMap("Mem")]
        [Validation(Required=false)]
        public int? Mem { get; set; }

        /// <summary>
        /// The initial size of the heap memory. Unit: MB.
        /// </summary>
        [NameInMap("MinHeapSize")]
        [Validation(Required=false)]
        public int? MinHeapSize { get; set; }

        /// <summary>
        /// The type of the application deployment package. Valid values: war and jar.
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// The reserved port for the application. \*\*This parameter is deprecated.\*\*
        /// </summary>
        [NameInMap("ReservedPortStr")]
        [Validation(Required=false)]
        public string ReservedPortStr { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The version of Apache Tomcat. **This parameter is deprecated.
        /// </summary>
        [NameInMap("WebContainer")]
        [Validation(Required=false)]
        public string WebContainer { get; set; }

    }

}
