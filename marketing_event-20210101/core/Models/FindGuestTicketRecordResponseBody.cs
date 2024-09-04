// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Marketing_event20210101.Models
{
    public class FindGuestTicketRecordResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<FindGuestTicketRecordResponseBodyData> Data { get; set; }
        public class FindGuestTicketRecordResponseBodyData : TeaModel {
            [NameInMap("ChannelLevelInfo")]
            [Validation(Required=false)]
            public FindGuestTicketRecordResponseBodyDataChannelLevelInfo ChannelLevelInfo { get; set; }
            public class FindGuestTicketRecordResponseBodyDataChannelLevelInfo : TeaModel {
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public long? ChannelId { get; set; }

                [NameInMap("ChannelName")]
                [Validation(Required=false)]
                public string ChannelName { get; set; }

                [NameInMap("LevelOneChannelName")]
                [Validation(Required=false)]
                public string LevelOneChannelName { get; set; }

                [NameInMap("LevelOneOwner")]
                [Validation(Required=false)]
                public List<FindGuestTicketRecordResponseBodyDataChannelLevelInfoLevelOneOwner> LevelOneOwner { get; set; }
                public class FindGuestTicketRecordResponseBodyDataChannelLevelInfoLevelOneOwner : TeaModel {
                    [NameInMap("OwnerEmpIdOrTelephone")]
                    [Validation(Required=false)]
                    public string OwnerEmpIdOrTelephone { get; set; }

                    [NameInMap("OwnerName")]
                    [Validation(Required=false)]
                    public string OwnerName { get; set; }

                    [NameInMap("OwnerNickName")]
                    [Validation(Required=false)]
                    public string OwnerNickName { get; set; }

                }

                [NameInMap("LevelThreeChannelName")]
                [Validation(Required=false)]
                public string LevelThreeChannelName { get; set; }

                [NameInMap("LevelThreeOwner")]
                [Validation(Required=false)]
                public List<FindGuestTicketRecordResponseBodyDataChannelLevelInfoLevelThreeOwner> LevelThreeOwner { get; set; }
                public class FindGuestTicketRecordResponseBodyDataChannelLevelInfoLevelThreeOwner : TeaModel {
                    [NameInMap("OwnerEmpIdOrTelephone")]
                    [Validation(Required=false)]
                    public string OwnerEmpIdOrTelephone { get; set; }

                    [NameInMap("OwnerName")]
                    [Validation(Required=false)]
                    public string OwnerName { get; set; }

                    [NameInMap("OwnerNickName")]
                    [Validation(Required=false)]
                    public string OwnerNickName { get; set; }

                }

                [NameInMap("LevelTwoChannelName")]
                [Validation(Required=false)]
                public string LevelTwoChannelName { get; set; }

                [NameInMap("LevelTwoOwner")]
                [Validation(Required=false)]
                public List<FindGuestTicketRecordResponseBodyDataChannelLevelInfoLevelTwoOwner> LevelTwoOwner { get; set; }
                public class FindGuestTicketRecordResponseBodyDataChannelLevelInfoLevelTwoOwner : TeaModel {
                    [NameInMap("OwnerEmpIdOrTelephone")]
                    [Validation(Required=false)]
                    public string OwnerEmpIdOrTelephone { get; set; }

                    [NameInMap("OwnerName")]
                    [Validation(Required=false)]
                    public string OwnerName { get; set; }

                    [NameInMap("OwnerNickName")]
                    [Validation(Required=false)]
                    public string OwnerNickName { get; set; }

                }

            }

            [NameInMap("CompanyName")]
            [Validation(Required=false)]
            public string CompanyName { get; set; }

            [NameInMap("EquityDates")]
            [Validation(Required=false)]
            public string EquityDates { get; set; }

            [NameInMap("HealthCommitmentStatus")]
            [Validation(Required=false)]
            public int? HealthCommitmentStatus { get; set; }

            [NameInMap("IdNumber")]
            [Validation(Required=false)]
            public string IdNumber { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TicketCode")]
            [Validation(Required=false)]
            public string TicketCode { get; set; }

            [NameInMap("TicketName")]
            [Validation(Required=false)]
            public string TicketName { get; set; }

            [NameInMap("TicketType")]
            [Validation(Required=false)]
            public string TicketType { get; set; }

        }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
