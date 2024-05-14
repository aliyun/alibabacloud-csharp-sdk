// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class ModifyDomainRequest : TeaModel {
        /// <summary>
        /// The method that WAF uses to obtain the actual IP address of a client. Valid values:
        /// 
        /// *   **0**: WAF reads the first value of the X-Forwarded-For (XFF) header field as the actual IP address of the client. This is the default value.
        /// *   **1**: WAF reads the value of a custom header field as the actual IP address of the client.
        /// 
        /// >  You need to specify the parameter only when the **IsAccessProduct** parameter is set to **1**.
        /// </summary>
        [NameInMap("AccessHeaderMode")]
        [Validation(Required=false)]
        public int? AccessHeaderMode { get; set; }

        /// <summary>
        /// The custom header fields that are used to obtain the actual IP address of a client. Specify the value in the `["header1","header2",...]` format.
        /// 
        /// >  You need to specify the parameter only when the **AccessHeaderMode** parameter is set to **1**.
        /// </summary>
        [NameInMap("AccessHeaders")]
        [Validation(Required=false)]
        public string AccessHeaders { get; set; }

        /// <summary>
        /// The mode that is used to add the domain name. Valid values:
        /// 
        /// *   **waf-cloud-dns**: CNAME record mode. This is the default value.
        /// *   **waf-cloud-native**: transparent proxy mode.
        /// </summary>
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        /// <summary>
        /// The list of server and port configurations for the transparent proxy mode. The value is a string that consists of JSON arrays. Each element in a JSON array is a JSON struct that contains the following fields:
        /// 
        /// *   **ProtocolPortConfigs**: the list of protocol and port configurations. This field is required. Data type: array. Each element in a JSON array is a JSON struct that contains the following fields:
        /// 
        ///     *   **Ports**: the list of ports. This field is required. Data type: array. The value is in the `[port1,port2,……]` format.
        ///     *   **Protocol**: the protocol. This field is required. Data type: string. Valid values: **http** and **https**.
        /// 
        /// *   **CloudNativeProductName**: the type of the cloud service instance. This field is required. Data type: string. Valid values: **ECS**, **SLB**, and **ALB**.
        /// 
        /// *   **RedirectionTypeName**: the type of traffic redirection port. This field is required. Data type: string. Valid values: **ECS**, **SLB-L4**, **SLB-L7**, and **ALB**.
        /// 
        /// *   **InstanceId**: the ID of the cloud service instance. This field is required. Data type: string.
        /// 
        /// *   **IPAddressList**: the list of public IP addresses of the cloud service instance. This field is required. Data type: array. The value is in the `["ip1","ip2",...]` format.
        /// 
        /// >  You need to specify the parameter only when the value of the **AccessType** parameter is set to **waf-cloud-native**.
        /// </summary>
        [NameInMap("CloudNativeInstances")]
        [Validation(Required=false)]
        public string CloudNativeInstances { get; set; }

        /// <summary>
        /// The type of WAF protection cluster. Valid values:
        /// 
        /// *   **0**: shared cluster. This is the default value.
        /// *   **1**: exclusive cluster.
        /// 
        /// >  You need to specify the parameter only when the value of the **AccessType** parameter is set to **waf-cloud-dns**.
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public int? ClusterType { get; set; }

        /// <summary>
        /// The timeout period for connections of WAF exclusive clusters. Unit: seconds.
        /// 
        /// >  You need to specify the parameter only when the value of the **AccessType** parameter is set to **waf-cloud-dns** and the value of the **ClusterType** parameter is set to **1**.
        /// </summary>
        [NameInMap("ConnectionTime")]
        [Validation(Required=false)]
        public int? ConnectionTime { get; set; }

        /// <summary>
        /// The domain name whose configurations you want to modify.
        /// 
        /// >  You can call the [DescribeDomainNames](https://help.aliyun.com/document_detail/86373.html) operation to query the domain names that are added to Web Application Firewall (WAF).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The HTTP/2 ports. Specify the value in the `["port1","port2",...]` format.
        /// 
        /// >  You need to specify this parameter only when the value of the **AccessType** parameter is set to **waf-cloud-dns** and the **HttpsPort** parameter is not empty. If the HttpsPort parameter is not empty, your website uses HTTPS.
        /// </summary>
        [NameInMap("Http2Port")]
        [Validation(Required=false)]
        public string Http2Port { get; set; }

        /// <summary>
        /// The HTTP ports. Specify the value in the `["port1","port2",...]` format.
        /// 
        /// >  You need to specify the parameter only when the value of the **AccessType** parameter is set to **waf-cloud-dns**. If you specify this parameter, your website uses HTTP. You must specify at least one of the **HttpPort** and **HttpsPort** parameters.
        /// </summary>
        [NameInMap("HttpPort")]
        [Validation(Required=false)]
        public string HttpPort { get; set; }

        /// <summary>
        /// Specifies whether to enable the feature of redirecting HTTPS requests to HTTP requests. If you enable the feature, HTTPS requests are redirected to HTTP requests on port 80, which is used by default. Valid values:
        /// 
        /// *   **0**: disables the feature. This is the default value.
        /// *   **1**: enables the feature.
        /// 
        /// >  You need to specify this parameter only when the value of the **AccessType** parameter is set to **waf-cloud-dns** and the **HttpsPort** parameter is not empty. If the HttpsPort parameter is not empty, your website uses HTTPS.
        /// </summary>
        [NameInMap("HttpToUserIp")]
        [Validation(Required=false)]
        public int? HttpToUserIp { get; set; }

        /// <summary>
        /// The HTTPS ports. Specify the value in the `["port1","port2",...]` format.
        /// 
        /// >  You need to specify the parameter only when the value of the **AccessType** parameter is set to **waf-cloud-dns**. If you specify this parameter, your website uses HTTPS. You must specify at least one of the **HttpPort** and **HttpsPort** parameters.
        /// </summary>
        [NameInMap("HttpsPort")]
        [Validation(Required=false)]
        public string HttpsPort { get; set; }

        /// <summary>
        /// Specifies whether to enable the feature of redirecting HTTP requests to HTTPS requests. If you enable the feature, HTTP requests are redirected to HTTPS requests on port 443, which is used by default. Valid values:
        /// 
        /// *   **0**: disables the feature. This is the default value.
        /// *   **1**: enables the feature.
        /// 
        /// >  You need to specify this parameter only when the value of the **AccessType** parameter is set to **waf-cloud-dns** and the **HttpsPort** parameter is not empty. If the HttpsPort parameter is not empty, your website uses HTTPS.
        /// </summary>
        [NameInMap("HttpsRedirect")]
        [Validation(Required=false)]
        public int? HttpsRedirect { get; set; }

        /// <summary>
        /// The ID of the WAF instance.
        /// 
        /// >  You can call the [DescribeInstanceInfo](https://help.aliyun.com/document_detail/140857.html) operation to query the ID of the WAF instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Specifies whether to enable the feature of forwarding requests to the origin servers that use the IP address type specified in the requests. If you enable the feature, WAF forwards requests from IPv4 addresses to origin servers that use IPv4 addresses and requests from IPv6 addresses to origin servers that use IPv6 addresses. Valid values:
        /// 
        /// *   **0**: disables the feature. This is the default value.
        /// *   **1**: enables the feature.
        /// 
        /// >  You need to specify the parameter only when the value of the **AccessType** parameter is set to **waf-cloud-dns**.
        /// </summary>
        [NameInMap("IpFollowStatus")]
        [Validation(Required=false)]
        public int? IpFollowStatus { get; set; }

        /// <summary>
        /// Specifies whether to deploy a Layer 7 proxy, which is used to filter inbound traffic before the traffic reaches the WAF instance. The supported Layer 7 proxies include Anti-DDoS Pro, Anti-DDoS Premium, and Alibaba Cloud CDN. Valid values:
        /// 
        /// *   **0**: does not configure a Layer 7 proxy
        /// *   **1**: configures a Layer 7 proxy
        /// 
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

        /// <summary>
        /// The load balancing algorithm that is used when WAF forwards requests to the origin server. Valid values:
        /// 
        /// *   **0**: IP hash
        /// *   **1**: round-robin
        /// *   **2**: least time
        /// 
        /// >  You need to specify the parameter only when the value of the **AccessType** parameter is set to **waf-cloud-dns**.
        /// </summary>
        [NameInMap("LoadBalancing")]
        [Validation(Required=false)]
        public int? LoadBalancing { get; set; }

        /// <summary>
        /// The key-value pair that is used to mark the requests that pass through the WAF instance.
        /// 
        /// Specify the key-value pair in the `[{"k":"_key_","v":"_value_"}]` format. `_key_` specifies a header field in a custom request. `_value_` specifies the value of the field.
        /// 
        /// WAF automatically adds the key-value pair to the headers of requests. This way, the requests that pass through WAF are identified.
        /// 
        /// >  If requests contain the custom header field, WAF overwrites the original value of the field with the specified value.
        /// </summary>
        [NameInMap("LogHeaders")]
        [Validation(Required=false)]
        public string LogHeaders { get; set; }

        /// <summary>
        /// The timeout period for read connections of WAF exclusive clusters. Unit: seconds.
        /// 
        /// >  You need to specify the parameter only when the value of the **AccessType** parameter is set to **waf-cloud-dns** and the value of the **ClusterType** parameter is set to **1**.
        /// </summary>
        [NameInMap("ReadTime")]
        [Validation(Required=false)]
        public int? ReadTime { get; set; }

        /// <summary>
        /// The region in which the WAF instance is deployed. Valid values:
        /// 
        /// *   **cn-hangzhou**: Chinese mainland.
        /// *   **ap-southeast-1**: outside the Chinese mainland.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Retry")]
        [Validation(Required=false)]
        public bool? Retry { get; set; }

        /// <summary>
        /// The value of the custom SNI field. If this parameter is not specified, the value of the **Host** field in the request header is automatically used as the value of the SNI field.
        /// 
        /// If you want WAF to use an SNI field whose value is different from the value of the Host field, you can specify a custom value for the SNI field.
        /// 
        /// >  This parameter needs to be set only when the value of the **SniStatus** parameter is set to **1**.
        /// </summary>
        [NameInMap("SniHost")]
        [Validation(Required=false)]
        public string SniHost { get; set; }

        /// <summary>
        /// Specifies whether to enable origin SNI. Origin Server Name Indication (SNI) specifies the domain name to which an HTTPS connection needs to be established at the start of the TLS handshaking process when WAF forwards requests to the origin server. If the origin server hosts multiple domain names, you must enable this feature. Valid values:
        /// 
        /// *   **0**: disables origin SNI.
        /// *   **1**: enables origin SNI.
        /// 
        /// By default, origin SNI is disabled for WAF instances in the Chinese mainland and enabled for WAF instances outside the Chinese mainland.
        /// 
        /// >  You need to specify this parameter only when the value of the **AccessType** parameter is set to **waf-cloud-dns** and the **HttpsPort** parameter is not empty. If the HttpsPort parameter is not empty, your website uses HTTPS.
        /// </summary>
        [NameInMap("SniStatus")]
        [Validation(Required=false)]
        public int? SniStatus { get; set; }

        /// <summary>
        /// The address type of the origin server. The address can be an IP address or a domain name. You can specify only one type of address.
        /// 
        /// *   If you use the IP address type, specify the value in the `["ip1","ip2",...]` format. You can add up to 20 IP addresses.
        /// *   If you use the domain name type, specify the value in the `["domain"]` format. You can enter only one domain name.
        /// 
        /// >  You need to specify the parameter only when the value of the **AccessType** parameter is set to **waf-cloud-dns**.
        /// </summary>
        [NameInMap("SourceIps")]
        [Validation(Required=false)]
        public string SourceIps { get; set; }

        /// <summary>
        /// The timeout period for write connections of WAF exclusive clusters. Unit: seconds.
        /// 
        /// >  You need to specify the parameter only when the value of the **AccessType** parameter is set to **waf-cloud-dns** and the value of the **ClusterType** parameter is set to **1**.
        /// </summary>
        [NameInMap("WriteTime")]
        [Validation(Required=false)]
        public int? WriteTime { get; set; }

    }

}
