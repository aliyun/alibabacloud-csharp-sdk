// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateOrganizationMemberResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
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

        [NameInMap("member")]
        [Validation(Required=false)]
        public UpdateOrganizationMemberResponseBodyMember Member { get; set; }
        public class UpdateOrganizationMemberResponseBodyMember : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>292035769476261xxx</para>
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("organizationMemberName")]
            [Validation(Required=false)]
            public string OrganizationMemberName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F7B85D1B-D1C2-140F-A039-341859F130B9</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
