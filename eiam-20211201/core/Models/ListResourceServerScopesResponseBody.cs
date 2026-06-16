// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListResourceServerScopesResponseBody : TeaModel {
        /// <summary>
        /// <para>Number of rows per page in paginated queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Token for the next page query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Token for the previous page query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PTxxxexample</para>
        /// </summary>
        [NameInMap("PreviousToken")]
        [Validation(Required=false)]
        public string PreviousToken { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of Scope permissions under the ResourceServer.</para>
        /// </summary>
        [NameInMap("ResourceServerScopes")]
        [Validation(Required=false)]
        public List<ListResourceServerScopesResponseBodyResourceServerScopes> ResourceServerScopes { get; set; }
        public class ListResourceServerScopesResponseBodyResourceServerScopes : TeaModel {
            /// <summary>
            /// <para>Application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_xxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>Authorization type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>authorize_required</para>
            /// </summary>
            [NameInMap("AuthorizationType")]
            [Validation(Required=false)]
            public string AuthorizationType { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_xxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Scope permission ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rss_xxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("ResourceServerScopeId")]
            [Validation(Required=false)]
            public string ResourceServerScopeId { get; set; }

            /// <summary>
            /// <para>Scope permission name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>读取全部用户</para>
            /// </summary>
            [NameInMap("ResourceServerScopeName")]
            [Validation(Required=false)]
            public string ResourceServerScopeName { get; set; }

            /// <summary>
            /// <para>Scope permission type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:idaas:resourceserver:scope:delegated</para>
            /// </summary>
            [NameInMap("ResourceServerScopeType")]
            [Validation(Required=false)]
            public string ResourceServerScopeType { get; set; }

            /// <summary>
            /// <para>Scope permission value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User:Write:ALL</para>
            /// </summary>
            [NameInMap("ResourceServerScopeValue")]
            [Validation(Required=false)]
            public string ResourceServerScopeValue { get; set; }

        }

        /// <summary>
        /// <para>Total number of items in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
