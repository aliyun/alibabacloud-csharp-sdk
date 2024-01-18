// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddServiceSourceShrinkRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh-CN (default): Chinese
        /// *   en-US: English
        /// *   ja: Japanese
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Specifies whether to monitor Ingress classes.
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// Specifies whether to update the Ingress status.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// The data structure.
        /// </summary>
        [NameInMap("GroupList")]
        [Validation(Required=false)]
        public string GroupListShrink { get; set; }

        /// <summary>
        /// The list of service groups.
        /// </summary>
        [NameInMap("IngressOptionsRequest")]
        [Validation(Required=false)]
        public string IngressOptionsRequestShrink { get; set; }

        /// <summary>
        /// The namespace whose resources you want to monitor.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("PathList")]
        [Validation(Required=false)]
        public string PathListShrink { get; set; }

        /// <summary>
        /// The service source.
        /// 
        /// *   K8s: ACK cluster
        /// *   NACOS: MSE Nacos instance
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The list of security groups to be authorized. You can specify security groups to allow backend services to access data sources that you create.
        /// </summary>
        [NameInMap("ToAuthorizeSecurityGroups")]
        [Validation(Required=false)]
        public string ToAuthorizeSecurityGroupsShrink { get; set; }

        /// <summary>
        /// The type of the service source.
        /// 
        /// *   K8s: Container Service for Kubernetes (ACK) cluster
        /// *   NACOS: Nacos instance
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
