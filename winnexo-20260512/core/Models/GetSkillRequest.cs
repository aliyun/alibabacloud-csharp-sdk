// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetSkillRequest : TeaModel {
        /// <summary>
        /// <para>是否返回完整文件树（默认 False，避免大体积响应）</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("includeSkillFiles")]
        [Validation(Required=false)]
        public bool? IncludeSkillFiles { get; set; }

        /// <summary>
        /// <para>技能编码（全局唯一），优先级高于 skillName</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("skillCode")]
        [Validation(Required=false)]
        public string SkillCode { get; set; }

        /// <summary>
        /// <para>技能名称，未传 skillCode 时使用；租户范围内必须唯一</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("skillName")]
        [Validation(Required=false)]
        public string SkillName { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数，缺省时使用调用方默认租户</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>视角：draft（草稿/编辑视角）或 published（已发布视角，默认）</para>
        /// 
        /// <b>Example:</b>
        /// <para>draft</para>
        /// </summary>
        [NameInMap("viewMode")]
        [Validation(Required=false)]
        public string ViewMode { get; set; }

    }

}
