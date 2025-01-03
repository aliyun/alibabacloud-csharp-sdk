// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListOrganizationsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SYSTEM_UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>95FE5953-FF5B-5F80-94AD-FFF97D990FE0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListOrganizationsResponseBodyResult> Result { get; set; }
        public class ListOrganizationsResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("accessLevel")]
            [Validation(Required=false)]
            public int? AccessLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5240</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("namespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            [NameInMap("organizationAlias")]
            [Validation(Required=false)]
            public string OrganizationAlias { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>60de7a6852743a5162b5f957</para>
            /// </summary>
            [NameInMap("organizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            [NameInMap("organizationName")]
            [Validation(Required=false)]
            public string OrganizationName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ORG_ADMIN</para>
            /// </summary>
            [NameInMap("organizationRole")]
            [Validation(Required=false)]
            public string OrganizationRole { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
