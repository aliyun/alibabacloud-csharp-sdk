// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class DescribeDomainResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public DescribeDomainResponseBodyDomain Domain { get; set; }
        public class DescribeDomainResponseBodyDomain : TeaModel {
            [NameInMap("Http2Port")]
            [Validation(Required=false)]
            public List<string> Http2Port { get; set; }
            [NameInMap("CloudNativeInstances")]
            [Validation(Required=false)]
            public List<DescribeDomainResponseBodyDomainCloudNativeInstances> CloudNativeInstances { get; set; }
            public class DescribeDomainResponseBodyDomainCloudNativeInstances : TeaModel {
                public List<DescribeDomainResponseBodyDomainCloudNativeInstancesProtocolPortConfigs> ProtocolPortConfigs { get; set; }
                public class DescribeDomainResponseBodyDomainCloudNativeInstancesProtocolPortConfigs : TeaModel {
                    public string Protocol { get; set; }
                    public string Ports { get; set; }
                }
                public string CloudNativeProductName { get; set; }
                public string InstanceId { get; set; }
                public string IPAddressList { get; set; }
            }
            [NameInMap("HttpToUserIp")]
            [Validation(Required=false)]
            public int? HttpToUserIp { get; set; }
            [NameInMap("HttpPort")]
            [Validation(Required=false)]
            public List<string> HttpPort { get; set; }
            [NameInMap("LogHeaders")]
            [Validation(Required=false)]
            public List<DescribeDomainResponseBodyDomainLogHeaders> LogHeaders { get; set; }
            public class DescribeDomainResponseBodyDomainLogHeaders : TeaModel {
                public string K { get; set; }
                public string V { get; set; }
            }
            [NameInMap("IsAccessProduct")]
            [Validation(Required=false)]
            public int? IsAccessProduct { get; set; }
            [NameInMap("HttpsRedirect")]
            [Validation(Required=false)]
            public int? HttpsRedirect { get; set; }
            [NameInMap("LoadBalancing")]
            [Validation(Required=false)]
            public int? LoadBalancing { get; set; }
            [NameInMap("IpFollowStatus")]
            [Validation(Required=false)]
            public int? IpFollowStatus { get; set; }
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public int? ClusterType { get; set; }
            [NameInMap("WriteTime")]
            [Validation(Required=false)]
            public int? WriteTime { get; set; }
            [NameInMap("ReadTime")]
            [Validation(Required=false)]
            public int? ReadTime { get; set; }
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }
            [NameInMap("SourceIps")]
            [Validation(Required=false)]
            public List<string> SourceIps { get; set; }
            [NameInMap("ConnectionTime")]
            [Validation(Required=false)]
            public int? ConnectionTime { get; set; }
            [NameInMap("HttpsPort")]
            [Validation(Required=false)]
            public List<string> HttpsPort { get; set; }
        };

    }

}
