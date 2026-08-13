// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateKnowledgeBaseDirectoryRequest : TeaModel {
        /// <summary>
        /// <para>分类描述（可选）</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>分类名称（企业知识库目录名称）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例名称.pdf</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>父分类 ID；不传时新分类挂在企业知识库根目录下，传入时必须是当前租户下已存在的企业知识库目录 ID</para>
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
