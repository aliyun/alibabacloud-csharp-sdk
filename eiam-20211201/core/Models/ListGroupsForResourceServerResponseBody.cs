// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListGroupsForResourceServerResponseBody : TeaModel {
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<ListGroupsForResourceServerResponseBodyGroups> Groups { get; set; }
        public class ListGroupsForResourceServerResponseBodyGroups : TeaModel {
            /// <summary>
            /// <para>用户组的唯一标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>group_nbsomva32b6utec3hgi7scxxxx</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

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
            /// <para>资源服务Scope权限集合</para>
            /// </summary>
            [NameInMap("ResourceServerScopes")]
            [Validation(Required=false)]
            public List<ListGroupsForResourceServerResponseBodyGroupsResourceServerScopes> ResourceServerScopes { get; set; }
            public class ListGroupsForResourceServerResponseBodyGroupsResourceServerScopes : TeaModel {
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
                /// <para>获取资源信息</para>
                /// </summary>
                [NameInMap("ResourceServerScopeName")]
                [Validation(Required=false)]
                public string ResourceServerScopeName { get; set; }

            }

        }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
