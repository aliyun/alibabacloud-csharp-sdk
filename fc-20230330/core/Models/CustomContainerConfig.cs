// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CustomContainerConfig : TeaModel {
        [NameInMap("accelerationInfo")]
        [Validation(Required=false)]
        public AccelerationInfo AccelerationInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>deprecated</para>
        /// </summary>
        [NameInMap("accelerationType")]
        [Validation(Required=false)]
        public string AccelerationType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>deprecated</para>
        /// </summary>
        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        [NameInMap("command")]
        [Validation(Required=false)]
        public List<string> Command { get; set; }

        [NameInMap("entrypoint")]
        [Validation(Required=false)]
        public List<string> Entrypoint { get; set; }

        [NameInMap("healthCheckConfig")]
        [Validation(Required=false)]
        public CustomHealthCheckConfig HealthCheckConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/fc-demo/helloworld:v1</para>
        /// </summary>
        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9000</para>
        /// </summary>
        [NameInMap("port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        [NameInMap("registryConfig")]
        [Validation(Required=false)]
        public RegistryConfig RegistryConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>stand-sh-registry-vpc.cn-shanghai.cr.aliyuncs.com/fc-demo2/springboot-helloworld@sha256:68d1****0d64d6</para>
        /// </summary>
        [NameInMap("resolvedImageUri")]
        [Validation(Required=false)]
        public string ResolvedImageUri { get; set; }

    }

}
