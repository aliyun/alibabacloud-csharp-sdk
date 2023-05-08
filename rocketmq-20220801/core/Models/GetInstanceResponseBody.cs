// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetInstanceResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyData Data { get; set; }
        public class GetInstanceResponseBodyData : TeaModel {
            [NameInMap("accountInfo")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyDataAccountInfo AccountInfo { get; set; }
            public class GetInstanceResponseBodyDataAccountInfo : TeaModel {
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            [NameInMap("aclInfo")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyDataAclInfo AclInfo { get; set; }
            public class GetInstanceResponseBodyDataAclInfo : TeaModel {
                [NameInMap("aclType")]
                [Validation(Required=false)]
                public string AclType { get; set; }

            }

            /// <summary>
            /// BID
            /// </summary>
            [NameInMap("bid")]
            [Validation(Required=false)]
            public string Bid { get; set; }

            [NameInMap("commodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("expireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("extConfig")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyDataExtConfig ExtConfig { get; set; }
            public class GetInstanceResponseBodyDataExtConfig : TeaModel {
                [NameInMap("aclType")]
                [Validation(Required=false)]
                public string AclType { get; set; }

                [NameInMap("autoScaling")]
                [Validation(Required=false)]
                public bool? AutoScaling { get; set; }

                [NameInMap("flowOutBandwidth")]
                [Validation(Required=false)]
                public int? FlowOutBandwidth { get; set; }

                [NameInMap("flowOutType")]
                [Validation(Required=false)]
                public string FlowOutType { get; set; }

                [NameInMap("internetSpec")]
                [Validation(Required=false)]
                public string InternetSpec { get; set; }

                [NameInMap("messageRetentionTime")]
                [Validation(Required=false)]
                public int? MessageRetentionTime { get; set; }

                [NameInMap("msgProcessSpec")]
                [Validation(Required=false)]
                public string MsgProcessSpec { get; set; }

                [NameInMap("sendReceiveRatio")]
                [Validation(Required=false)]
                public float? SendReceiveRatio { get; set; }

                [NameInMap("supportAutoScaling")]
                [Validation(Required=false)]
                public bool? SupportAutoScaling { get; set; }

            }

            [NameInMap("groupCount")]
            [Validation(Required=false)]
            public long? GroupCount { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("instanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("instanceQuotas")]
            [Validation(Required=false)]
            public List<GetInstanceResponseBodyDataInstanceQuotas> InstanceQuotas { get; set; }
            public class GetInstanceResponseBodyDataInstanceQuotas : TeaModel {
                [NameInMap("freeCount")]
                [Validation(Required=false)]
                public double? FreeCount { get; set; }

                [NameInMap("quotaName")]
                [Validation(Required=false)]
                public string QuotaName { get; set; }

                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public double? TotalCount { get; set; }

                [NameInMap("usedCount")]
                [Validation(Required=false)]
                public double? UsedCount { get; set; }

            }

            [NameInMap("networkInfo")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyDataNetworkInfo NetworkInfo { get; set; }
            public class GetInstanceResponseBodyDataNetworkInfo : TeaModel {
                [NameInMap("endpoints")]
                [Validation(Required=false)]
                public List<GetInstanceResponseBodyDataNetworkInfoEndpoints> Endpoints { get; set; }
                public class GetInstanceResponseBodyDataNetworkInfoEndpoints : TeaModel {
                    [NameInMap("endpointType")]
                    [Validation(Required=false)]
                    public string EndpointType { get; set; }

                    [NameInMap("endpointUrl")]
                    [Validation(Required=false)]
                    public string EndpointUrl { get; set; }

                    [NameInMap("ipWhitelist")]
                    [Validation(Required=false)]
                    public List<string> IpWhitelist { get; set; }

                }

                [NameInMap("internetInfo")]
                [Validation(Required=false)]
                public GetInstanceResponseBodyDataNetworkInfoInternetInfo InternetInfo { get; set; }
                public class GetInstanceResponseBodyDataNetworkInfoInternetInfo : TeaModel {
                    [NameInMap("flowOutBandwidth")]
                    [Validation(Required=false)]
                    public int? FlowOutBandwidth { get; set; }

                    [NameInMap("flowOutType")]
                    [Validation(Required=false)]
                    public string FlowOutType { get; set; }

                    [NameInMap("internetSpec")]
                    [Validation(Required=false)]
                    public string InternetSpec { get; set; }

                    [NameInMap("ipWhitelist")]
                    [Validation(Required=false)]
                    public List<string> IpWhitelist { get; set; }

                }

                [NameInMap("vpcInfo")]
                [Validation(Required=false)]
                public GetInstanceResponseBodyDataNetworkInfoVpcInfo VpcInfo { get; set; }
                public class GetInstanceResponseBodyDataNetworkInfoVpcInfo : TeaModel {
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    [NameInMap("vpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

            }

            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            [NameInMap("productInfo")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyDataProductInfo ProductInfo { get; set; }
            public class GetInstanceResponseBodyDataProductInfo : TeaModel {
                [NameInMap("autoScaling")]
                [Validation(Required=false)]
                public bool? AutoScaling { get; set; }

                [NameInMap("messageRetentionTime")]
                [Validation(Required=false)]
                public int? MessageRetentionTime { get; set; }

                [NameInMap("msgProcessSpec")]
                [Validation(Required=false)]
                public string MsgProcessSpec { get; set; }

                [NameInMap("sendReceiveRatio")]
                [Validation(Required=false)]
                public float? SendReceiveRatio { get; set; }

                [NameInMap("supportAutoScaling")]
                [Validation(Required=false)]
                public bool? SupportAutoScaling { get; set; }

            }

            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("releaseTime")]
            [Validation(Required=false)]
            public string ReleaseTime { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("seriesCode")]
            [Validation(Required=false)]
            public string SeriesCode { get; set; }

            [NameInMap("serviceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            [NameInMap("software")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyDataSoftware Software { get; set; }
            public class GetInstanceResponseBodyDataSoftware : TeaModel {
                [NameInMap("maintainTime")]
                [Validation(Required=false)]
                public string MaintainTime { get; set; }

                [NameInMap("softwareVersion")]
                [Validation(Required=false)]
                public string SoftwareVersion { get; set; }

                [NameInMap("upgradeMethod")]
                [Validation(Required=false)]
                public string UpgradeMethod { get; set; }

            }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("subSeriesCode")]
            [Validation(Required=false)]
            public string SubSeriesCode { get; set; }

            [NameInMap("topicCount")]
            [Validation(Required=false)]
            public long? TopicCount { get; set; }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
