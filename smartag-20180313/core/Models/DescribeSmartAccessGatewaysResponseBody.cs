// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSmartAccessGatewaysResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SmartAccessGateways")]
        [Validation(Required=false)]
        public DescribeSmartAccessGatewaysResponseBodySmartAccessGateways SmartAccessGateways { get; set; }
        public class DescribeSmartAccessGatewaysResponseBodySmartAccessGateways : TeaModel {
            [NameInMap("SmartAccessGateway")]
            [Validation(Required=false)]
            public List<DescribeSmartAccessGatewaysResponseBodySmartAccessGatewaysSmartAccessGateway> SmartAccessGateway { get; set; }
            public class DescribeSmartAccessGatewaysResponseBodySmartAccessGatewaysSmartAccessGateway : TeaModel {
                [NameInMap("AccelerateBandwidth")]
                [Validation(Required=false)]
                public long? AccelerateBandwidth { get; set; }

                [NameInMap("AccessPointId")]
                [Validation(Required=false)]
                public string AccessPointId { get; set; }

                [NameInMap("AclIds")]
                [Validation(Required=false)]
                public string AclIds { get; set; }

                [NameInMap("ApplicationBandwidthPackageId")]
                [Validation(Required=false)]
                public string ApplicationBandwidthPackageId { get; set; }

                [NameInMap("AssociatedCcnId")]
                [Validation(Required=false)]
                public string AssociatedCcnId { get; set; }

                [NameInMap("AssociatedCcnName")]
                [Validation(Required=false)]
                public string AssociatedCcnName { get; set; }

                [NameInMap("BackupSoftwareVersion")]
                [Validation(Required=false)]
                public string BackupSoftwareVersion { get; set; }

                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

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

                [NameInMap("DpiMonitorStatus")]
                [Validation(Required=false)]
                public string DpiMonitorStatus { get; set; }

                [NameInMap("DpiStatus")]
                [Validation(Required=false)]
                public string DpiStatus { get; set; }

                [NameInMap("EnableAdvancedMonitor")]
                [Validation(Required=false)]
                public bool? EnableAdvancedMonitor { get; set; }

                [NameInMap("EnableSoftwareConnectionAudit")]
                [Validation(Required=false)]
                public bool? EnableSoftwareConnectionAudit { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("EnterpriseCode")]
                [Validation(Required=false)]
                public string EnterpriseCode { get; set; }

                [NameInMap("HardwareVersion")]
                [Validation(Required=false)]
                public string HardwareVersion { get; set; }

                [NameInMap("IRIds")]
                [Validation(Required=false)]
                public string IRIds { get; set; }

                [NameInMap("IdaasApplicationId")]
                [Validation(Required=false)]
                public string IdaasApplicationId { get; set; }

                [NameInMap("IdaasId")]
                [Validation(Required=false)]
                public string IdaasId { get; set; }

                [NameInMap("IpsecStatus")]
                [Validation(Required=false)]
                public string IpsecStatus { get; set; }

                [NameInMap("Isp")]
                [Validation(Required=false)]
                public string Isp { get; set; }

                [NameInMap("Links")]
                [Validation(Required=false)]
                public DescribeSmartAccessGatewaysResponseBodySmartAccessGatewaysSmartAccessGatewayLinks Links { get; set; }
                public class DescribeSmartAccessGatewaysResponseBodySmartAccessGatewaysSmartAccessGatewayLinks : TeaModel {
                    [NameInMap("Link")]
                    [Validation(Required=false)]
                    public List<DescribeSmartAccessGatewaysResponseBodySmartAccessGatewaysSmartAccessGatewayLinksLink> Link { get; set; }
                    public class DescribeSmartAccessGatewaysResponseBodySmartAccessGatewaysSmartAccessGatewayLinksLink : TeaModel {
                        [NameInMap("Bandwidth")]
                        [Validation(Required=false)]
                        public string Bandwidth { get; set; }

                        [NameInMap("CommodityType")]
                        [Validation(Required=false)]
                        public string CommodityType { get; set; }

                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public long? EndTime { get; set; }

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

                [NameInMap("Position")]
                [Validation(Required=false)]
                public string Position { get; set; }

                [NameInMap("QosIds")]
                [Validation(Required=false)]
                public string QosIds { get; set; }

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

                [NameInMap("SmartAGUid")]
                [Validation(Required=false)]
                public long? SmartAGUid { get; set; }

                [NameInMap("SoftwareVersion")]
                [Validation(Required=false)]
                public string SoftwareVersion { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
