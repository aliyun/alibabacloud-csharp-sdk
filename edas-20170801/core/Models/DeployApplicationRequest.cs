// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DeployApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The environment variables of the application. Specify each environment variable by using two key-value pairs. Example: <c>{&quot;name&quot;:&quot;x&quot;,&quot;value&quot;:&quot;y&quot;},{&quot;name&quot;:&quot;x2&quot;,&quot;value&quot;:&quot;y2&quot;}</c>. The <c>keys</c> of the two key-value pairs are <c>name</c> and <c>value</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;name\&quot;:\&quot;env_name_1\&quot;, \&quot;value\&quot;:\&quot;env_value_1\&quot;}, {\&quot;name\&quot;:\&quot;env_name_2\&quot;,\&quot;value\&quot;:\&quot;env_value_2\&quot;}]</para>
        /// </summary>
        [NameInMap("AppEnv")]
        [Validation(Required=false)]
        public string AppEnv { get; set; }

        /// <summary>
        /// <para>The ID of the application. You can call the ListApplication operation to query the application ID. For more information, see <a href="https://help.aliyun.com/document_detail/423162.html">ListApplication</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3616cdca-********************</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The number of batches per instance group.</para>
        /// <list type="bullet">
        /// <item><description>If you specify an ID when you set the GroupId parameter, the application is deployed to the specified instance group. The minimum number of batches that can be specified is 1. The maximum number of batches is the maximum number of ECS instances in the Normal state in the instance group. The actual value falls in the range of [1, specified number]. The specified number of batches equals the number of ECS instances in the specified instance group.</description></item>
        /// <item><description>If you set the GroupId parameter to all, the application is deployed to all instance groups. The minimum number of batches that can be specified is 1. The maximum number of batches is the number of ECS instances in the instance group that has the largest number of ECS instances in the Normal state.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Batch")]
        [Validation(Required=false)]
        public int? Batch { get; set; }

        /// <summary>
        /// <para>The wait time between deployment batches for the application. Unit: minutes.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 0. If no wait time between deployment batches is needed, set this parameter to 0.</description></item>
        /// <item><description>Maximum value: 5.</description></item>
        /// </list>
        /// <para>If many deployment batches are needed, we recommend that you specify a small value for this parameter. Otherwise, the application deployment is time-consuming.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BatchWaitTime")]
        [Validation(Required=false)]
        public int? BatchWaitTime { get; set; }

        /// <summary>
        /// <para>The build package number of EDAS Container.</para>
        /// <list type="bullet">
        /// <item><description>You do not need to set the parameter if you do not need to change the EDAS Container version during the deployment.</description></item>
        /// <item><description>Set the parameter if you need to update the EDAS Container version of the application during the deployment.</description></item>
        /// </list>
        /// <para>You can query the build package number by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Call the ListBuildPack operation. For more information, see <a href="https://help.aliyun.com/document_detail/149391.html">ListBuildPack</a>.</description></item>
        /// <item><description>Obtain the value in the <b>Build package number</b> column of the <a href="https://help.aliyun.com/document_detail/92614.html">Release notes for EDAS Container</a> topic. For example, <c>59</c> indicates <c>EDAS Container 3.5.8</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>59</para>
        /// </summary>
        [NameInMap("BuildPackId")]
        [Validation(Required=false)]
        public long? BuildPackId { get; set; }

        /// <summary>
        /// <para>The IDs of the components used by the application. The parameter is not applicable to High-Speed Framework (HSF) applications. You can call the ListComponents operation to query the component IDs. For more information, see <a href="https://help.aliyun.com/document_detail/423223.html">ListComponents</a>.</para>
        /// <list type="bullet">
        /// <item><description>If you have specified the component IDs when you create the application, you do not need to set the parameter when you deploy the application.</description></item>
        /// <item><description>Set the parameter if you need to update the component versions for the application during the deployment.</description></item>
        /// </list>
        /// <para>Valid values for common application components:</para>
        /// <list type="bullet">
        /// <item><description>4: Apache Tomcat 7.0.91</description></item>
        /// <item><description>7: Apache Tomcat 8.5.42</description></item>
        /// <item><description>5: OpenJDK 1.8.x</description></item>
        /// <item><description>6: OpenJDK 1.7.x</description></item>
        /// </list>
        /// <para>For more information, see the Common application parameters section of the <a href="https://help.aliyun.com/document_detail/423185.html">InsertApplication</a> topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("ComponentIds")]
        [Validation(Required=false)]
        public string ComponentIds { get; set; }

        /// <summary>
        /// <para>The deployment mode of the application. Valid values: <c>url</c> and <c>image</c>. The image value is deprecated. You can deploy an application to a Swarm cluster only by using an image.``</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>URL</para>
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        /// <summary>
        /// <para>The description of the application deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Deploy by edas pop api</para>
        /// </summary>
        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// <para>Specifies whether canary release is selected as the deployment method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Canary release is selected.</para>
        /// <list type="bullet">
        /// <item><description>To implement a canary release, specify the GroupId parameter, which specifies the ID of the instance group for the canary release.</description></item>
        /// <item><description>Canary release can be selected as the deployment method for only one batch.</description></item>
        /// <item><description>After the canary release is complete, the application is released in regular mode. The Batch parameter specifies the number of batches.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>false: Single-batch release or phased release is selected.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Gray")]
        [Validation(Required=false)]
        public bool? Gray { get; set; }

        /// <summary>
        /// <para>The ID of the instance group to which the application is deployed. You can call the ListDeployGroup operation to query the ID of the instance group. For more information, see <a href="https://help.aliyun.com/document_detail/423184.html">ListDeployGroup</a>.</para>
        /// <para>Set the parameter to <c>all</c> if you want to deploy the application to all instance groups.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The URL of the application image that is used to deploy the application in a Swarm cluster. We recommend that you use an image that is stored in Alibaba Cloud Container Registry. This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/mw/testapp:latest</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The version of the application deployment package. The value can be up to 64 characters in length. We recommend that you use a timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

        /// <summary>
        /// <para>The mode in which the deployment batches are triggered. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: automatic.</description></item>
        /// <item><description>1: You must manually trigger the next batch. You can manually click <b>Proceed to Next Batch</b> in the console or call the ContinuePipeline operation to proceed to the next batch. We recommend that you choose the automatic mode when you call an API operation to deploy the application. For more information, see <a href="https://help.aliyun.com/document_detail/126990.html">ContinuePipeline</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ReleaseType")]
        [Validation(Required=false)]
        public long? ReleaseType { get; set; }

        /// <summary>
        /// <para>The canary release policy. For more information about canary release policies, see <a href="https://help.aliyun.com/document_detail/423212.html">DeployK8sApplication</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;http&quot;:{&quot;rules&quot;:[{&quot;conditionType&quot;:&quot;percent&quot;,&quot;percent&quot;:10}]}}</para>
        /// </summary>
        [NameInMap("TrafficControlStrategy")]
        [Validation(Required=false)]
        public string TrafficControlStrategy { get; set; }

        /// <summary>
        /// <para>The URL of the application deployment package. The package can be a WAR or JAR package. This parameter is required if you set the <b>DeployType</b> parameter to <c>url</c>. We recommend that you specify the URL of an application deployment package that is stored in an Object Storage Service (OSS) bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://edas.oss-cn-hangzhou.aliyuncs.com/demo/hello-edas.war">https://edas.oss-cn-hangzhou.aliyuncs.com/demo/hello-edas.war</a></para>
        /// </summary>
        [NameInMap("WarUrl")]
        [Validation(Required=false)]
        public string WarUrl { get; set; }

    }

}
