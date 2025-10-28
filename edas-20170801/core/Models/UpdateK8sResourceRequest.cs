// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateK8sResourceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2e7059e9-2d********5e8ecac64ff</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the namespace to which the Kubernetes resource belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The description of the resource in the YAML format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apiVersion: apps/v1 kind: Deployment metadata:   name: demo-app   namespace: app-namespace spec:   replicas: 3   selector:     matchLabels:       cluster: abc   template: # create pods using pod definition in this template     metadata:       labels:         cluster: abc     spec:       containers:       - image: registry-vpc.cn-hangzhou.aliyuncs.com/edas-demo-image/consumer:1.0         imagePullPolicy: Always         name: test-container         ports:         - containerPort: 80         env:         - name: foo           value: bar</para>
        /// </summary>
        [NameInMap("ResourceContent")]
        [Validation(Required=false)]
        public string ResourceContent { get; set; }

    }

}
