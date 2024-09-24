// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateClusterDiagnosisRequest : TeaModel {
        /// <summary>
        /// The parameter used to specify the diagnostic object. Examples of parameters for different types of diagnostic objects:
        /// 
        /// node:
        /// 
        ///     {"name": "cn-shanghai.10.10.10.107"}
        /// 
        /// pod
        /// 
        ///     {"namespace": "kube-system", "name": "csi-plugin-2cg9f"}
        /// 
        /// network
        /// 
        ///     {"src": "10.10.10.108", "dst": "10.11.247.16", "dport": "80"}
        /// 
        /// ingress
        /// 
        ///     {"url": "https://example.com"}
        /// 
        /// memory
        /// 
        ///     {"node":"cn-hangzhou.172.16.9.240"}
        /// 
        /// service
        /// 
        ///     {"namespace": "kube-system", "name": "nginx-ingress-lb"}
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public Dictionary<string, object> Target { get; set; }

        /// <summary>
        /// The type of the diagnostic.
        /// 
        /// Valid values:
        /// 
        /// *   node
        /// *   ingress
        /// *   cluster
        /// *   memory
        /// *   pod
        /// *   service
        /// *   network
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
