// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateResourceServerScopeRequest : TeaModel {
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
        /// <para>ResourceServer下Scope唯一标识。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ress_neg35flu6byysxwutaxu3dxxxx</para>
        /// </summary>
        [NameInMap("ResourceServerScopeId")]
        [Validation(Required=false)]
        public string ResourceServerScopeId { get; set; }

        /// <summary>
        /// <para>权限名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Read All User</para>
        /// </summary>
        [NameInMap("ResourceServerScopeName")]
        [Validation(Required=false)]
        public string ResourceServerScopeName { get; set; }

    }

}
