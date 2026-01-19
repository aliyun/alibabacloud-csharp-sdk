// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetResourceServerScopeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceServerScope")]
        [Validation(Required=false)]
        public GetResourceServerScopeResponseBodyResourceServerScope ResourceServerScope { get; set; }
        public class GetResourceServerScopeResponseBodyResourceServerScope : TeaModel {
            /// <summary>
            /// <para>IDaaS EIAM 应用Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_xxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>authorize_required</para>
            /// </summary>
            [NameInMap("AuthorizationType")]
            [Validation(Required=false)]
            public string AuthorizationType { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 实例Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_xxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM ResourceServer下权限Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>rss_xxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("ResourceServerScopeId")]
            [Validation(Required=false)]
            public string ResourceServerScopeId { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM ResourceServer下权限名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>读取全部用户</para>
            /// </summary>
            [NameInMap("ResourceServerScopeName")]
            [Validation(Required=false)]
            public string ResourceServerScopeName { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM ResourceServer下权限类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>urn:alibaba:idaas:resourceserver:scope:delegated</para>
            /// </summary>
            [NameInMap("ResourceServerScopeType")]
            [Validation(Required=false)]
            public string ResourceServerScopeType { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM ResourceServer下权限值</para>
            /// 
            /// <b>Example:</b>
            /// <para>User:Read:ALL</para>
            /// </summary>
            [NameInMap("ResourceServerScopeValue")]
            [Validation(Required=false)]
            public string ResourceServerScopeValue { get; set; }

        }

    }

}
