// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListOutboundPhoneNumberOfUserResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("NumberList")]
        [Validation(Required=false)]
        public ListOutboundPhoneNumberOfUserResponseBodyNumberList NumberList { get; set; }
        public class ListOutboundPhoneNumberOfUserResponseBodyNumberList : TeaModel {
            [NameInMap("Number")]
            [Validation(Required=false)]
            public List<string> Number { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("OutboundPhoneNumbers")]
        [Validation(Required=false)]
        public ListOutboundPhoneNumberOfUserResponseBodyOutboundPhoneNumbers OutboundPhoneNumbers { get; set; }
        public class ListOutboundPhoneNumberOfUserResponseBodyOutboundPhoneNumbers : TeaModel {
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public List<ListOutboundPhoneNumberOfUserResponseBodyOutboundPhoneNumbersPhoneNumber> PhoneNumber { get; set; }
            public class ListOutboundPhoneNumberOfUserResponseBodyOutboundPhoneNumbersPhoneNumber : TeaModel {
                public bool? PrivateFlag { get; set; }
                public bool? TestOnly { get; set; }
                public int? RemainingTime { get; set; }
                public string SipTelX { get; set; }
                public string City { get; set; }
                public string InstanceId { get; set; }
                public string Usage { get; set; }
                public bool? AllowOutbound { get; set; }
                public string PhoneNumberId { get; set; }
                public int? Trunks { get; set; }
                public string Number { get; set; }
                public string PhoneNumberDescription { get; set; }
                public ListOutboundPhoneNumberOfUserResponseBodyOutboundPhoneNumbersPhoneNumberPrivacyNumber PrivacyNumber { get; set; }
                public class ListOutboundPhoneNumberOfUserResponseBodyOutboundPhoneNumbersPhoneNumberPrivacyNumber : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("PoolId")]
                    [Validation(Required=false)]
                    public string PoolId { get; set; }

                    [NameInMap("SubId")]
                    [Validation(Required=false)]
                    public string SubId { get; set; }

                    [NameInMap("PhoneNumber")]
                    [Validation(Required=false)]
                    public string PhoneNumber { get; set; }

                    [NameInMap("PoolName")]
                    [Validation(Required=false)]
                    public string PoolName { get; set; }

                    [NameInMap("BizId")]
                    [Validation(Required=false)]
                    public string BizId { get; set; }

                    [NameInMap("RegionNameCity")]
                    [Validation(Required=false)]
                    public string RegionNameCity { get; set; }

                    [NameInMap("Extra")]
                    [Validation(Required=false)]
                    public string Extra { get; set; }

                    [NameInMap("TelX")]
                    [Validation(Required=false)]
                    public string TelX { get; set; }

                }
                public string Province { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
