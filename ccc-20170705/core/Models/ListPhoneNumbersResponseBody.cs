// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListPhoneNumbersResponseBody : TeaModel {
        [NameInMap("PhoneNumbers")]
        [Validation(Required=false)]
        public ListPhoneNumbersResponseBodyPhoneNumbers PhoneNumbers { get; set; }
        public class ListPhoneNumbersResponseBodyPhoneNumbers : TeaModel {
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public List<ListPhoneNumbersResponseBodyPhoneNumbersPhoneNumber> PhoneNumber { get; set; }
            public class ListPhoneNumbersResponseBodyPhoneNumbersPhoneNumber : TeaModel {
                public bool? TestOnly { get; set; }
                public int? RemainingTime { get; set; }
                public string SipTelX { get; set; }
                public string City { get; set; }
                public string InstanceId { get; set; }
                public string Usage { get; set; }
                public bool? AllowOutbound { get; set; }
                public string Assignee { get; set; }
                public string PhoneNumberId { get; set; }
                public ListPhoneNumbersResponseBodyPhoneNumbersPhoneNumberSkillGroups SkillGroups { get; set; }
                public class ListPhoneNumbersResponseBodyPhoneNumbersPhoneNumberSkillGroups : TeaModel {
                    [NameInMap("SkillGroup")]
                    [Validation(Required=false)]
                    public List<ListPhoneNumbersResponseBodyPhoneNumbersPhoneNumberSkillGroupsSkillGroup> SkillGroup { get; set; }
                    public class ListPhoneNumbersResponseBodyPhoneNumbersPhoneNumberSkillGroupsSkillGroup : TeaModel {
                        [NameInMap("SkillGroupName")]
                        [Validation(Required=false)]
                        public string SkillGroupName { get; set; }

                        [NameInMap("SkillGroupId")]
                        [Validation(Required=false)]
                        public string SkillGroupId { get; set; }

                    }

                }
                public int? Trunks { get; set; }
                public string Number { get; set; }
                public string PhoneNumberDescription { get; set; }
                public ListPhoneNumbersResponseBodyPhoneNumbersPhoneNumberContactFlow ContactFlow { get; set; }
                public class ListPhoneNumbersResponseBodyPhoneNumbersPhoneNumberContactFlow : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("ContactFlowDescription")]
                    [Validation(Required=false)]
                    public string ContactFlowDescription { get; set; }

                    [NameInMap("ContactFlowName")]
                    [Validation(Required=false)]
                    public string ContactFlowName { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("ContactFlowId")]
                    [Validation(Required=false)]
                    public string ContactFlowId { get; set; }

                }
                public int? NumberCommodityStatus { get; set; }
                public ListPhoneNumbersResponseBodyPhoneNumbersPhoneNumberPrivacyNumber PrivacyNumber { get; set; }
                public class ListPhoneNumbersResponseBodyPhoneNumbersPhoneNumberPrivacyNumber : TeaModel {
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

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
