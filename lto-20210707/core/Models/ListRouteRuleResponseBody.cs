// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Lto20210707.Models
{
    public class ListRouteRuleResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRouteRuleResponseBodyData Data { get; set; }
        public class ListRouteRuleResponseBodyData : TeaModel {
            [NameInMap("Num")]
            [Validation(Required=false)]
            public int? Num { get; set; }

            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<ListRouteRuleResponseBodyDataPageData> PageData { get; set; }
            public class ListRouteRuleResponseBodyDataPageData : TeaModel {
                [NameInMap("BizChainId")]
                [Validation(Required=false)]
                public long? BizChainId { get; set; }

                [NameInMap("BizChainName")]
                [Validation(Required=false)]
                public string BizChainName { get; set; }

                [NameInMap("BlockChainType")]
                [Validation(Required=false)]
                public string BlockChainType { get; set; }

                [NameInMap("ChainUpMode")]
                [Validation(Required=false)]
                public string ChainUpMode { get; set; }

                [NameInMap("ContractName")]
                [Validation(Required=false)]
                public string ContractName { get; set; }

                [NameInMap("ContractTemplateId")]
                [Validation(Required=false)]
                public string ContractTemplateId { get; set; }

                [NameInMap("DeviceGroupId")]
                [Validation(Required=false)]
                public string DeviceGroupId { get; set; }

                [NameInMap("DeviceGroupName")]
                [Validation(Required=false)]
                public string DeviceGroupName { get; set; }

                [NameInMap("InvokeType")]
                [Validation(Required=false)]
                public string InvokeType { get; set; }

                [NameInMap("PrivacyRuleId")]
                [Validation(Required=false)]
                public string PrivacyRuleId { get; set; }

                [NameInMap("PrivacyRuleName")]
                [Validation(Required=false)]
                public string PrivacyRuleName { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("RouteRuleId")]
                [Validation(Required=false)]
                public string RouteRuleId { get; set; }

            }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

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
