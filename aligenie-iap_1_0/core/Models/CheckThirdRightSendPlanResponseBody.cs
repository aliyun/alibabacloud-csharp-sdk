// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class CheckThirdRightSendPlanResponseBody : TeaModel {
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public int? RetCode { get; set; }

        [NameInMap("RetMsg")]
        [Validation(Required=false)]
        public string RetMsg { get; set; }

        [NameInMap("RetValue")]
        [Validation(Required=false)]
        public CheckThirdRightSendPlanResponseBodyRetValue RetValue { get; set; }
        public class CheckThirdRightSendPlanResponseBodyRetValue : TeaModel {
            [NameInMap("ActivateDate")]
            [Validation(Required=false)]
            public string ActivateDate { get; set; }

            [NameInMap("CardType")]
            [Validation(Required=false)]
            public int? CardType { get; set; }

            [NameInMap("ChannelCode")]
            [Validation(Required=false)]
            public string ChannelCode { get; set; }

            [NameInMap("ChannelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("RightsExpiredDate")]
            [Validation(Required=false)]
            public string RightsExpiredDate { get; set; }

        }

    }

}
