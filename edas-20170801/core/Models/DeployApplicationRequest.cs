// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DeployApplicationRequest : TeaModel {
        /// <summary>
        /// The environment variables of the application. Specify each environment variable by using two key-value pairs. Example: `{"name":"x","value":"y"},{"name":"x2","value":"y2"}`. The `keys` of the two key-value pairs are `name` and `value`.
        /// </summary>
        [NameInMap("AppEnv")]
        [Validation(Required=false)]
        public string AppEnv { get; set; }

        /// <summary>
        /// The ID of the application. You can call the ListApplication operation to query the application ID. For more information, see [ListApplication](~~423162~~).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The number of batches per instance group.
        /// 
        /// *   If you specify an ID when you set the GroupId parameter, the application is deployed to the specified instance group. The minimum number of batches that can be specified is 1. The maximum number of batches is the maximum number of ECS instances in the Normal state in the instance group. The actual value falls in the range of \[1, specified number]. The specified number of batches equals the number of ECS instances in the specified instance group.
        /// *   If you set the GroupId parameter to all, the application is deployed to all instance groups. The minimum number of batches that can be specified is 1. The maximum number of batches is the number of ECS instances in the instance group that has the largest number of ECS instances in the Normal state.
        /// </summary>
        [NameInMap("Batch")]
        [Validation(Required=false)]
        public int? Batch { get; set; }

        /// <summary>
        /// The wait time between deployment batches for the application. Unit: minutes.
        /// 
        /// *   Default value: 0. If no wait time between deployment batches is needed, set this parameter to 0.
        /// *   Maximum value: 5.
        /// 
        /// If many deployment batches are needed, we recommend that you specify a small value for this parameter. Otherwise, the application deployment is time-consuming.
        /// </summary>
        [NameInMap("BatchWaitTime")]
        [Validation(Required=false)]
        public int? BatchWaitTime { get; set; }

        /// <summary>
        /// The build package number of EDAS Container.
        /// 
        /// *   You do not need to set the parameter if you do not need to change the EDAS Container version during the deployment.
        /// *   Set the parameter if you need to update the EDAS Container version of the application during the deployment.
        /// 
        /// You can query the build package number by using one of the following methods:
        /// 
        /// *   Call the ListBuildPack operation. For more information, see [ListBuildPack](~~149391~~).
        /// *   Obtain the value in the **Build package number** column of the [Release notes for EDAS Container](~~92614~~) topic. For example, `59` indicates `EDAS Container 3.5.8`.
        /// </summary>
        [NameInMap("BuildPackId")]
        [Validation(Required=false)]
        public long? BuildPackId { get; set; }

        /// <summary>
        /// The IDs of the components used by the application. The parameter is not applicable to High-Speed Framework (HSF) applications. You can call the ListComponents operation to query the component IDs. For more information, see [ListComponents](~~423223~~).
        /// 
        /// *   If you have specified the component IDs when you create the application, you do not need to set the parameter when you deploy the application.
        /// *   Set the parameter if you need to update the component versions for the application during the deployment.
        /// 
        /// Valid values for common application components:
        /// 
        /// *   4: Apache Tomcat 7.0.91
        /// *   7: Apache Tomcat 8.5.42
        /// *   5: OpenJDK 1.8.x
        /// *   6: OpenJDK 1.7.x
        /// 
        /// For more information, see the Common application parameters section of the [InsertApplication](~~423185~~) topic.
        /// </summary>
        [NameInMap("ComponentIds")]
        [Validation(Required=false)]
        public string ComponentIds { get; set; }

        /// <summary>
        /// The deployment mode of the application. Valid values: `url` and `image`. The image value is deprecated. You can deploy an application to a Swarm cluster only by using an image.``
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        /// <summary>
        /// The description of the application deployment.
        /// </summary>
        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// Specifies whether canary release is selected as the deployment method. Valid values:
        /// 
        /// *   true: Canary release is selected.
        /// 
        ///     *   To implement a canary release, specify the GroupId parameter, which specifies the ID of the instance group for the canary release.
        ///     *   Canary release can be selected as the deployment method for only one batch.
        ///     *   After the canary release is complete, the application is released in regular mode. The Batch parameter specifies the number of batches.
        /// 
        /// *   false: Single-batch release or phased release is selected.
        /// </summary>
        [NameInMap("Gray")]
        [Validation(Required=false)]
        public bool? Gray { get; set; }

        /// <summary>
        /// The ID of the instance group to which the application is deployed. You can call the ListDeployGroup operation to query the ID of the instance group. For more information, see [ListDeployGroup](~~423184~~).
        /// 
        /// Set the parameter to `all` if you want to deploy the application to all instance groups.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The URL of the application image that is used to deploy the application in a Swarm cluster. We recommend that you use an image that is stored in Alibaba Cloud Container Registry. This parameter is deprecated.
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The version of the application deployment package. The value can be up to 64 characters in length. We recommend that you use a timestamp.
        /// </summary>
        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

        /// <summary>
        /// The mode in which the deployment batches are triggered. Valid values:
        /// 
        /// *   0: automatic.
        /// *   1: You must manually trigger the next batch. You can manually click **Proceed to Next Batch** in the console or call the ContinuePipeline operation to proceed to the next batch. We recommend that you choose the automatic mode when you call an API operation to deploy the application. For more information, see [ContinuePipeline](~~126990~~).
        /// </summary>
        [NameInMap("ReleaseType")]
        [Validation(Required=false)]
        public long? ReleaseType { get; set; }

        /// <summary>
        /// The canary release policy. For more information about canary release policies, see [DeployK8sApplication](~~423212~~).
        /// </summary>
        [NameInMap("TrafficControlStrategy")]
        [Validation(Required=false)]
        public string TrafficControlStrategy { get; set; }

        /// <summary>
        /// The URL of the application deployment package. The package can be a WAR or JAR package. This parameter is required if you set the **DeployType** parameter to `url`. We recommend that you specify the URL of an application deployment package that is stored in an Object Storage Service (OSS) bucket.
        /// </summary>
        [NameInMap("WarUrl")]
        [Validation(Required=false)]
        public string WarUrl { get; set; }

    }

}
