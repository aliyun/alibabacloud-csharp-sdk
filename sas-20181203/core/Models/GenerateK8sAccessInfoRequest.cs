// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GenerateK8sAccessInfoRequest : TeaModel {
        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("AliyunYundunGatewayApiName")]
        [Validation(Required=false)]
        public string AliyunYundunGatewayApiName { get; set; }

        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("AliyunYundunGatewayPopName")]
        [Validation(Required=false)]
        public string AliyunYundunGatewayPopName { get; set; }

        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("AliyunYundunGatewayProjectName")]
        [Validation(Required=false)]
        public string AliyunYundunGatewayProjectName { get; set; }

        /// <summary>
        /// The Simple Log Service Logstore that is used to store the audit logs.
        /// </summary>
        [NameInMap("AuditLogStore")]
        [Validation(Required=false)]
        public string AuditLogStore { get; set; }

        /// <summary>
        /// The Simple Log Service project that is used to store the audit logs.
        /// </summary>
        [NameInMap("AuditProject")]
        [Validation(Required=false)]
        public string AuditProject { get; set; }

        /// <summary>
        /// The ID of the region in which the audit logs are stored.
        /// </summary>
        [NameInMap("AuditRegionId")]
        [Validation(Required=false)]
        public string AuditRegionId { get; set; }

        /// <summary>
        /// The name of the Kubernetes cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// The time at which the container ends to be added.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExpireDate")]
        [Validation(Required=false)]
        public long? ExpireDate { get; set; }

        /// <summary>
        /// The group ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// The service provider of the cloud asset. Valid values:
        /// 
        /// *   **Tencent**
        /// *   **HUAWEICLOUD**
        /// *   **Azure**
        /// *   **AWS**
        /// *   **Others**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
