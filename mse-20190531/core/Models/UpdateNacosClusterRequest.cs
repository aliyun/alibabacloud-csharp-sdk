// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateNacosClusterRequest : TeaModel {
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
        /// The port used for health checks.
        /// </summary>
        [NameInMap("CheckPort")]
        [Validation(Required=false)]
        public int? CheckPort { get; set; }

        /// <summary>
        /// The name of the Nacos cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// The name of the group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The type of the health check.
        /// </summary>
        [NameInMap("HealthChecker")]
        [Validation(Required=false)]
        public string HealthChecker { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the namespace.
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// The name of the service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Specifies whether to use the port of the instance for a health check.
        /// </summary>
        [NameInMap("UseInstancePortForCheck")]
        [Validation(Required=false)]
        public bool? UseInstancePortForCheck { get; set; }

    }

}
