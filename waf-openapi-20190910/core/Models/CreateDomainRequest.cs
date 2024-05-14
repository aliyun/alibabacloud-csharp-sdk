// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class CreateDomainRequest : TeaModel {
        [NameInMap("AccessHeaderMode")]
        [Validation(Required=false)]
        public int? AccessHeaderMode { get; set; }

        [NameInMap("AccessHeaders")]
        [Validation(Required=false)]
        public string AccessHeaders { get; set; }

        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        [NameInMap("CloudNativeInstances")]
        [Validation(Required=false)]
        public string CloudNativeInstances { get; set; }

        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public int? ClusterType { get; set; }

        [NameInMap("ConnectionTime")]
        [Validation(Required=false)]
        public int? ConnectionTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("Http2Port")]
        [Validation(Required=false)]
        public string Http2Port { get; set; }

        [NameInMap("HttpPort")]
        [Validation(Required=false)]
        public string HttpPort { get; set; }

        [NameInMap("HttpToUserIp")]
        [Validation(Required=false)]
        public int? HttpToUserIp { get; set; }

        [NameInMap("HttpsPort")]
        [Validation(Required=false)]
        public string HttpsPort { get; set; }

        [NameInMap("HttpsRedirect")]
        [Validation(Required=false)]
        public int? HttpsRedirect { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IpFollowStatus")]
        [Validation(Required=false)]
        public int? IpFollowStatus { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("IsAccessProduct")]
        [Validation(Required=false)]
        public int? IsAccessProduct { get; set; }

        [NameInMap("Keepalive")]
        [Validation(Required=false)]
        public bool? Keepalive { get; set; }

        [NameInMap("KeepaliveRequests")]
        [Validation(Required=false)]
        public int? KeepaliveRequests { get; set; }

        [NameInMap("KeepaliveTimeout")]
        [Validation(Required=false)]
        public int? KeepaliveTimeout { get; set; }

        [NameInMap("LoadBalancing")]
        [Validation(Required=false)]
        public int? LoadBalancing { get; set; }

        [NameInMap("LogHeaders")]
        [Validation(Required=false)]
        public string LogHeaders { get; set; }

        [NameInMap("ReadTime")]
        [Validation(Required=false)]
        public int? ReadTime { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Retry")]
        [Validation(Required=false)]
        public bool? Retry { get; set; }

        [NameInMap("SniHost")]
        [Validation(Required=false)]
        public string SniHost { get; set; }

        [NameInMap("SniStatus")]
        [Validation(Required=false)]
        public int? SniStatus { get; set; }

        [NameInMap("SourceIps")]
        [Validation(Required=false)]
        public string SourceIps { get; set; }

        [NameInMap("WriteTime")]
        [Validation(Required=false)]
        public int? WriteTime { get; set; }

    }

}
