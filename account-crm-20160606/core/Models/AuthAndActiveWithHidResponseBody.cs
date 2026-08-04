// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class AuthAndActiveWithHidResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public AuthAndActiveWithHidResponseBodyData Data { get; set; }
        public class AuthAndActiveWithHidResponseBodyData : TeaModel {
            [NameInMap("AccountModel")]
            [Validation(Required=false)]
            public AuthAndActiveWithHidResponseBodyDataAccountModel AccountModel { get; set; }
            public class AuthAndActiveWithHidResponseBodyDataAccountModel : TeaModel {
                [NameInMap("AliyunId")]
                [Validation(Required=false)]
                public string AliyunId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("HavanaId")]
                [Validation(Required=false)]
                public long? HavanaId { get; set; }

                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                [NameInMap("PK")]
                [Validation(Required=false)]
                public string PK { get; set; }

            }

            [NameInMap("SessionModel")]
            [Validation(Required=false)]
            public AuthAndActiveWithHidResponseBodyDataSessionModel SessionModel { get; set; }
            public class AuthAndActiveWithHidResponseBodyDataSessionModel : TeaModel {
                [NameInMap("AliyunPK")]
                [Validation(Required=false)]
                public string AliyunPK { get; set; }

                [NameInMap("LoginTicket")]
                [Validation(Required=false)]
                public string LoginTicket { get; set; }

            }

        }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
