// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListUsersForResourceServerResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page for paged queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>A list of user accounts.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListUsersForResourceServerResponseBodyUsers> Users { get; set; }
        public class ListUsersForResourceServerResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_qsw77zl5vrllwzyrrfwbmpxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>A list of granted scope permissions.</para>
            /// </summary>
            [NameInMap("ResourceServerScopes")]
            [Validation(Required=false)]
            public List<ListUsersForResourceServerResponseBodyUsersResourceServerScopes> ResourceServerScopes { get; set; }
            public class ListUsersForResourceServerResponseBodyUsersResourceServerScopes : TeaModel {
                /// <summary>
                /// <para>The ID of the scope permission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ress_nbte4bb3qqqnaq73rlmkqixxxx</para>
                /// </summary>
                [NameInMap("ResourceServerScopeId")]
                [Validation(Required=false)]
                public string ResourceServerScopeId { get; set; }

                /// <summary>
                /// <para>The name of the scope permission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Read All User</para>
                /// </summary>
                [NameInMap("ResourceServerScopeName")]
                [Validation(Required=false)]
                public string ResourceServerScopeName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the user account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_nbsomva32b6utec3hgi7scxxxx</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
