// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UsersDetailsVO : TeaModel {
        [NameInMap("ApprovalSignatureBase64")]
        [Validation(Required=false)]
        public string ApprovalSignatureBase64 { get; set; }

        [NameInMap("ApprovalSqlTemplate")]
        [Validation(Required=false)]
        public string ApprovalSqlTemplate { get; set; }

        [NameInMap("ApprovalStatus")]
        [Validation(Required=false)]
        public string ApprovalStatus { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public int? Creator { get; set; }

        [NameInMap("DataReady")]
        [Validation(Required=false)]
        public int? DataReady { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Mekid")]
        [Validation(Required=false)]
        public long? Mekid { get; set; }

        [NameInMap("PathPrefix")]
        [Validation(Required=false)]
        public string PathPrefix { get; set; }

        [NameInMap("ResultParty")]
        [Validation(Required=false)]
        public int? ResultParty { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

        [NameInMap("UserConfirmed")]
        [Validation(Required=false)]
        public int? UserConfirmed { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("UserPublicKeyPem")]
        [Validation(Required=false)]
        public string UserPublicKeyPem { get; set; }

    }

}
