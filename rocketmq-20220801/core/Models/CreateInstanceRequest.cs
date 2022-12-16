// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class CreateInstanceRequest : TeaModel {
        [NameInMap("autoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        [NameInMap("autoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("networkInfo")]
        [Validation(Required=false)]
        public CreateInstanceRequestNetworkInfo NetworkInfo { get; set; }
        public class CreateInstanceRequestNetworkInfo : TeaModel {
            [NameInMap("internetInfo")]
            [Validation(Required=false)]
            public CreateInstanceRequestNetworkInfoInternetInfo InternetInfo { get; set; }
            public class CreateInstanceRequestNetworkInfoInternetInfo : TeaModel {
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
            public CreateInstanceRequestNetworkInfoVpcInfo VpcInfo { get; set; }
            public class CreateInstanceRequestNetworkInfoVpcInfo : TeaModel {
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

        [NameInMap("period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("periodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("productInfo")]
        [Validation(Required=false)]
        public CreateInstanceRequestProductInfo ProductInfo { get; set; }
        public class CreateInstanceRequestProductInfo : TeaModel {
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

        }

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

        [NameInMap("subSeriesCode")]
        [Validation(Required=false)]
        public string SubSeriesCode { get; set; }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
