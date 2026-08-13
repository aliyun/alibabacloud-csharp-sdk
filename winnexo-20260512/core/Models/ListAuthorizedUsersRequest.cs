// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListAuthorizedUsersRequest : TeaModel {
        /// <summary>
        /// <para>筛选类型：USER / USER_GROUP / 不传则返回全部</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("granteeType")]
        [Validation(Required=false)]
        public string GranteeType { get; set; }

        /// <summary>
        /// <para>搜索关键词，按用户名或组名模糊匹配</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例关键词</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>数字员工名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("operatingObjectName")]
        [Validation(Required=false)]
        public string OperatingObjectName { get; set; }

        /// <summary>
        /// <para>权限类型过滤：USE=使用权限 / MANAGE=管理权限</para>
        /// 
        /// <b>Example:</b>
        /// <para>USE</para>
        /// </summary>
        [NameInMap("permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数，缺省时使用调用方默认租户</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
