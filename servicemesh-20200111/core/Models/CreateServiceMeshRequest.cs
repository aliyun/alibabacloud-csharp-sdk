// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class CreateServiceMeshRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable access log collection. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("AccessLogEnabled")]
        [Validation(Required=false)]
        public bool? AccessLogEnabled { get; set; }

        /// <summary>
        /// Specifies whether to enable access log collection. Valid values:
        /// 
        /// *   "": disables access log collection.
        /// *   `/dev/stdout`: enables access log collection. Access logs are written to /dev/stdout.
        /// </summary>
        [NameInMap("AccessLogFile")]
        [Validation(Required=false)]
        public string AccessLogFile { get; set; }

        /// <summary>
        /// Custom fields of access logs. To set this parameter, you must enable access log collection. Otherwise, you cannot set this parameter. The value must be a JSON string. The following key values must be contained: authority_for, bytes_received, bytes_sent, downstream_local_address, downstream_remote_address, duration, istio_policy_status, method, path, protocol, requested_server_name, response_code, response_flags, route_name, start_time, trace_id, upstream_cluster, upstream_host, upstream_local_address, upstream_service_time, upstream_transport_failure_reason, user_agent, and x_forwarded_for.
        /// </summary>
        [NameInMap("AccessLogFormat")]
        [Validation(Required=false)]
        public string AccessLogFormat { get; set; }

        /// <summary>
        /// The SLS project from which access logs are collected.
        /// </summary>
        [NameInMap("AccessLogProject")]
        [Validation(Required=false)]
        public string AccessLogProject { get; set; }

        /// <summary>
        /// Specifies whether to enable gRPC Access Log Service (ALS) of Envoy. gRPC is short for Google Remote Procedure Call. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("AccessLogServiceEnabled")]
        [Validation(Required=false)]
        public bool? AccessLogServiceEnabled { get; set; }

        /// <summary>
        /// The endpoint of Envoy\"s gRPC ALS.
        /// </summary>
        [NameInMap("AccessLogServiceHost")]
        [Validation(Required=false)]
        public string AccessLogServiceHost { get; set; }

        /// <summary>
        /// The port of Envoy\"s gRPC ALS.
        /// </summary>
        [NameInMap("AccessLogServicePort")]
        [Validation(Required=false)]
        public int? AccessLogServicePort { get; set; }

        /// <summary>
        /// The type of the SLB instance that is bound to Istio Pilot. Valid values: `slb.s1.small`, `slb.s2.small`, `slb.s2.medium`, `slb.s3.small`, `slb.s3.medium`, and `slb.s3.large`.
        /// </summary>
        [NameInMap("ApiServerLoadBalancerSpec")]
        [Validation(Required=false)]
        public string ApiServerLoadBalancerSpec { get; set; }

        /// <summary>
        /// Specifies whether to expose the API server to the Internet. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// 
        /// > If you set this parameter to `false`, the API server cannot be accessed over the Internet.
        /// </summary>
        [NameInMap("ApiServerPublicEip")]
        [Validation(Required=false)]
        public bool? ApiServerPublicEip { get; set; }

        /// <summary>
        /// The name of the Log Service project that is used for mesh audit.
        /// 
        /// Default value: mesh-log-{ASM instance ID}.
        /// </summary>
        [NameInMap("AuditProject")]
        [Validation(Required=false)]
        public string AuditProject { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal for the SLB instance if the SLB instance uses the subscription billing method. Valid values:
        /// 
        /// - true
        /// 
        /// - false
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal period of the SLB instance. This parameter is valid only if the `ChargeType` parameter is set to `PrePay`. If the original subscription period of the SLB instance is less than one year, the value of this parameter indicates the number of months for auto-renewal. If the original subscription period of the SLB instance is more than one year, the value of this parameter indicates the number of years for auto-renewal.
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// Specifies whether to allow the Kubernetes API of clusters on the data plane to access Istio resources. The version of the ASM instance must be V1.9.7.93 or later. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("CRAggregationEnabled")]
        [Validation(Required=false)]
        public bool? CRAggregationEnabled { get; set; }

        /// <summary>
        /// The billing method of the SLB instance. Valid values:
        /// 
        /// *   `PayOnDemand`: pay-as-you-go.
        /// *   `PrePay`: subscription.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The edition of the ASM instance. Valid values:
        /// 
        /// - `standard`: Standard Edition
        /// 
        /// - `enterprise`: Enterprise Edition
        /// 
        /// - `ultimate`: Ultimate Edition
        /// </summary>
        [NameInMap("ClusterSpec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// Specifies whether to enable the external service registry. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("ConfigSourceEnabled")]
        [Validation(Required=false)]
        public bool? ConfigSourceEnabled { get; set; }

        /// <summary>
        /// The instance ID of the Nacos registry.
        /// </summary>
        [NameInMap("ConfigSourceNacosID")]
        [Validation(Required=false)]
        public string ConfigSourceNacosID { get; set; }

        /// <summary>
        /// Specifies whether to enable the collection of control plane logs. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("ControlPlaneLogEnabled")]
        [Validation(Required=false)]
        public bool? ControlPlaneLogEnabled { get; set; }

        /// <summary>
        /// The name of the Log Service project that is used to collect the logs of the control plane.
        /// </summary>
        [NameInMap("ControlPlaneLogProject")]
        [Validation(Required=false)]
        public string ControlPlaneLogProject { get; set; }

        /// <summary>
        /// Specifies whether to use a custom Prometheus instance. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("CustomizedPrometheus")]
        [Validation(Required=false)]
        public bool? CustomizedPrometheus { get; set; }

        /// <summary>
        /// Specifies whether to use a self-managed Zipkin system to collect tracing data. Valid values:
        /// 
        /// *   `true`: uses a self-managed Zipkin system to collect tracing data.
        /// *   `false`: uses Alibaba Cloud Tracing Analysis to collect tracing data.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("CustomizedZipkin")]
        [Validation(Required=false)]
        public bool? CustomizedZipkin { get; set; }

        /// <summary>
        /// Specifies whether to enable the DNS proxy feature. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("DNSProxyingEnabled")]
        [Validation(Required=false)]
        public bool? DNSProxyingEnabled { get; set; }

        /// <summary>
        /// Specifies whether to enable Dubbo Filter. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("DubboFilterEnabled")]
        [Validation(Required=false)]
        public bool? DubboFilterEnabled { get; set; }

        /// <summary>
        /// The edition of the ASM instance.
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        [NameInMap("EnableAmbient")]
        [Validation(Required=false)]
        public bool? EnableAmbient { get; set; }

        /// <summary>
        /// Specifies whether to enable the mesh audit feature. To enable this feature, make sure that you have activated [Log Service](https://sls.console.aliyun.com/). Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("EnableAudit")]
        [Validation(Required=false)]
        public bool? EnableAudit { get; set; }

        /// <summary>
        /// Specifies whether to enable the rollback feature for Istio resources. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("EnableCRHistory")]
        [Validation(Required=false)]
        public bool? EnableCRHistory { get; set; }

        /// <summary>
        /// Specifies whether to enable Secret Discovery Service (SDS). Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("EnableSDSServer")]
        [Validation(Required=false)]
        public bool? EnableSDSServer { get; set; }

        /// <summary>
        /// The IP ranges in CIDR form to be excluded from redirection to the sidecar proxy in the ASM instance.
        /// </summary>
        [NameInMap("ExcludeIPRanges")]
        [Validation(Required=false)]
        public string ExcludeIPRanges { get; set; }

        /// <summary>
        /// The inbound ports to be excluded from redirection to the sidecar proxy in the ASM instance. Separate multiple port numbers with commas (,).
        /// </summary>
        [NameInMap("ExcludeInboundPorts")]
        [Validation(Required=false)]
        public string ExcludeInboundPorts { get; set; }

        /// <summary>
        /// The outbound ports to be excluded from redirection to the sidecar proxy in the ASM instance. Separate multiple port numbers with commas (,).
        /// </summary>
        [NameInMap("ExcludeOutboundPorts")]
        [Validation(Required=false)]
        public string ExcludeOutboundPorts { get; set; }

        /// <summary>
        /// The existing CA certificate, which is encoded in Base64. This parameter is used in scenarios where you migrate open source Istio to ASM. It specifies the content of the ca-cert.pem file in the istio-ca-secret secret. The secret is in the istio-system namespace of the Kubernetes cluster where the open source Istio is installed.
        /// </summary>
        [NameInMap("ExistingCaCert")]
        [Validation(Required=false)]
        public string ExistingCaCert { get; set; }

        /// <summary>
        /// The existing CA key, which is encoded in Base64. This parameter is used in scenarios where you migrate open source Istio to ASM. It specifies the content of the ca-key.pem file in the istio-ca-secret secret. The secret is in the istio-system namespace of the Kubernetes cluster where the open source Istio is installed.
        /// </summary>
        [NameInMap("ExistingCaKey")]
        [Validation(Required=false)]
        public string ExistingCaKey { get; set; }

        /// <summary>
        /// The type of the existing CA certificate. Valid values:
        /// 
        /// *   1: Self-signed certificate generated by istiod. The certificate corresponds to the secret named istio-ca-secret in the istio-system namespace. If you use this type of certificate, you must set the `ExistingCaCert` and `ExsitingCaKey` parameters.
        /// *   2: Administrator-specified certificate. For more information, see [plugin ca cert](https://istio.io/latest/docs/tasks/security/cert-management/plugin-ca-cert/). In most cases, the certificate corresponds to the secret named cacerts in the istio-system namespace. If you use this type of certificate, you must set the `ExisingRootCaCert` and `ExisingRootCaKey` parameters.
        /// </summary>
        [NameInMap("ExistingCaType")]
        [Validation(Required=false)]
        public string ExistingCaType { get; set; }

        /// <summary>
        /// The existing root certificate, which is encoded in Base64.
        /// </summary>
        [NameInMap("ExistingRootCaCert")]
        [Validation(Required=false)]
        public string ExistingRootCaCert { get; set; }

        /// <summary>
        /// The private key that corresponds to the root certificate, which is encoded in Base64.
        /// </summary>
        [NameInMap("ExistingRootCaKey")]
        [Validation(Required=false)]
        public string ExistingRootCaKey { get; set; }

        /// <summary>
        /// Specifies whether to enable gateway configuration filtering. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("FilterGatewayClusterConfig")]
        [Validation(Required=false)]
        public bool? FilterGatewayClusterConfig { get; set; }

        /// <summary>
        /// Specifies whether to enable Gateway API. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("GatewayAPIEnabled")]
        [Validation(Required=false)]
        public bool? GatewayAPIEnabled { get; set; }

        /// <summary>
        /// After this ASM instance is successfully created, automatically add an ACK cluster to it. 
        /// Make sure this ASM instance and ACK cluster have same VPC, VSwitch, cluster domain.
        /// </summary>
        [NameInMap("GuestCluster")]
        [Validation(Required=false)]
        public string GuestCluster { get; set; }

        /// <summary>
        /// The IP ranges in CIDR form for which traffic is to be redirected to the sidecar proxy in the ASM instance.
        /// </summary>
        [NameInMap("IncludeIPRanges")]
        [Validation(Required=false)]
        public string IncludeIPRanges { get; set; }

        /// <summary>
        /// The Istio version of the ASM instance.
        /// </summary>
        [NameInMap("IstioVersion")]
        [Validation(Required=false)]
        public string IstioVersion { get; set; }

        /// <summary>
        /// Specifies whether to enable the mesh topology feature. To enable this feature, make sure that you have enabled Prometheus monitoring. If Prometheus monitoring is disabled, you must set this parameter to `false`.`` Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("KialiEnabled")]
        [Validation(Required=false)]
        public bool? KialiEnabled { get; set; }

        /// <summary>
        /// The configurations for the access to the nearest instance.
        /// </summary>
        [NameInMap("LocalityLBConf")]
        [Validation(Required=false)]
        public string LocalityLBConf { get; set; }

        /// <summary>
        /// Specifies whether to route traffic to the nearest instance. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("LocalityLoadBalancing")]
        [Validation(Required=false)]
        public bool? LocalityLoadBalancing { get; set; }

        /// <summary>
        /// Specifies whether to enable Microservices Engine (MSE). Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("MSEEnabled")]
        [Validation(Required=false)]
        public bool? MSEEnabled { get; set; }

        /// <summary>
        /// Specifies whether to enable MultiBuffer-based Transport Layer Security (TLS) acceleration. Valid values:
        /// 
        /// - `true`
        /// 
        /// - `false`
        /// 
        /// 
        /// Default value: `true`
        /// </summary>
        [NameInMap("MultiBufferEnabled")]
        [Validation(Required=false)]
        public bool? MultiBufferEnabled { get; set; }

        /// <summary>
        /// The pull-request latency. Default value: 30. Unit: seconds.
        /// </summary>
        [NameInMap("MultiBufferPollDelay")]
        [Validation(Required=false)]
        public string MultiBufferPollDelay { get; set; }

        /// <summary>
        /// Specifies whether to enable MySQL Filter. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("MysqlFilterEnabled")]
        [Validation(Required=false)]
        public bool? MysqlFilterEnabled { get; set; }

        /// <summary>
        /// The name of the ASM instance.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The maximum number of CPU cores that are available to the OPA container.
        /// </summary>
        [NameInMap("OPALimitCPU")]
        [Validation(Required=false)]
        public string OPALimitCPU { get; set; }

        /// <summary>
        /// The maximum size of the memory that is available to the OPA container. You can specify the parameter value in the standard quantity representation form used by Kubernetes. 1 Mi equals 1,024 KB.
        /// </summary>
        [NameInMap("OPALimitMemory")]
        [Validation(Required=false)]
        public string OPALimitMemory { get; set; }

        /// <summary>
        /// The log level of the OPA container.
        /// </summary>
        [NameInMap("OPALogLevel")]
        [Validation(Required=false)]
        public string OPALogLevel { get; set; }

        /// <summary>
        /// The minimum number of CPU cores that are required by the OPA container. You can specify the parameter value in the standard representation form of CPUs in Kubernetes. For example, if you set the value to 1, one CPU core is required.
        /// </summary>
        [NameInMap("OPARequestCPU")]
        [Validation(Required=false)]
        public string OPARequestCPU { get; set; }

        /// <summary>
        /// The minimum size of the memory that is required by the OPA container. You can specify the parameter value in the standard quantity representation form used by Kubernetes. 1 Mi equals 1,024 KB.
        /// </summary>
        [NameInMap("OPARequestMemory")]
        [Validation(Required=false)]
        public string OPARequestMemory { get; set; }

        /// <summary>
        /// Specifies whether to enable the OPA plug-in. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("OpaEnabled")]
        [Validation(Required=false)]
        public bool? OpaEnabled { get; set; }

        /// <summary>
        /// Specifies whether to install the Open Policy Agent (OPA) plug-in. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("OpenAgentPolicy")]
        [Validation(Required=false)]
        public bool? OpenAgentPolicy { get; set; }

        /// <summary>
        /// The auto-renewal period of the SLB instance. This parameter is valid only if `ChargeType` is set to `PrePaid`. The value of this parameter indicates the purchased month of the SLB instance when the subscription billing method is used. For example, if the subscription period is one year, set this parameter to 12.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The type of the SLB instance that is bound to Istio Pilot. Valid values: `slb.s1.small`, `slb.s2.small`, `slb.s2.medium`, `slb.s3.small`, `slb.s3.medium`, and `slb.s3.large`.
        /// </summary>
        [NameInMap("PilotLoadBalancerSpec")]
        [Validation(Required=false)]
        public string PilotLoadBalancerSpec { get; set; }

        /// <summary>
        /// The endpoint of the custom Prometheus instance.
        /// </summary>
        [NameInMap("PrometheusUrl")]
        [Validation(Required=false)]
        public string PrometheusUrl { get; set; }

        /// <summary>
        /// The maximum number of CPU cores that are available to the proxy container.
        /// </summary>
        [NameInMap("ProxyLimitCPU")]
        [Validation(Required=false)]
        public string ProxyLimitCPU { get; set; }

        /// <summary>
        /// The maximum size of the memory that is available to the proxy container.
        /// </summary>
        [NameInMap("ProxyLimitMemory")]
        [Validation(Required=false)]
        public string ProxyLimitMemory { get; set; }

        /// <summary>
        /// The minimum number of CPU cores that are required by the proxy container.
        /// </summary>
        [NameInMap("ProxyRequestCPU")]
        [Validation(Required=false)]
        public string ProxyRequestCPU { get; set; }

        /// <summary>
        /// The minimum size of the memory that is required by the proxy container.
        /// </summary>
        [NameInMap("ProxyRequestMemory")]
        [Validation(Required=false)]
        public string ProxyRequestMemory { get; set; }

        /// <summary>
        /// Specifies whether to enable Redis Filter. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("RedisFilterEnabled")]
        [Validation(Required=false)]
        public bool? RedisFilterEnabled { get; set; }

        /// <summary>
        /// The ID of the region in which the ASM instance resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateServiceMeshRequestTag> Tag { get; set; }
        public class CreateServiceMeshRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// Specifies whether to enable Prometheus monitoring. We recommend that you use Prometheus Service of [Application Real-Time Monitoring Service (ARMS)](https://arms.console.aliyun.com/). Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("Telemetry")]
        [Validation(Required=false)]
        public bool? Telemetry { get; set; }

        /// <summary>
        /// Specifies whether to enable Thrift Filter. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("ThriftFilterEnabled")]
        [Validation(Required=false)]
        public bool? ThriftFilterEnabled { get; set; }

        /// <summary>
        /// The sampling percentage of Tracing Analysis.
        /// </summary>
        [NameInMap("TraceSampling")]
        [Validation(Required=false)]
        public float? TraceSampling { get; set; }

        /// <summary>
        /// Specifies whether to enable the Tracing Analysis feature. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("Tracing")]
        [Validation(Required=false)]
        public bool? Tracing { get; set; }

        /// <summary>
        /// Specifies whether to use an existing CA certificate and private key.
        /// </summary>
        [NameInMap("UseExistingCA")]
        [Validation(Required=false)]
        public bool? UseExistingCA { get; set; }

        /// <summary>
        /// The ID of the vSwitch to which the ASM instance is connected.
        /// </summary>
        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public string VSwitches { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) in which the ASM instance resides.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// Specifies whether to enable WebAssembly Filter. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("WebAssemblyFilterEnabled")]
        [Validation(Required=false)]
        public bool? WebAssemblyFilterEnabled { get; set; }

    }

}
