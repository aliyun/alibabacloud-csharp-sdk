// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QuerySmsUserTagsNewResponseBody : TeaModel {
        [NameInMap("IsAnyParamTemplateUser")]
        [Validation(Required=false)]
        public bool? IsAnyParamTemplateUser { get; set; }

        [NameInMap("IsBatchCreateSmsSign")]
        [Validation(Required=false)]
        public bool? IsBatchCreateSmsSign { get; set; }

        [NameInMap("IsInnerUser")]
        [Validation(Required=false)]
        public bool? IsInnerUser { get; set; }

        [NameInMap("IsNewUser")]
        [Validation(Required=false)]
        public bool? IsNewUser { get; set; }

        [NameInMap("IsNoneStatusNoChargeCust")]
        [Validation(Required=false)]
        public bool? IsNoneStatusNoChargeCust { get; set; }

        [NameInMap("IsOpenTemplateRule")]
        [Validation(Required=false)]
        public bool? IsOpenTemplateRule { get; set; }

        [NameInMap("IsOpenedCard")]
        [Validation(Required=false)]
        public bool? IsOpenedCard { get; set; }

        [NameInMap("IsOpenedDigit")]
        [Validation(Required=false)]
        public bool? IsOpenedDigit { get; set; }

        [NameInMap("IsOpenedInternationalSms")]
        [Validation(Required=false)]
        public bool? IsOpenedInternationalSms { get; set; }

        [NameInMap("IsOpenedMarket")]
        [Validation(Required=false)]
        public bool? IsOpenedMarket { get; set; }

        [NameInMap("IsOpenedSaas")]
        [Validation(Required=false)]
        public bool? IsOpenedSaas { get; set; }

        [NameInMap("IsOpenedSmppStandardProtocol")]
        [Validation(Required=false)]
        public bool? IsOpenedSmppStandardProtocol { get; set; }

        [NameInMap("IsOpenedStandardProtocol")]
        [Validation(Required=false)]
        public bool? IsOpenedStandardProtocol { get; set; }

        [NameInMap("IsVirtualCust")]
        [Validation(Required=false)]
        public bool? IsVirtualCust { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public bool? RequestId { get; set; }

        [NameInMap("SignCheckCommon")]
        [Validation(Required=false)]
        public bool? SignCheckCommon { get; set; }

        [NameInMap("SignCheckVerification")]
        [Validation(Required=false)]
        public bool? SignCheckVerification { get; set; }

        [NameInMap("SmsInformationSupervision")]
        [Validation(Required=false)]
        public bool? SmsInformationSupervision { get; set; }

    }

}
