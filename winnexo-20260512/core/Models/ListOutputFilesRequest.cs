// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListOutputFilesRequest : TeaModel {
        /// <summary>
        /// <para>精确业务编号，来自文件登记或工作流实例关联</para>
        /// 
        /// <b>Example:</b>
        /// <para>REQ-20261012-001</para>
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>可选协作空间 ID；未传保持当前用户个人产出范围</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_123e4567-e89b-42d3-a456-426614174001</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The type of the output item. Valid values: ppt, html, document, picture, slides, video, audio, email, and others.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ppt</para>
        /// </summary>
        [NameInMap("itemType")]
        [Validation(Required=false)]
        public string ItemType { get; set; }

        /// <summary>
        /// <para>The keyword for searching. Matches the output title or item name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The name of the digital employee (operating object). Used to filter results by name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("operatingObjectName")]
        [Validation(Required=false)]
        public string OperatingObjectName { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>The number of items per page. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>精确会话 ID，覆盖普通会话、技能会话与任务 executionId</para>
        /// 
        /// <b>Example:</b>
        /// <para>session_123e4567-e89b-42d3-a456-426614174008</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to display only outputs and output items with sharing enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("sharedOnly")]
        [Validation(Required=false)]
        public bool? SharedOnly { get; set; }

        /// <summary>
        /// <para>全部匹配的标签列表，来自文件登记或实例 variables.tags</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. In winnexo-cli, pass it explicitly by using --tenant-id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
