// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class RegisterInternalAccountForBucResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RegisterInternalAccountForBucResponseBodyData Data { get; set; }
        public class RegisterInternalAccountForBucResponseBodyData : TeaModel {
            [NameInMap("AccountStatus")]
            [Validation(Required=false)]
            public string AccountStatus { get; set; }

            [NameInMap("AccountStructure")]
            [Validation(Required=false)]
            public string AccountStructure { get; set; }

            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public string ExtendInfo { get; set; }

            [NameInMap("HavanaId")]
            [Validation(Required=false)]
            public string HavanaId { get; set; }

            [NameInMap("LastLoginTime")]
            [Validation(Required=false)]
            public string LastLoginTime { get; set; }

            [NameInMap("OwnerBid")]
            [Validation(Required=false)]
            public string OwnerBid { get; set; }

            [NameInMap("ParentPk")]
            [Validation(Required=false)]
            public string ParentPk { get; set; }

            [NameInMap("PartnerPk")]
            [Validation(Required=false)]
            public string PartnerPk { get; set; }

            [NameInMap("Pk")]
            [Validation(Required=false)]
            public string Pk { get; set; }

            [NameInMap("Site")]
            [Validation(Required=false)]
            public string Site { get; set; }

        }

        [NameInMap("LocalizedMessage")]
        [Validation(Required=false)]
        public string LocalizedMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
