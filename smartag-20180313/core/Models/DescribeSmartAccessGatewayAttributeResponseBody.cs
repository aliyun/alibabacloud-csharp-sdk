// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSmartAccessGatewayAttributeResponseBody : TeaModel {
        [NameInMap("AccelerateBandwidth")]
        [Validation(Required=false)]
        public long? AccelerateBandwidth { get; set; }

        [NameInMap("AccessPointId")]
        [Validation(Required=false)]
        public string AccessPointId { get; set; }

        [NameInMap("AclIds")]
        [Validation(Required=false)]
        public DescribeSmartAccessGatewayAttributeResponseBodyAclIds AclIds { get; set; }
        public class DescribeSmartAccessGatewayAttributeResponseBodyAclIds : TeaModel {
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public List<string> AclId { get; set; }

        }

        [NameInMap("ApplicationBandwidthPackageBussinessStatus")]
        [Validation(Required=false)]
        public string ApplicationBandwidthPackageBussinessStatus { get; set; }

        [NameInMap("ApplicationBandwidthPackageId")]
        [Validation(Required=false)]
        public string ApplicationBandwidthPackageId { get; set; }

        [NameInMap("ApplicationBandwidthPackageName")]
        [Validation(Required=false)]
        public string ApplicationBandwidthPackageName { get; set; }

        [NameInMap("ApplicationBandwidthPackageOperationLocks")]
        [Validation(Required=false)]
        public DescribeSmartAccessGatewayAttributeResponseBodyApplicationBandwidthPackageOperationLocks ApplicationBandwidthPackageOperationLocks { get; set; }
        public class DescribeSmartAccessGatewayAttributeResponseBodyApplicationBandwidthPackageOperationLocks : TeaModel {
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            [NameInMap("LockType")]
            [Validation(Required=false)]
            public string LockType { get; set; }

        }

        [NameInMap("AssociatedCcnId")]
        [Validation(Required=false)]
        public string AssociatedCcnId { get; set; }

        [NameInMap("AssociatedCcnName")]
        [Validation(Required=false)]
        public string AssociatedCcnName { get; set; }

        [NameInMap("BackupBoxControllerIp")]
        [Validation(Required=false)]
        public string BackupBoxControllerIp { get; set; }

        [NameInMap("BoxControllerIp")]
        [Validation(Required=false)]
        public string BoxControllerIp { get; set; }

        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("DataPlan")]
        [Validation(Required=false)]
        public long? DataPlan { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Devices")]
        [Validation(Required=false)]
        public DescribeSmartAccessGatewayAttributeResponseBodyDevices Devices { get; set; }
        public class DescribeSmartAccessGatewayAttributeResponseBodyDevices : TeaModel {
            [NameInMap("Device")]
            [Validation(Required=false)]
            public List<DescribeSmartAccessGatewayAttributeResponseBodyDevicesDevice> Device { get; set; }
            public class DescribeSmartAccessGatewayAttributeResponseBodyDevicesDevice : TeaModel {
                [NameInMap("DistributeSkStatus")]
                [Validation(Required=false)]
                public int? DistributeSkStatus { get; set; }

                [NameInMap("DpiSignatureDbVersion")]
                [Validation(Required=false)]
                public string DpiSignatureDbVersion { get; set; }

                [NameInMap("HaState")]
                [Validation(Required=false)]
                public string HaState { get; set; }

                [NameInMap("HcState")]
                [Validation(Required=false)]
                public string HcState { get; set; }

                [NameInMap("MonitorVersion")]
                [Validation(Required=false)]
                public string MonitorVersion { get; set; }

                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                [NameInMap("SoftwareVersion")]
                [Validation(Required=false)]
                public string SoftwareVersion { get; set; }

            }

        }

        [NameInMap("EnableOptimization")]
        [Validation(Required=false)]
        public bool? EnableOptimization { get; set; }

        [NameInMap("EnableSoftwareConnectionAudit")]
        [Validation(Required=false)]
        public bool? EnableSoftwareConnectionAudit { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("FlowLogIds")]
        [Validation(Required=false)]
        public DescribeSmartAccessGatewayAttributeResponseBodyFlowLogIds FlowLogIds { get; set; }
        public class DescribeSmartAccessGatewayAttributeResponseBodyFlowLogIds : TeaModel {
            [NameInMap("FlowLogId")]
            [Validation(Required=false)]
            public List<string> FlowLogId { get; set; }

        }

        [NameInMap("IRIds")]
        [Validation(Required=false)]
        public DescribeSmartAccessGatewayAttributeResponseBodyIRIds IRIds { get; set; }
        public class DescribeSmartAccessGatewayAttributeResponseBodyIRIds : TeaModel {
            [NameInMap("IRId")]
            [Validation(Required=false)]
            public List<string> IRId { get; set; }

        }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("IpsecStatus")]
        [Validation(Required=false)]
        public string IpsecStatus { get; set; }

        [NameInMap("Links")]
        [Validation(Required=false)]
        public DescribeSmartAccessGatewayAttributeResponseBodyLinks Links { get; set; }
        public class DescribeSmartAccessGatewayAttributeResponseBodyLinks : TeaModel {
            [NameInMap("Link")]
            [Validation(Required=false)]
            public List<DescribeSmartAccessGatewayAttributeResponseBodyLinksLink> Link { get; set; }
            public class DescribeSmartAccessGatewayAttributeResponseBodyLinksLink : TeaModel {
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                [NameInMap("CommodityType")]
                [Validation(Required=false)]
                public string CommodityType { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("HealthCheckTargetIp")]
                [Validation(Required=false)]
                public string HealthCheckTargetIp { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("RelateInstanceId")]
                [Validation(Required=false)]
                public string RelateInstanceId { get; set; }

                [NameInMap("RelateInstanceRegionId")]
                [Validation(Required=false)]
                public string RelateInstanceRegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("MaxBandwidth")]
        [Validation(Required=false)]
        public string MaxBandwidth { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OptimizationType")]
        [Validation(Required=false)]
        public bool? OptimizationType { get; set; }

        [NameInMap("Position")]
        [Validation(Required=false)]
        public string Position { get; set; }

        [NameInMap("QosIds")]
        [Validation(Required=false)]
        public DescribeSmartAccessGatewayAttributeResponseBodyQosIds QosIds { get; set; }
        public class DescribeSmartAccessGatewayAttributeResponseBodyQosIds : TeaModel {
            [NameInMap("QosId")]
            [Validation(Required=false)]
            public List<string> QosId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResellerInstanceId")]
        [Validation(Required=false)]
        public string ResellerInstanceId { get; set; }

        [NameInMap("ResellerUid")]
        [Validation(Required=false)]
        public string ResellerUid { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("RoutingStrategy")]
        [Validation(Required=false)]
        public string RoutingStrategy { get; set; }

        [NameInMap("SecurityLockThreshold")]
        [Validation(Required=false)]
        public int? SecurityLockThreshold { get; set; }

        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TrafficMasterSn")]
        [Validation(Required=false)]
        public string TrafficMasterSn { get; set; }

        [NameInMap("UpBandwidth4G")]
        [Validation(Required=false)]
        public int? UpBandwidth4G { get; set; }

        [NameInMap("UpBandwidthWan")]
        [Validation(Required=false)]
        public int? UpBandwidthWan { get; set; }

        [NameInMap("UserCount")]
        [Validation(Required=false)]
        public int? UserCount { get; set; }

        [NameInMap("VpnStatus")]
        [Validation(Required=false)]
        public string VpnStatus { get; set; }

    }

}
