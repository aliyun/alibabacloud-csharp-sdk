// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeAtiRegistrantResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial. This field is returned only when RAM authentication fails.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeAtiRegistrantResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeAtiRegistrantResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The unauthorized operation that was attempted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RemoveRspDomainServerHoldStatusForGatewayOte</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The display name of the authorization principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015555733387XXXX</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The owner ID of the authorization principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10469733312XXX</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The identity type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SubUser</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The encrypted diagnostic message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQEAAAAAaNIARXXXXUQwNjE0LUQzN0XXXXVEQy1BQzExLTMzXXXXNTkxRjk1Ng==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The reason for the authentication failure. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ExplicitDeny: explicit deny.</description></item>
            /// <item><description>ImplicitDeny: implicit deny.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>The policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DlpSend</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The country.</para>
        /// 
        /// <b>Example:</b>
        /// <para>中国</para>
        /// </summary>
        [NameInMap("Cc")]
        [Validation(Required=false)]
        public string Cc { get; set; }

        /// <summary>
        /// <para>The city. Default value: Hangzhou.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州市</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>The creation time (timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1533773400000</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public string CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The document number of the registrant. The number can be up to 50 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110123456789122341</para>
        /// </summary>
        [NameInMap("DocumentCode")]
        [Validation(Required=false)]
        public string DocumentCode { get; set; }

        /// <summary>
        /// <para>The document type of the registrant. For more information, see the appendix on document types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SFZ</para>
        /// </summary>
        [NameInMap("DocumentType")]
        [Validation(Required=false)]
        public string DocumentType { get; set; }

        /// <summary>
        /// <para>The email address. The address can be up to 300 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:example@example.com">example@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The name of the registrant. The name can be up to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张xx</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The phone number of the registrant. The number can be up to 128 characters in length. If the country is China and the number is not a mobile phone number, the area code must match the city.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13112345678</para>
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <para>The ID of the real-name verified registrant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2072277378616354816</para>
        /// </summary>
        [NameInMap("RegistrantId")]
        [Validation(Required=false)]
        public string RegistrantId { get; set; }

        /// <summary>
        /// <para>The reason why the real-name verification was rejected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>以实际返回为准</para>
        /// </summary>
        [NameInMap("RejectReason")]
        [Validation(Required=false)]
        public string RejectReason { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B57C121B-A45F-44D8-A9B2-13E5A5044195</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the public recursive service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>浙江省</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The real-name verification status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Approved.</description></item>
        /// <item><description>Under review.</description></item>
        /// <item><description>Rejected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Approved</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The street address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx区xx街道</para>
        /// </summary>
        [NameInMap("Street")]
        [Validation(Required=false)]
        public string Street { get; set; }

        /// <summary>
        /// <para>The update time (timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public string UpdateTimestamp { get; set; }

    }

}
