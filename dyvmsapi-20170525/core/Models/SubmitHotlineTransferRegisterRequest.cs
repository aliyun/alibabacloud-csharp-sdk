// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class SubmitHotlineTransferRegisterRequest : TeaModel {
        /// <summary>
        /// The authenticity of the commitment. Valid values:
        /// 
        /// *   **true**: The commitment is authentic.
        /// *   **false**: The commitment is not authentic.
        /// </summary>
        [NameInMap("Agreement")]
        [Validation(Required=false)]
        public string Agreement { get; set; }

        /// <summary>
        /// The China 400 number.
        /// </summary>
        [NameInMap("HotlineNumber")]
        [Validation(Required=false)]
        public string HotlineNumber { get; set; }

        /// <summary>
        /// The ID card number of the handler.
        /// </summary>
        [NameInMap("OperatorIdentityCard")]
        [Validation(Required=false)]
        public string OperatorIdentityCard { get; set; }

        /// <summary>
        /// The email address of the handler.
        /// </summary>
        [NameInMap("OperatorMail")]
        [Validation(Required=false)]
        public string OperatorMail { get; set; }

        /// <summary>
        /// The verification code that is received by the mailbox of the handler.
        /// </summary>
        [NameInMap("OperatorMailVerifyCode")]
        [Validation(Required=false)]
        public string OperatorMailVerifyCode { get; set; }

        /// <summary>
        /// The mobile phone number of the handler.
        /// </summary>
        [NameInMap("OperatorMobile")]
        [Validation(Required=false)]
        public string OperatorMobile { get; set; }

        /// <summary>
        /// The verification code that is received by the mobile phone of the handler.
        /// </summary>
        [NameInMap("OperatorMobileVerifyCode")]
        [Validation(Required=false)]
        public string OperatorMobileVerifyCode { get; set; }

        /// <summary>
        /// The name of the handler.
        /// </summary>
        [NameInMap("OperatorName")]
        [Validation(Required=false)]
        public string OperatorName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The qualification ID. You can call the [GetHotlineQualificationByOrder](~~393548~~) operation to obtain the qualification ID.
        /// </summary>
        [NameInMap("QualificationId")]
        [Validation(Required=false)]
        public string QualificationId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The registration information about the China 400 number.
        /// </summary>
        [NameInMap("TransferPhoneNumberInfos")]
        [Validation(Required=false)]
        public List<SubmitHotlineTransferRegisterRequestTransferPhoneNumberInfos> TransferPhoneNumberInfos { get; set; }
        public class SubmitHotlineTransferRegisterRequestTransferPhoneNumberInfos : TeaModel {
            /// <summary>
            /// The ID card number of the number owner.
            /// </summary>
            [NameInMap("IdentityCard")]
            [Validation(Required=false)]
            public string IdentityCard { get; set; }

            /// <summary>
            /// The China 400 number that you want to submit for registration.
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// The real name or company name of the number owner.
            /// </summary>
            [NameInMap("PhoneNumberOwnerName")]
            [Validation(Required=false)]
            public string PhoneNumberOwnerName { get; set; }

        }

    }

}
