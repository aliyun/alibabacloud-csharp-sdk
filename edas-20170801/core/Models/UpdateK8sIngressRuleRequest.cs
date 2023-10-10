// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateK8sIngressRuleRequest : TeaModel {
        /// <summary>
        /// The annotations.
        /// </summary>
        [NameInMap("Annotations")]
        [Validation(Required=false)]
        public string Annotations { get; set; }

        /// <summary>
        /// The ID of the Kubernetes cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The routing rules of the Ingress. Set this parameter to a JSON string in the following format:
        /// 
        ///     {
        ///       "rules": [
        ///         {
        ///           "host": "abc.com",
        ///           "secretName": "tls-secret",
        ///           "paths": [
        ///             {
        ///               "path": "/path",
        ///               "backend": {
        ///                 "servicePort": 80,
        ///                 "serviceName": "xxx"
        ///               }
        ///             }
        ///           ]
        ///         }
        ///       ]
        ///     }
        /// 
        /// Parameter description:
        /// 
        /// *   rules: the list of routing rules.
        /// *   host: the domain name to be accessed.
        /// *   secretName: the name of the Secret that stores the information about the Transport Layer Security (TLS) certificate. The certificate is required if you need to use the HTTPS protocol.
        /// *   paths: the list of paths to be accessed.
        /// *   path: the path to be accessed.
        /// *   backend: the configuration of the backend service. You can specify a service that is created in the Enterprise Distributed Application Service (EDAS) console.
        /// *   serviceName: the name of the backend service.
        /// *   servicePort: the port of the backend service.
        /// </summary>
        [NameInMap("IngressConf")]
        [Validation(Required=false)]
        public Dictionary<string, object> IngressConf { get; set; }

        /// <summary>
        /// The labels.
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// The name of the Ingress. The name can contain lowercase letters, digits, and hyphens (-). It must start with a lowercase letter but cannot end with a hyphen (-). The name can be up to 63 characters in length.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The namespace of the Kubernetes cluster.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

    }

}
