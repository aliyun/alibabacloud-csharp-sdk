// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeChannelTopPubUserListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TopPubUserDetailList")]
        [Validation(Required=false)]
        public List<DescribeChannelTopPubUserListResponseBodyTopPubUserDetailList> TopPubUserDetailList { get; set; }
        public class DescribeChannelTopPubUserListResponseBodyTopPubUserDetailList : TeaModel {
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }

            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("OnlineDuration")]
            [Validation(Required=false)]
            public long? OnlineDuration { get; set; }

            [NameInMap("OnlinePeriods")]
            [Validation(Required=false)]
            public List<DescribeChannelTopPubUserListResponseBodyTopPubUserDetailListOnlinePeriods> OnlinePeriods { get; set; }
            public class DescribeChannelTopPubUserListResponseBodyTopPubUserDetailListOnlinePeriods : TeaModel {
                [NameInMap("JoinTs")]
                [Validation(Required=false)]
                public long? JoinTs { get; set; }

                [NameInMap("LeaveTs")]
                [Validation(Required=false)]
                public long? LeaveTs { get; set; }

            }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
