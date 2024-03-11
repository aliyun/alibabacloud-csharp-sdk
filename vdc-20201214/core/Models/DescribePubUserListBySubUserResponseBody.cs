// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribePubUserListBySubUserResponseBody : TeaModel {
        [NameInMap("CallStatus")]
        [Validation(Required=false)]
        public string CallStatus { get; set; }

        [NameInMap("PubUserDetailList")]
        [Validation(Required=false)]
        public List<DescribePubUserListBySubUserResponseBodyPubUserDetailList> PubUserDetailList { get; set; }
        public class DescribePubUserListBySubUserResponseBodyPubUserDetailList : TeaModel {
            [NameInMap("CallIdList")]
            [Validation(Required=false)]
            public List<string> CallIdList { get; set; }

            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

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

            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            [NameInMap("NetworkList")]
            [Validation(Required=false)]
            public List<string> NetworkList { get; set; }

            [NameInMap("OnlineDuration")]
            [Validation(Required=false)]
            public long? OnlineDuration { get; set; }

            [NameInMap("OnlinePeriods")]
            [Validation(Required=false)]
            public List<DescribePubUserListBySubUserResponseBodyPubUserDetailListOnlinePeriods> OnlinePeriods { get; set; }
            public class DescribePubUserListBySubUserResponseBodyPubUserDetailListOnlinePeriods : TeaModel {
                [NameInMap("JoinTs")]
                [Validation(Required=false)]
                public long? JoinTs { get; set; }

                [NameInMap("LeaveTs")]
                [Validation(Required=false)]
                public long? LeaveTs { get; set; }

            }

            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            [NameInMap("OsList")]
            [Validation(Required=false)]
            public List<string> OsList { get; set; }

            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }

            [NameInMap("SdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }

            [NameInMap("SdkVersionList")]
            [Validation(Required=false)]
            public List<string> SdkVersionList { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserIdAlias")]
            [Validation(Required=false)]
            public string UserIdAlias { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubUserDetail")]
        [Validation(Required=false)]
        public DescribePubUserListBySubUserResponseBodySubUserDetail SubUserDetail { get; set; }
        public class DescribePubUserListBySubUserResponseBodySubUserDetail : TeaModel {
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

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

            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            [NameInMap("NetworkList")]
            [Validation(Required=false)]
            public List<string> NetworkList { get; set; }

            [NameInMap("OnlineDuration")]
            [Validation(Required=false)]
            public long? OnlineDuration { get; set; }

            [NameInMap("OnlinePeriods")]
            [Validation(Required=false)]
            public List<DescribePubUserListBySubUserResponseBodySubUserDetailOnlinePeriods> OnlinePeriods { get; set; }
            public class DescribePubUserListBySubUserResponseBodySubUserDetailOnlinePeriods : TeaModel {
                [NameInMap("JoinTs")]
                [Validation(Required=false)]
                public long? JoinTs { get; set; }

                [NameInMap("LeaveTs")]
                [Validation(Required=false)]
                public long? LeaveTs { get; set; }

            }

            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            [NameInMap("OsList")]
            [Validation(Required=false)]
            public List<string> OsList { get; set; }

            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }

            [NameInMap("SdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }

            [NameInMap("SdkVersionList")]
            [Validation(Required=false)]
            public List<string> SdkVersionList { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserIdAlias")]
            [Validation(Required=false)]
            public string UserIdAlias { get; set; }

        }

    }

}
