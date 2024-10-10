// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ApplyEciScalingConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The content of the configuration file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apiVersion: apps/v1
        /// kind: Deployment
        /// metadata:
        ///   name: nginx-deployment
        ///   labels:
        ///     app: nginx
        ///   spec:
        ///     replicas: 3
        ///     selector:
        ///        matchLabels:
        ///         app: nginx
        ///     template:
        ///       metadata:
        ///         labels:
        ///           app: nginx
        ///         annotations:
        ///           k8s.aliyun.com/eip-bandwidth: 10
        ///           k8s.aliyun.com/eci-with-eip: true
        ///         spec:
        ///           containers:
        ///           - name: nginx
        ///             image: nginx:1.14.2
        ///             ports:
        ///             - containerPort: 80</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Optional. Set the value to YAML.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YAML</para>
        /// </summary>
        [NameInMap("Format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the scaling configuration.</para>
        /// <para>If you want the system to update a scaling configuration of the Elastic Container Instance type based on a YAML configuration file, you must specify <c>ScalingConfigurationId</c>. If you do not specify <c>ScalingConfigurationId</c>, the system creates a new scaling configuration based on the YAML configuration file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asc-bp1i65jd06v04vdh****</para>
        /// </summary>
        [NameInMap("ScalingConfigurationId")]
        [Validation(Required=false)]
        public string ScalingConfigurationId { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp1igpak5ft1flyp****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
