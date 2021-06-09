// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSmartAccessGatewaysResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("SmartAccessGateways")]
        [Validation(Required=false)]
        public DescribeSmartAccessGatewaysResponseBodySmartAccessGateways SmartAccessGateways { get; set; }
        public class DescribeSmartAccessGatewaysResponseBodySmartAccessGateways : TeaModel {
            [NameInMap("SmartAccessGateway")]
            [Validation(Required=false)]
            public List<DescribeSmartAccessGatewaysResponseBodySmartAccessGatewaysSmartAccessGateway> SmartAccessGateway { get; set; }
            public class DescribeSmartAccessGatewaysResponseBodySmartAccessGatewaysSmartAccessGateway : TeaModel {
                public string SerialNumber { get; set; }
                public string Status { get; set; }
                public int? UpBandwidth4G { get; set; }
                public string BackupStatus { get; set; }
                public string IdaasApplicationId { get; set; }
                public string SoftwareVersion { get; set; }
                public long? CreateTime { get; set; }
                public string SmartAGId { get; set; }
                public int? UpBandwidthWan { get; set; }
                public string City { get; set; }
                public string AclIds { get; set; }
                public string QosIds { get; set; }
                public string CidrBlock { get; set; }
                public string Description { get; set; }
                public string IpsecStatus { get; set; }
                public string EnterpriseCode { get; set; }
                public string DpiStatus { get; set; }
                public string AssociatedCcnId { get; set; }
                public string Name { get; set; }
                public string HardwareVersion { get; set; }
                public string IdaasId { get; set; }
                public long? DataPlan { get; set; }
                public string AssociatedCcnName { get; set; }
                public string ResellerUid { get; set; }
                public string DpiMonitorStatus { get; set; }
                public string MaxBandwidth { get; set; }
                public long? SmartAGUid { get; set; }
                public string BackupSoftwareVersion { get; set; }
                public long? EndTime { get; set; }
                public string ResellerInstanceId { get; set; }
                public string VpnStatus { get; set; }
                public string RoutingStrategy { get; set; }
                public int? SecurityLockThreshold { get; set; }
                public DescribeSmartAccessGatewaysResponseBodySmartAccessGatewaysSmartAccessGatewayLinks Links { get; set; }
                public class DescribeSmartAccessGatewaysResponseBodySmartAccessGatewaysSmartAccessGatewayLinks : TeaModel {
                    [NameInMap("Link")]
                    [Validation(Required=false)]
                    public List<DescribeSmartAccessGatewaysResponseBodySmartAccessGatewaysSmartAccessGatewayLinksLink> Link { get; set; }
                    public class DescribeSmartAccessGatewaysResponseBodySmartAccessGatewaysSmartAccessGatewayLinksLink : TeaModel {
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public long? EndTime { get; set; }

                        [NameInMap("Bandwidth")]
                        [Validation(Required=false)]
                        public string Bandwidth { get; set; }

                        [NameInMap("RelateInstanceRegionId")]
                        [Validation(Required=false)]
                        public string RelateInstanceRegionId { get; set; }

                        [NameInMap("RelateInstanceId")]
                        [Validation(Required=false)]
                        public string RelateInstanceId { get; set; }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("CommodityType")]
                        [Validation(Required=false)]
                        public string CommodityType { get; set; }

                    }

                }
                public string ResourceGroupId { get; set; }
                public int? UserCount { get; set; }
                public string AccessPointId { get; set; }
                public string ApplicationBandwidthPackageId { get; set; }
                public long? AccelerateBandwidth { get; set; }
            }
        };

    }

}
