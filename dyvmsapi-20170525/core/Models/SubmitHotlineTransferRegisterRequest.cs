// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class SubmitHotlineTransferRegisterRequest : TeaModel {
        /// <summary>
        /// <para>The authenticity of the commitment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The commitment is authentic.</description></item>
        /// <item><description><b>false</b>: The commitment is not authentic.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Agreement")]
        [Validation(Required=false)]
        public string Agreement { get; set; }

        /// <summary>
        /// <para>The China 400 number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400****</para>
        /// </summary>
        [NameInMap("HotlineNumber")]
        [Validation(Required=false)]
        public string HotlineNumber { get; set; }

        /// <summary>
        /// <para>The ID card number of the handler.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5****************9</para>
        /// </summary>
        [NameInMap("OperatorIdentityCard")]
        [Validation(Required=false)]
        public string OperatorIdentityCard { get; set; }

        /// <summary>
        /// <para>The email address of the handler.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("OperatorMail")]
        [Validation(Required=false)]
        public string OperatorMail { get; set; }

        /// <summary>
        /// <para>The verification code that is received by the mailbox of the handler.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("OperatorMailVerifyCode")]
        [Validation(Required=false)]
        public string OperatorMailVerifyCode { get; set; }

        /// <summary>
        /// <para>The mobile phone number of the handler.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>158****7230</para>
        /// </summary>
        [NameInMap("OperatorMobile")]
        [Validation(Required=false)]
        public string OperatorMobile { get; set; }

        /// <summary>
        /// <para>The verification code that is received by the mobile phone of the handler.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("OperatorMobileVerifyCode")]
        [Validation(Required=false)]
        public string OperatorMobileVerifyCode { get; set; }

        /// <summary>
        /// <para>The name of the handler.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A***</para>
        /// </summary>
        [NameInMap("OperatorName")]
        [Validation(Required=false)]
        public string OperatorName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The qualification ID. You can call the <a href="https://help.aliyun.com/document_detail/393548.html">GetHotlineQualificationByOrder</a> operation to obtain the qualification ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000004933****</para>
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
        /// <para>The registration information about the China 400 number.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TransferPhoneNumberInfos")]
        [Validation(Required=false)]
        public List<SubmitHotlineTransferRegisterRequestTransferPhoneNumberInfos> TransferPhoneNumberInfos { get; set; }
        public class SubmitHotlineTransferRegisterRequestTransferPhoneNumberInfos : TeaModel {
            /// <summary>
            /// <para>The ID card number of the number owner.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500***</para>
            /// </summary>
            [NameInMap("IdentityCard")]
            [Validation(Required=false)]
            public string IdentityCard { get; set; }

            /// <summary>
            /// <para>The China 400 number that you want to submit for registration.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1580000****</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <para>The real name or company name of the number owner.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A***</para>
            /// </summary>
            [NameInMap("PhoneNumberOwnerName")]
            [Validation(Required=false)]
            public string PhoneNumberOwnerName { get; set; }

        }

    }

}
