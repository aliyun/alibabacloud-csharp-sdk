// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class FindUserlistToAuthLoginWithPhoneNumberResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>When the code is 5140003, it indicates that the invocation failed because no account list eligible for authorization login was found for the given phone number. The frontend can prompt the user to confirm generating a Jingle account via the phone number or suggest registering a Taobao account using the phone number first. In subsequent flows, the frontend must return the sessionId from DataObj to the server.</para>
        /// </summary>
        [NameInMap("DataObj")]
        [Validation(Required=false)]
        public FindUserlistToAuthLoginWithPhoneNumberResponseBodyDataObj DataObj { get; set; }
        public class FindUserlistToAuthLoginWithPhoneNumberResponseBodyDataObj : TeaModel {
            /// <summary>
            /// <para>Session ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbe2eb4458302b9246c6da17fbc95f4b</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <para>Response message</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>73C67BD9-175A-1324-8202-9FAABBB3E6FA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Response Result</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public FindUserlistToAuthLoginWithPhoneNumberResponseBodyResult Result { get; set; }
        public class FindUserlistToAuthLoginWithPhoneNumberResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>List of accounts eligible for authorization login</para>
            /// </summary>
            [NameInMap("UserListToAuthLogin")]
            [Validation(Required=false)]
            public List<FindUserlistToAuthLoginWithPhoneNumberResponseBodyResultUserListToAuthLogin> UserListToAuthLogin { get; set; }
            public class FindUserlistToAuthLoginWithPhoneNumberResponseBodyResultUserListToAuthLogin : TeaModel {
                /// <summary>
                /// <para>Profile picture</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxx">https://xxx</a></para>
                /// </summary>
                [NameInMap("Avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                /// <summary>
                /// <para>Encrypted User Identifier</para>
                /// 
                /// <b>Example:</b>
                /// <para>KsVgypxAipf+xNECMZV2ONMcheqiIoEGFvgx+T8s1oV6/euTK9+ImYvLVPsSqFDh</para>
                /// </summary>
                [NameInMap("EncryptedUserIdentifier")]
                [Validation(Required=false)]
                public string EncryptedUserIdentifier { get; set; }

                /// <summary>
                /// <para>User Search Type  </para>
                /// <para>For Taobao users, the value is fixed as:<br>PHONE_NUMBER_BINDING_WITH_TAOBAO: The phoneNumber is queried as the phone number bound to a Taobao account.  </para>
                /// <para>For Tmall Genie users, the value can be:<br>PHONE_NUMBER_BINDING_WITH_ALIGENIE: The phoneNumber is queried as the phone number bound to a Tmall Genie device;<br>PHONE_NUMBER_BINDING_WITH_TAOBAO: The phoneNumber is queried as the phone number bound to a Taobao account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PHONE_NUMBER_BINDING_WITH_ALIGENIE：phoneNumber</para>
                /// </summary>
                [NameInMap("FindingType")]
                [Validation(Required=false)]
                public string FindingType { get; set; }

                /// <summary>
                /// <para>Nickname</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX</para>
                /// </summary>
                [NameInMap("Nickname")]
                [Validation(Required=false)]
                public string Nickname { get; set; }

                /// <summary>
                /// <para>User Type<br>TAOBAO: Taobao user<br>ALIGENIE: Tmall Genie user</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALIGENIE</para>
                /// </summary>
                [NameInMap("UserType")]
                [Validation(Required=false)]
                public string UserType { get; set; }

            }

        }

        /// <summary>
        /// <para>Flag indicating whether the invocation succeeded</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
