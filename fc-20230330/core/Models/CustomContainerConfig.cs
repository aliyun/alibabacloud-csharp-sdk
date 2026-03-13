// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CustomContainerConfig : TeaModel {
        /// <summary>
        /// <para>The information about image acceleration.</para>
        /// </summary>
        [NameInMap("accelerationInfo")]
        [Validation(Required=false)]
        public AccelerationInfo AccelerationInfo { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable image acceleration. Valid values: Default: enables image acceleration. None: disables image acceleration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("accelerationType")]
        [Validation(Required=false)]
        public string AccelerationType { get; set; }

        /// <summary>
        /// <para>The ID of the image repository for the Container Registry Enterprise Edition. You must specify this parameter if you use an image of Container Registry Enterprise Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>The startup parameter of the container.</para>
        /// </summary>
        [NameInMap("command")]
        [Validation(Required=false)]
        public List<string> Command { get; set; }

        /// <summary>
        /// <para>The container startup command.</para>
        /// </summary>
        [NameInMap("entrypoint")]
        [Validation(Required=false)]
        public List<string> Entrypoint { get; set; }

        /// <summary>
        /// <para>The custom health check configurations of the function.</para>
        /// </summary>
        [NameInMap("healthCheckConfig")]
        [Validation(Required=false)]
        public CustomHealthCheckConfig HealthCheckConfig { get; set; }

        /// <summary>
        /// <para>The endpoint of the container image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/fc-demo/helloworld:v1beta1</para>
        /// </summary>
        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The port on which the HTTP server listens for the Custom Container runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9000</para>
        /// </summary>
        [NameInMap("port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>registry related</para>
        /// </summary>
        [NameInMap("registryConfig")]
        [Validation(Required=false)]
        public RegistryConfig RegistryConfig { get; set; }

        /// <summary>
        /// <para>The actual digest version of the deployed image. The code version specified by digest is actually used when the function starts. This parameter is returned by GetFunction and is not required as a parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stand-sh-registry-vpc.cn-shanghai.cr.aliyuncs.com/fc-demo2/springboot-helloworld@sha256:68d1****0d64d6</para>
        /// </summary>
        [NameInMap("resolvedImageUri")]
        [Validation(Required=false)]
        public string ResolvedImageUri { get; set; }

    }

}
