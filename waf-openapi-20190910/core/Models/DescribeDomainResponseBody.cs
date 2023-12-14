// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class DescribeDomainResponseBody : TeaModel {
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public DescribeDomainResponseBodyDomain Domain { get; set; }
        public class DescribeDomainResponseBodyDomain : TeaModel {
            [NameInMap("AccessHeaderMode")]
            [Validation(Required=false)]
            public int? AccessHeaderMode { get; set; }

            [NameInMap("AccessHeaders")]
            [Validation(Required=false)]
            public List<string> AccessHeaders { get; set; }

            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            [NameInMap("CloudNativeInstances")]
            [Validation(Required=false)]
            public List<DescribeDomainResponseBodyDomainCloudNativeInstances> CloudNativeInstances { get; set; }
            public class DescribeDomainResponseBodyDomainCloudNativeInstances : TeaModel {
                [NameInMap("CloudNativeProductName")]
                [Validation(Required=false)]
                public string CloudNativeProductName { get; set; }

                [NameInMap("IPAddressList")]
                [Validation(Required=false)]
                public List<string> IPAddressList { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("ProtocolPortConfigs")]
                [Validation(Required=false)]
                public List<DescribeDomainResponseBodyDomainCloudNativeInstancesProtocolPortConfigs> ProtocolPortConfigs { get; set; }
                public class DescribeDomainResponseBodyDomainCloudNativeInstancesProtocolPortConfigs : TeaModel {
                    [NameInMap("Ports")]
                    [Validation(Required=false)]
                    public List<int?> Ports { get; set; }

                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

                [NameInMap("RedirectionTypeName")]
                [Validation(Required=false)]
                public string RedirectionTypeName { get; set; }

            }

            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public int? ClusterType { get; set; }

            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            [NameInMap("ConnectionTime")]
            [Validation(Required=false)]
            public int? ConnectionTime { get; set; }

            [NameInMap("Http2Port")]
            [Validation(Required=false)]
            public List<int?> Http2Port { get; set; }

            [NameInMap("HttpPort")]
            [Validation(Required=false)]
            public List<int?> HttpPort { get; set; }

            [NameInMap("HttpToUserIp")]
            [Validation(Required=false)]
            public int? HttpToUserIp { get; set; }

            [NameInMap("HttpsPort")]
            [Validation(Required=false)]
            public List<int?> HttpsPort { get; set; }

            [NameInMap("HttpsRedirect")]
            [Validation(Required=false)]
            public int? HttpsRedirect { get; set; }

            [NameInMap("IpFollowStatus")]
            [Validation(Required=false)]
            public int? IpFollowStatus { get; set; }

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
            public List<DescribeDomainResponseBodyDomainLogHeaders> LogHeaders { get; set; }
            public class DescribeDomainResponseBodyDomainLogHeaders : TeaModel {
                [NameInMap("k")]
                [Validation(Required=false)]
                public string K { get; set; }

                [NameInMap("v")]
                [Validation(Required=false)]
                public string V { get; set; }

            }

            [NameInMap("ReadTime")]
            [Validation(Required=false)]
            public int? ReadTime { get; set; }

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
            public List<string> SourceIps { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

            [NameInMap("WriteTime")]
            [Validation(Required=false)]
            public int? WriteTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
