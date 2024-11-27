// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListAbacAuthorizationsResponseBody : TeaModel {
        [NameInMap("AuthorizationList")]
        [Validation(Required=false)]
        public List<ListAbacAuthorizationsResponseBodyAuthorizationList> AuthorizationList { get; set; }
        public class ListAbacAuthorizationsResponseBodyAuthorizationList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>32****</para>
            /// </summary>
            [NameInMap("AuthorizationId")]
            [Validation(Required=false)]
            public long? AuthorizationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>51****</para>
            /// </summary>
            [NameInMap("IdentityId")]
            [Validation(Required=false)]
            public long? IdentityId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_user</para>
            /// </summary>
            [NameInMap("IdentityName")]
            [Validation(Required=false)]
            public string IdentityName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("IdentityType")]
            [Validation(Required=false)]
            public string IdentityType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>policy_test</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>USER_DEFINE</para>
            /// </summary>
            [NameInMap("PolicySource")]
            [Validation(Required=false)]
            public string PolicySource { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7FAD400F-7A5C-4193-8F9A-39D86C4F0231</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
