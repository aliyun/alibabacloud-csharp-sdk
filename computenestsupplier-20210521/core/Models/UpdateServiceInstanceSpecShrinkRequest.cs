// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateServiceInstanceSpecShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A unique identifier that you provide to ensure the idempotence of the request. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10CM943JP0EN9D51H</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Prometheus on the client. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables Prometheus.</para>
        /// </description></item>
        /// <item><description><para>false: Disables Prometheus.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableUserPrometheus")]
        [Validation(Required=false)]
        public bool? EnableUserPrometheus { get; set; }

        /// <summary>
        /// <para>The name of the upgrade or downgrade action.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Plan configuration change</para>
        /// </summary>
        [NameInMap("OperationName")]
        [Validation(Required=false)]
        public string OperationName { get; set; }

        /// <summary>
        /// <para>The configuration parameters of the service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;EcsInstanceParameter\&quot;:\&quot;4vCPU 8GiB\&quot;,\&quot;ZoneId\&quot;:\&quot;cn-heyuan-a\&quot;,\&quot;SystemDiskSize\&quot;:50,\&quot;DataDiskSize\&quot;:150,\&quot;InternetMaxBandwidthOut\&quot;:2,\&quot;RegionId\&quot;:\&quot;cn-heyuan\&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        /// <summary>
        /// <para>The package name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Package 1</para>
        /// </summary>
        [NameInMap("PredefinedParametersName")]
        [Validation(Required=false)]
        public string PredefinedParametersName { get; set; }

        /// <summary>
        /// <para>The ID of the service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-0e6fca6a51a54420****</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

    }

}
