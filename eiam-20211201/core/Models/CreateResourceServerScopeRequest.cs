// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateResourceServerScopeRequest : TeaModel {
        /// <summary>
        /// <para>IDaaS的应用资源ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
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
        /// <para>IDaaS EIAM实例的ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>权限名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>读取全部用户</para>
        /// </summary>
        [NameInMap("ResourceServerScopeName")]
        [Validation(Required=false)]
        public string ResourceServerScopeName { get; set; }

        /// <summary>
        /// <para>权限类型</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>urn:alibaba:idaas:resourceserver:scope:delegated</para>
        /// </summary>
        [NameInMap("ResourceServerScopeType")]
        [Validation(Required=false)]
        public string ResourceServerScopeType { get; set; }

        /// <summary>
        /// <para>权限值，大小写不敏感，格式(${ResourceType}:${ResourceOption}:${ResourceRestrict})</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User:Read:ALL</para>
        /// </summary>
        [NameInMap("ResourceServerScopeValue")]
        [Validation(Required=false)]
        public string ResourceServerScopeValue { get; set; }

    }

}
