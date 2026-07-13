// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListAtiRegistrantsResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public ListAtiRegistrantsResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class ListAtiRegistrantsResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>AddRspDomainServerHoldStatusForGatewayOte</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2015555733387XXXX</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10469733312XXX</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SubUser</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AQEAAAAAaNIARXXXXUQwNjE0LUQzN0XXXXVEQy1BQzExLTMzXXXXNTkxRjk1Ng==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DlpSend</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4698691</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Registrants")]
        [Validation(Required=false)]
        public ListAtiRegistrantsResponseBodyRegistrants Registrants { get; set; }
        public class ListAtiRegistrantsResponseBodyRegistrants : TeaModel {
            [NameInMap("Registrant")]
            [Validation(Required=false)]
            public List<ListAtiRegistrantsResponseBodyRegistrantsRegistrant> Registrant { get; set; }
            public class ListAtiRegistrantsResponseBodyRegistrantsRegistrant : TeaModel {
                [NameInMap("Cc")]
                [Validation(Required=false)]
                public string Cc { get; set; }

                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public string CreateTimestamp { get; set; }

                [NameInMap("DocumentCode")]
                [Validation(Required=false)]
                public string DocumentCode { get; set; }

                [NameInMap("DocumentType")]
                [Validation(Required=false)]
                public string DocumentType { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RegistrantId")]
                [Validation(Required=false)]
                public string RegistrantId { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public string UpdateTimestamp { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B57C121B-A45F-44D8-A9B2-XXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>224</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
