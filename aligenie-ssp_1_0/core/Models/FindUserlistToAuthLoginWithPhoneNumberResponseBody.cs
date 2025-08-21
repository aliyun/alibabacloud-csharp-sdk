// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class FindUserlistToAuthLoginWithPhoneNumberResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("DataObj")]
        [Validation(Required=false)]
        public FindUserlistToAuthLoginWithPhoneNumberResponseBodyDataObj DataObj { get; set; }
        public class FindUserlistToAuthLoginWithPhoneNumberResponseBodyDataObj : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>dbe2eb4458302b9246c6da17fbc95f4b</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>73C67BD9-175A-1324-8202-9FAABBB3E6FA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public FindUserlistToAuthLoginWithPhoneNumberResponseBodyResult Result { get; set; }
        public class FindUserlistToAuthLoginWithPhoneNumberResponseBodyResult : TeaModel {
            [NameInMap("UserListToAuthLogin")]
            [Validation(Required=false)]
            public List<FindUserlistToAuthLoginWithPhoneNumberResponseBodyResultUserListToAuthLogin> UserListToAuthLogin { get; set; }
            public class FindUserlistToAuthLoginWithPhoneNumberResponseBodyResultUserListToAuthLogin : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://xxx">https://xxx</a></para>
                /// </summary>
                [NameInMap("Avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>KsVgypxAipf+xNECMZV2ONMcheqiIoEGFvgx+T8s1oV6/euTK9+ImYvLVPsSqFDh</para>
                /// </summary>
                [NameInMap("EncryptedUserIdentifier")]
                [Validation(Required=false)]
                public string EncryptedUserIdentifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PHONE_NUMBER_BINDING_WITH_ALIGENIE：phoneNumber</para>
                /// </summary>
                [NameInMap("FindingType")]
                [Validation(Required=false)]
                public string FindingType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>XXX</para>
                /// </summary>
                [NameInMap("Nickname")]
                [Validation(Required=false)]
                public string Nickname { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ALIGENIE</para>
                /// </summary>
                [NameInMap("UserType")]
                [Validation(Required=false)]
                public string UserType { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
