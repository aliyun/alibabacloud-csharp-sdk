// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateWorkitemRecordResponseBody : TeaModel {
        [NameInMap("WorkitemTime")]
        [Validation(Required=false)]
        public CreateWorkitemRecordResponseBodyWorkitemTime WorkitemTime { get; set; }
        public class CreateWorkitemRecordResponseBodyWorkitemTime : TeaModel {
            [NameInMap("actualTime")]
            [Validation(Required=false)]
            public long? ActualTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("gmtEnd")]
            [Validation(Required=false)]
            public long? GmtEnd { get; set; }

            [NameInMap("gmtStart")]
            [Validation(Required=false)]
            public long? GmtStart { get; set; }

            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("recordUser")]
            [Validation(Required=false)]
            public CreateWorkitemRecordResponseBodyWorkitemTimeRecordUser RecordUser { get; set; }
            public class CreateWorkitemRecordResponseBodyWorkitemTimeRecordUser : TeaModel {
                [NameInMap("account")]
                [Validation(Required=false)]
                public string Account { get; set; }

                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                [NameInMap("dingTalkId")]
                [Validation(Required=false)]
                public string DingTalkId { get; set; }

                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("displayNickName")]
                [Validation(Required=false)]
                public string DisplayNickName { get; set; }

                [NameInMap("displayRealName")]
                [Validation(Required=false)]
                public string DisplayRealName { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("gender")]
                [Validation(Required=false)]
                public string Gender { get; set; }

                [NameInMap("identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                [NameInMap("isDisabled")]
                [Validation(Required=false)]
                public bool? IsDisabled { get; set; }

                [NameInMap("mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                [NameInMap("nameEn")]
                [Validation(Required=false)]
                public string NameEn { get; set; }

                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("nickNamePinyin")]
                [Validation(Required=false)]
                public string NickNamePinyin { get; set; }

                [NameInMap("realName")]
                [Validation(Required=false)]
                public string RealName { get; set; }

                [NameInMap("realNamePinyin")]
                [Validation(Required=false)]
                public string RealNamePinyin { get; set; }

                [NameInMap("stamp")]
                [Validation(Required=false)]
                public string Stamp { get; set; }

                [NameInMap("tbRoleId")]
                [Validation(Required=false)]
                public string TbRoleId { get; set; }

            }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("workitemIdentifier")]
            [Validation(Required=false)]
            public string WorkitemIdentifier { get; set; }

        }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
