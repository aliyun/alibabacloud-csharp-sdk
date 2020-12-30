// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rdc20180821.Models
{
    public class GetBindedUserByDingIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBindedUserByDingIdResponseBodyData Data { get; set; }
        public class GetBindedUserByDingIdResponseBodyData : TeaModel {
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }
            [NameInMap("Guid")]
            [Validation(Required=false)]
            public string Guid { get; set; }
            [NameInMap("DingtalkUser")]
            [Validation(Required=false)]
            public GetBindedUserByDingIdResponseBodyDataDingtalkUser DingtalkUser { get; set; }
            public class GetBindedUserByDingIdResponseBodyDataDingtalkUser : TeaModel {
                [NameInMap("DingtalkUserId")]
                [Validation(Required=false)]
                public int? DingtalkUserId { get; set; }

                [NameInMap("DingId")]
                [Validation(Required=false)]
                public string DingId { get; set; }

                [NameInMap("UnionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

                [NameInMap("Nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                [NameInMap("CodeUserName")]
                [Validation(Required=false)]
                public string CodeUserName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

            }
            [NameInMap("UserProfileDTO")]
            [Validation(Required=false)]
            public GetBindedUserByDingIdResponseBodyDataUserProfileDTO UserProfileDTO { get; set; }
            public class GetBindedUserByDingIdResponseBodyDataUserProfileDTO : TeaModel {
                [NameInMap("DataSource")]
                [Validation(Required=false)]
                public string DataSource { get; set; }

                [NameInMap("Avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public int? UserId { get; set; }

                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public long? CreatedAt { get; set; }

                [NameInMap("EnglishName")]
                [Validation(Required=false)]
                public string EnglishName { get; set; }

                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }
            [NameInMap("MainAccountType")]
            [Validation(Required=false)]
            public string MainAccountType { get; set; }
            [NameInMap("AliyunUser")]
            [Validation(Required=false)]
            public GetBindedUserByDingIdResponseBodyDataAliyunUser AliyunUser { get; set; }
            public class GetBindedUserByDingIdResponseBodyDataAliyunUser : TeaModel {
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("HavanaId")]
                [Validation(Required=false)]
                public string HavanaId { get; set; }

                [NameInMap("TaobaoNick")]
                [Validation(Required=false)]
                public string TaobaoNick { get; set; }

                [NameInMap("Kp")]
                [Validation(Required=false)]
                public string Kp { get; set; }

                [NameInMap("Realname")]
                [Validation(Required=false)]
                public string Realname { get; set; }

                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("AccountStructure")]
                [Validation(Required=false)]
                public int? AccountStructure { get; set; }

                [NameInMap("AliyunId")]
                [Validation(Required=false)]
                public string AliyunId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

            }
            [NameInMap("IsValid")]
            [Validation(Required=false)]
            public bool? IsValid { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
