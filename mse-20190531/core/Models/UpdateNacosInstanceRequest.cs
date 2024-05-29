// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateNacosInstanceRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The name of the Nacos instance.
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Specifies whether to disable this service. Valid values:
        /// 
        /// *   `true`: yes.
        /// *   `false`: no.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Specifies whether the node is a non-persistent node. Valid values:
        /// 
        /// *   `true`: yes.
        /// *   `false`: no.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Ephemeral")]
        [Validation(Required=false)]
        public bool? Ephemeral { get; set; }

        /// <summary>
        /// The name of the group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The IP address of the Nacos instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// The metadata of the instance.
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public string Metadata { get; set; }

        /// <summary>
        /// The ID of the namespace.
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// The port number of the Nacos instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// The name of the service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// The weight. Valid values: 0 to 10000. The value must be an integer. A larger value indicates a higher frequency at which the instance is accessed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public string Weight { get; set; }

    }

}
