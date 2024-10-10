// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ApplyScalingGroupRequest : TeaModel {
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
        /// spec:
        ///   replicas: 3
        ///   selector:
        ///     matchLabels:
        ///       app: nginx
        ///   template:
        ///     metadata:
        ///       labels:
        ///         app: nginx
        ///       annotations:
        ///         k8s.aliyun.com/eip-bandwidth: 10
        ///         k8s.aliyun.com/eci-with-eip: true
        ///     spec:
        ///       containers:
        ///       - name: nginx
        ///         image: nginx:1.14.2
        ///         ports:
        ///         - containerPort: 80</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Optional. The format of the configuration file. Default value: YAML. Set the value to YAML.</para>
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
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
