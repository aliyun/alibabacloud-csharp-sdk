// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetUnactivatedLicenseOrderResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetUnactivatedLicenseOrderResponseBodyData> Data { get; set; }
        public class GetUnactivatedLicenseOrderResponseBodyData : TeaModel {
            [NameInMap("BeginOn")]
            [Validation(Required=false)]
            public string BeginOn { get; set; }

            [NameInMap("ContractNo")]
            [Validation(Required=false)]
            public string ContractNo { get; set; }

            [NameInMap("ExpiredOn")]
            [Validation(Required=false)]
            public string ExpiredOn { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("LicenseConfigs")]
            [Validation(Required=false)]
            public List<GetUnactivatedLicenseOrderResponseBodyDataLicenseConfigs> LicenseConfigs { get; set; }
            public class GetUnactivatedLicenseOrderResponseBodyDataLicenseConfigs : TeaModel {
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                [NameInMap("FeatureIds")]
                [Validation(Required=false)]
                public string FeatureIds { get; set; }

                [NameInMap("IsTrial")]
                [Validation(Required=false)]
                public bool? IsTrial { get; set; }

                [NameInMap("SdkId")]
                [Validation(Required=false)]
                public string SdkId { get; set; }

                [NameInMap("SdkName")]
                [Validation(Required=false)]
                public string SdkName { get; set; }

                [NameInMap("Subscription")]
                [Validation(Required=false)]
                public string Subscription { get; set; }

                [NameInMap("SubscriptionImp")]
                [Validation(Required=false)]
                public string SubscriptionImp { get; set; }

                [NameInMap("SubscriptionPkg")]
                [Validation(Required=false)]
                public string SubscriptionPkg { get; set; }

            }

            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
