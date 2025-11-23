// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListAbacAuthorizationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of users to which the specified policy is attached.</para>
        /// </summary>
        [NameInMap("AuthorizationList")]
        [Validation(Required=false)]
        public List<ListAbacAuthorizationsResponseBodyAuthorizationList> AuthorizationList { get; set; }
        public class ListAbacAuthorizationsResponseBodyAuthorizationList : TeaModel {
            /// <summary>
            /// <para>The authorization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32****</para>
            /// </summary>
            [NameInMap("AuthorizationId")]
            [Validation(Required=false)]
            public long? AuthorizationId { get; set; }

            /// <summary>
            /// <para>The ID of the object to which the policy is attached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51****</para>
            /// </summary>
            [NameInMap("IdentityId")]
            [Validation(Required=false)]
            public long? IdentityId { get; set; }

            /// <summary>
            /// <para>The name of the object to which the policy is attached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_user</para>
            /// </summary>
            [NameInMap("IdentityName")]
            [Validation(Required=false)]
            public string IdentityName { get; set; }

            /// <summary>
            /// <para>The type of the object to which the policy is attached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("IdentityType")]
            [Validation(Required=false)]
            public string IdentityType { get; set; }

            /// <summary>
            /// <para>The ID of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// <para>The name of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>policy_test</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The source of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER_DEFINE</para>
            /// </summary>
            [NameInMap("PolicySource")]
            [Validation(Required=false)]
            public string PolicySource { get; set; }

        }

        /// <summary>
        /// <para>The error code that is returned when the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message that is returned when the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7FAD400F-7A5C-4193-8F9A-39D86C4F0231</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The number of objects to which the policy is attached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
