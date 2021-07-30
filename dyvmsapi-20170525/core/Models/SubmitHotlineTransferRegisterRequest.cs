// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class SubmitHotlineTransferRegisterRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("QualificationId")]
        [Validation(Required=false)]
        public string QualificationId { get; set; }

        [NameInMap("OperatorName")]
        [Validation(Required=false)]
        public string OperatorName { get; set; }

        [NameInMap("OperatorMail")]
        [Validation(Required=false)]
        public string OperatorMail { get; set; }

        [NameInMap("OperatorMailVerifyCode")]
        [Validation(Required=false)]
        public string OperatorMailVerifyCode { get; set; }

        [NameInMap("OperatorMobile")]
        [Validation(Required=false)]
        public string OperatorMobile { get; set; }

        [NameInMap("OperatorMobileVerifyCode")]
        [Validation(Required=false)]
        public string OperatorMobileVerifyCode { get; set; }

        [NameInMap("OperatorIdentityCard")]
        [Validation(Required=false)]
        public string OperatorIdentityCard { get; set; }

        [NameInMap("Agreement")]
        [Validation(Required=false)]
        public string Agreement { get; set; }

        [NameInMap("HotlineNumber")]
        [Validation(Required=false)]
        public string HotlineNumber { get; set; }

        [NameInMap("TransferPhoneNumberInfos")]
        [Validation(Required=false)]
        public List<SubmitHotlineTransferRegisterRequestTransferPhoneNumberInfos> TransferPhoneNumberInfos { get; set; }
        public class SubmitHotlineTransferRegisterRequestTransferPhoneNumberInfos : TeaModel {
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            [NameInMap("PhoneNumberOwnerName")]
            [Validation(Required=false)]
            public string PhoneNumberOwnerName { get; set; }

            [NameInMap("IdentityCard")]
            [Validation(Required=false)]
            public string IdentityCard { get; set; }

        }

    }

}
