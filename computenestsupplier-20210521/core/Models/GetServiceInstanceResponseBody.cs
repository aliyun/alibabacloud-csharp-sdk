// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetServiceInstanceResponseBody : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("EnableInstanceOps")]
        [Validation(Required=false)]
        public bool? EnableInstanceOps { get; set; }

        [NameInMap("EnableUserPrometheus")]
        [Validation(Required=false)]
        public string EnableUserPrometheus { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("IsOperated")]
        [Validation(Required=false)]
        public bool? IsOperated { get; set; }

        [NameInMap("LicenseMetadata")]
        [Validation(Required=false)]
        public string LicenseMetadata { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NetworkConfig")]
        [Validation(Required=false)]
        public GetServiceInstanceResponseBodyNetworkConfig NetworkConfig { get; set; }
        public class GetServiceInstanceResponseBodyNetworkConfig : TeaModel {
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            [NameInMap("EndpointServiceId")]
            [Validation(Required=false)]
            public string EndpointServiceId { get; set; }

            [NameInMap("PrivateVpcConnections")]
            [Validation(Required=false)]
            public List<GetServiceInstanceResponseBodyNetworkConfigPrivateVpcConnections> PrivateVpcConnections { get; set; }
            public class GetServiceInstanceResponseBodyNetworkConfigPrivateVpcConnections : TeaModel {
                [NameInMap("ConnectionConfigs")]
                [Validation(Required=false)]
                public List<GetServiceInstanceResponseBodyNetworkConfigPrivateVpcConnectionsConnectionConfigs> ConnectionConfigs { get; set; }
                public class GetServiceInstanceResponseBodyNetworkConfigPrivateVpcConnectionsConnectionConfigs : TeaModel {
                    [NameInMap("ConnectBandwidth")]
                    [Validation(Required=false)]
                    public int? ConnectBandwidth { get; set; }

                    [NameInMap("DomainName")]
                    [Validation(Required=false)]
                    public string DomainName { get; set; }

                    [NameInMap("EndpointIps")]
                    [Validation(Required=false)]
                    public List<string> EndpointIps { get; set; }

                    [NameInMap("IngressEndpointStatus")]
                    [Validation(Required=false)]
                    public string IngressEndpointStatus { get; set; }

                    [NameInMap("NetworkServiceStatus")]
                    [Validation(Required=false)]
                    public string NetworkServiceStatus { get; set; }

                    [NameInMap("SecurityGroups")]
                    [Validation(Required=false)]
                    public List<string> SecurityGroups { get; set; }

                    [NameInMap("VSwitches")]
                    [Validation(Required=false)]
                    public List<string> VSwitches { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                [NameInMap("EndpointServiceId")]
                [Validation(Required=false)]
                public string EndpointServiceId { get; set; }

                [NameInMap("PrivateZoneName")]
                [Validation(Required=false)]
                public string PrivateZoneName { get; set; }

            }

            [NameInMap("ReversePrivateVpcConnections")]
            [Validation(Required=false)]
            public List<GetServiceInstanceResponseBodyNetworkConfigReversePrivateVpcConnections> ReversePrivateVpcConnections { get; set; }
            public class GetServiceInstanceResponseBodyNetworkConfigReversePrivateVpcConnections : TeaModel {
                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                [NameInMap("EndpointServiceId")]
                [Validation(Required=false)]
                public string EndpointServiceId { get; set; }

            }

        }

        [NameInMap("OperatedServiceInstanceId")]
        [Validation(Required=false)]
        public string OperatedServiceInstanceId { get; set; }

        [NameInMap("OperationEndTime")]
        [Validation(Required=false)]
        public string OperationEndTime { get; set; }

        [NameInMap("OperationStartTime")]
        [Validation(Required=false)]
        public string OperationStartTime { get; set; }

        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public string Outputs { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("Progress")]
        [Validation(Required=false)]
        public long? Progress { get; set; }

        [NameInMap("RdAccountLoginUrl")]
        [Validation(Required=false)]
        public string RdAccountLoginUrl { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        [NameInMap("Service")]
        [Validation(Required=false)]
        public GetServiceInstanceResponseBodyService Service { get; set; }
        public class GetServiceInstanceResponseBodyService : TeaModel {
            [NameInMap("DeployMetadata")]
            [Validation(Required=false)]
            public string DeployMetadata { get; set; }

            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            [NameInMap("ServiceDocUrl")]
            [Validation(Required=false)]
            public string ServiceDocUrl { get; set; }

            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            [NameInMap("ServiceInfos")]
            [Validation(Required=false)]
            public List<GetServiceInstanceResponseBodyServiceServiceInfos> ServiceInfos { get; set; }
            public class GetServiceInstanceResponseBodyServiceServiceInfos : TeaModel {
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                [NameInMap("Locale")]
                [Validation(Required=false)]
                public string Locale { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ShortDescription")]
                [Validation(Required=false)]
                public string ShortDescription { get; set; }

            }

            [NameInMap("ServiceProductUrl")]
            [Validation(Required=false)]
            public string ServiceProductUrl { get; set; }

            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SupplierName")]
            [Validation(Required=false)]
            public string SupplierName { get; set; }

            [NameInMap("SupplierUrl")]
            [Validation(Required=false)]
            public string SupplierUrl { get; set; }

            [NameInMap("UpgradableServiceVersions")]
            [Validation(Required=false)]
            public List<string> UpgradableServiceVersions { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("StatusDetail")]
        [Validation(Required=false)]
        public string StatusDetail { get; set; }

        [NameInMap("SupplierUid")]
        [Validation(Required=false)]
        public long? SupplierUid { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetServiceInstanceResponseBodyTags> Tags { get; set; }
        public class GetServiceInstanceResponseBodyTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
