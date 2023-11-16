// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GenerateK8sAccessInfoRequest : TeaModel {
        [NameInMap("AliyunYundunGatewayApiName")]
        [Validation(Required=false)]
        public string AliyunYundunGatewayApiName { get; set; }

        [NameInMap("AliyunYundunGatewayPopName")]
        [Validation(Required=false)]
        public string AliyunYundunGatewayPopName { get; set; }

        [NameInMap("AliyunYundunGatewayProjectName")]
        [Validation(Required=false)]
        public string AliyunYundunGatewayProjectName { get; set; }

        [NameInMap("AuditLogStore")]
        [Validation(Required=false)]
        public string AuditLogStore { get; set; }

        [NameInMap("AuditProject")]
        [Validation(Required=false)]
        public string AuditProject { get; set; }

        [NameInMap("AuditRegionId")]
        [Validation(Required=false)]
        public string AuditRegionId { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("ExpireDate")]
        [Validation(Required=false)]
        public long? ExpireDate { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
