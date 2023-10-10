// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class BindK8sSlbRequest : TeaModel {
        /// <summary>
        /// The ID of the application.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The frontend port. Valid values: 1 to 65535.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// The scheduling algorithm for the SLB instance. If you do not specify this parameter, the default value rr is used. Valid values:
        /// 
        /// *   wrr: weighted round-robin scheduling. Backend servers that have higher weights receive more requests than those that have lower weights.
        /// *   rr: round-robin scheduling. Requests are sequentially distributed to backend servers.
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// The information about the ports. This parameter is required if you want to configure multi-port mappings or use a protocol other than TCP. You must set this parameter to a JSON array. Example: \[{"targetPort":8080,"port":82,"loadBalancerProtocol":"TCP"},{"port":81,"certId":"1362469756373809\_16c185d6fa2\_1914500329\_-xxxxxxx","targetPort":8181,"lo adBalancerProtocol":"HTTPS"}]
        /// 
        /// *   port: The frontend port. Valid values: 1 to 65535. This parameter is required. Each port must be unique.
        /// *   targetPort: The backend port. Valid values: 1 to 65535. This parameter is required.
        /// *   loadBalancerProtocol: This parameter is required. Valid values: TCP and HTTPS. If the HTTP protocol is used, set this parameter to TCP.
        /// *   certId: the ID of the certificate. This parameter is required if the HTTPS protocol is used. You can purchase an SLB instance in the SLB console.
        /// 
        /// > The ServicePortInfos parameter is specified to support multi-port mappings. If you want this parameter to take effect, make sure that you have set the AppId, ClusterId, Type, and SlbId parameters.
        /// </summary>
        [NameInMap("ServicePortInfos")]
        [Validation(Required=false)]
        public string ServicePortInfos { get; set; }

        /// <summary>
        /// The ID of the SLB instance. If you leave this parameter empty, Enterprise Distributed Application Service (EDAS) automatically purchases an SLB instance.
        /// </summary>
        [NameInMap("SlbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

        /// <summary>
        /// The protocol used by the SLB instance. Valid values: TCP, HTTP, and HTTPS.
        /// </summary>
        [NameInMap("SlbProtocol")]
        [Validation(Required=false)]
        public string SlbProtocol { get; set; }

        /// <summary>
        /// The instance type of the SLB instance. Valid values:
        /// 
        /// *   slb.s1.small
        /// *   slb.s2.small
        /// *   slb.s2.medium
        /// *   slb.s3.small
        /// *   slb.s3.medium
        /// *   slb.s3.large
        /// </summary>
        [NameInMap("Specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

        /// <summary>
        /// The backend port, which is also the service port of the application. Valid values: 1 to 65535.
        /// </summary>
        [NameInMap("TargetPort")]
        [Validation(Required=false)]
        public string TargetPort { get; set; }

        /// <summary>
        /// The type of the SLB instance. Valid values:
        /// 
        /// *   internet: Internet-facing SLB instance
        /// *   intranet: internal-facing SLB instance
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
