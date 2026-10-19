// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetMemoryAutoExtractionSwitchRequest : TeaModel {
        /// <summary>
        /// <para>写作协作空间 ID；ownerType 为 group 时必填，且当前鉴权用户须为该空间的活跃成员；ownerType 为 user 时不传</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_12345</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>记忆归属范围；user 为当前鉴权用户的个人记忆，group 为指定写作协作空间的记忆；不传时默认为 user</para>
        /// 
        /// <b>Example:</b>
        /// <para>group</para>
        /// </summary>
        [NameInMap("ownerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        /// <summary>
        /// <para>租户 ID，查询参数；不传时使用调用方的默认租户</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
