// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetSkillResponseBody : TeaModel {
        [NameInMap("arguments")]
        [Validation(Required=false)]
        public List<GetSkillResponseBodyArguments> Arguments { get; set; }
        public class GetSkillResponseBodyArguments : TeaModel {
            /// <summary>
            /// <para>默认值</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("default")]
            [Validation(Required=false)]
            public string Default { get; set; }

            /// <summary>
            /// <para>参数说明</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例描述</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>enum</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("enum")]
            [Validation(Required=false)]
            public List<string> Enum { get; set; }

            /// <summary>
            /// <para>文件名</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例名称.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>是否必填</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            /// <summary>
            /// <para>参数类型: string / number / boolean / array</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>业务状态码：成功为 200，失败为后端错误码（ERR.* / InvalidParameter.*）</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>创建时间，ISO8601 格式</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-10-01T12:00:00Z</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>技能描述（已 i18n 解析）</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>技能详细逻辑</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("detailLogic")]
        [Validation(Required=false)]
        public string DetailLogic { get; set; }

        /// <summary>
        /// <para>展示名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>执行模式</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("executeMode")]
        [Validation(Required=false)]
        public string ExecuteMode { get; set; }

        /// <summary>
        /// <para>是否全局可访问</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("globalAccess")]
        [Validation(Required=false)]
        public bool? GlobalAccess { get; set; }

        /// <summary>
        /// <para>是否存在未发布的草稿修改</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasDraftChanges")]
        [Validation(Required=false)]
        public bool? HasDraftChanges { get; set; }

        /// <summary>
        /// <para>入参配置原文</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("inputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        [NameInMap("inputConfigFormatted")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> InputConfigFormatted { get; set; }

        /// <summary>
        /// <para>错误描述，成功时为空</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>文件名</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例名称.pdf</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>技能编码（全局唯一）</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("skillCode")]
        [Validation(Required=false)]
        public string SkillCode { get; set; }

        [NameInMap("skillFiles")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> SkillFiles { get; set; }

        /// <summary>
        /// <para>技能定义 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("skillHubDefinitionId")]
        [Validation(Required=false)]
        public long? SkillHubDefinitionId { get; set; }

        /// <summary>
        /// <para>SKILL.md 简介（由 LLM 生成）</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("skillMdSummary")]
        [Validation(Required=false)]
        public string SkillMdSummary { get; set; }

        /// <summary>
        /// <para>来源类型: BUILTIN / CUSTOM</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>技能状态: ACTIVE / DRAFT</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>tags</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <para>修改时间，ISO8601 格式</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-10-01T12:00:00Z</para>
        /// </summary>
        [NameInMap("updatedTime")]
        [Validation(Required=false)]
        public string UpdatedTime { get; set; }

        /// <summary>
        /// <para>版本总数</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("versionCount")]
        [Validation(Required=false)]
        public long? VersionCount { get; set; }

        /// <summary>
        /// <para>版本号</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("versionNumber")]
        [Validation(Required=false)]
        public string VersionNumber { get; set; }

    }

}
