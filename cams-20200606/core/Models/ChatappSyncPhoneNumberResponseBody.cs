// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ChatappSyncPhoneNumberResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// <list type="bullet">
        /// <item><description>A value of OK indicates that the call is successful.</description></item>
        /// <item><description>Other values indicate that the call fails. For more information, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The phone numbers.</para>
        /// </summary>
        [NameInMap("PhoneNumbers")]
        [Validation(Required=false)]
        public List<ChatappSyncPhoneNumberResponseBodyPhoneNumbers> PhoneNumbers { get; set; }
        public class ChatappSyncPhoneNumberResponseBodyPhoneNumbers : TeaModel {
            /// <summary>
            /// <para>The verification state of the phone number.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>REVOKED: The review application is revoked.</description></item>
            /// <item><description>MORE_INFORMATION_REQUESTED: More information needs to be provided.</description></item>
            /// <item><description>VERIFIED: The phone number passes the verification.</description></item>
            /// <item><description>REJECTED: The phone number fails to pass the verification.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VERIFIED</para>
            /// </summary>
            [NameInMap("CodeVerificationStatus")]
            [Validation(Required=false)]
            public string CodeVerificationStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether it is a WhatsApp Official Business Account (OBA).</para>
            /// 
            /// <b>Example:</b>
            /// <para>N</para>
            /// </summary>
            [NameInMap("IsOfficial")]
            [Validation(Required=false)]
            public string IsOfficial { get; set; }

            /// <summary>
            /// <para>The number of phone numbers to which messages can be sent in a day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TIER_10</para>
            /// </summary>
            [NameInMap("MessagingLimitTier")]
            [Validation(Required=false)]
            public string MessagingLimitTier { get; set; }

            /// <summary>
            /// <para>The review status of the business display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Approval</para>
            /// </summary>
            [NameInMap("NameStatus")]
            [Validation(Required=false)]
            public string NameStatus { get; set; }

            /// <summary>
            /// <para>The review status of the new business display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Approval</para>
            /// </summary>
            [NameInMap("NewNameStatus")]
            [Validation(Required=false)]
            public string NewNameStatus { get; set; }

            /// <summary>
            /// <para>The phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8613800001234</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <para>The quality rating of the phone number.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RED</description></item>
            /// <item><description>YELLOW</description></item>
            /// <item><description>GREEN</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GREEN</para>
            /// </summary>
            [NameInMap("QualityRating")]
            [Validation(Required=false)]
            public string QualityRating { get; set; }

            /// <summary>
            /// <para>The state of the phone number.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MIGRATED</description></item>
            /// <item><description>FLAGGED</description></item>
            /// <item><description>DISCONNECTED</description></item>
            /// <item><description>UNVERIFIED</description></item>
            /// <item><description>BANNED</description></item>
            /// <item><description>RATE_LIMITED</description></item>
            /// <item><description>PENDING</description></item>
            /// <item><description>CONNECTED</description></item>
            /// <item><description>UNKNOWN</description></item>
            /// <item><description>DELETED</description></item>
            /// <item><description>RESTRICTED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The callback URL to which status reports are sent by using HTTP callbacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.alibaba.com/status">https://www.alibaba.com/status</a></para>
            /// </summary>
            [NameInMap("StatusCallbackUrl")]
            [Validation(Required=false)]
            public string StatusCallbackUrl { get; set; }

            /// <summary>
            /// <para>The status report queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alicom-09399200-queue</para>
            /// </summary>
            [NameInMap("StatusQueue")]
            [Validation(Required=false)]
            public string StatusQueue { get; set; }

            /// <summary>
            /// <para>The URL that receives the MO messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.alibaba.com/inbound">https://www.alibaba.com/inbound</a></para>
            /// </summary>
            [NameInMap("UpCallbackUrl")]
            [Validation(Required=false)]
            public string UpCallbackUrl { get; set; }

            /// <summary>
            /// <para>The mobile originated (MO) message queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alicom-09399200-queue</para>
            /// </summary>
            [NameInMap("UpQueue")]
            [Validation(Required=false)]
            public string UpQueue { get; set; }

            /// <summary>
            /// <para>The display name of the business to which the phone number belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba</para>
            /// </summary>
            [NameInMap("VerifiedName")]
            [Validation(Required=false)]
            public string VerifiedName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A94866411B2O</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
