// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreatePersonalDirectoryRequest : TeaModel {
        /// <summary>
        /// <para>目录描述（可选）</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>目录名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例名称.pdf</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>数字员工名称（已废弃：不再作为个人资源隔离条件，仅保留用于来源追溯）</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("operatingObjectName")]
        [Validation(Required=false)]
        public string OperatingObjectName { get; set; }

        /// <summary>
        /// <para>父目录 ID；不传时新目录挂在用户的默认根目录下，传入时必须是当前用户的已有个人目录</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleParentDirectoryId</para>
        /// </summary>
        [NameInMap("parentDirectoryId")]
        [Validation(Required=false)]
        public string ParentDirectoryId { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数；winnexo-cli 通过 --tenant-id 显式传入</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
