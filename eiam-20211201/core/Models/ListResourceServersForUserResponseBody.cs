// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListResourceServersForUserResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>本次调用返回的查询凭证（Token）值，用于下一次翻页查询。</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceServers")]
        [Validation(Required=false)]
        public List<ListResourceServersForUserResponseBodyResourceServers> ResourceServers { get; set; }
        public class ListResourceServersForUserResponseBodyResourceServers : TeaModel {
            /// <summary>
            /// <para>资源服务应用的唯一标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_nbsomva32b6utec3hgi7scxxxx</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>实例唯一标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_qsw77zl5vrllwzyrrfwbmpxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>urn:idaas:test</para>
            /// </summary>
            [NameInMap("ResourceServerIdentifier")]
            [Validation(Required=false)]
            public string ResourceServerIdentifier { get; set; }

            /// <summary>
            /// <para>资源服务Scope权限集合</para>
            /// </summary>
            [NameInMap("ResourceServerScopes")]
            [Validation(Required=false)]
            public List<ListResourceServersForUserResponseBodyResourceServersResourceServerScopes> ResourceServerScopes { get; set; }
            public class ListResourceServersForUserResponseBodyResourceServersResourceServerScopes : TeaModel {
                /// <summary>
                /// <para>直接分配给当前用户的权限，视为直接授权。</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasDirectAuthorization")]
                [Validation(Required=false)]
                public bool? HasDirectAuthorization { get; set; }

                /// <summary>
                /// <para>通过用户隶属的组织、组获取的权限，视为继承权限。</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HasInheritAuthorization")]
                [Validation(Required=false)]
                public bool? HasInheritAuthorization { get; set; }

                /// <summary>
                /// <para>ResourceServerScope唯一标识</para>
                /// 
                /// <b>Example:</b>
                /// <para>ress_nbte4bb3qqqnaq73rlmkqixxxx</para>
                /// </summary>
                [NameInMap("ResourceServerScopeId")]
                [Validation(Required=false)]
                public string ResourceServerScopeId { get; set; }

                /// <summary>
                /// <para>ResourceServerScope名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>Read All User</para>
                /// </summary>
                [NameInMap("ResourceServerScopeName")]
                [Validation(Required=false)]
                public string ResourceServerScopeName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
