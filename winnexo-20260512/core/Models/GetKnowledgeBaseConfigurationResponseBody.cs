// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetKnowledgeBaseConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>是否开启后续内容更新的 AI 版本摘要</para>
        /// </summary>
        [NameInMap("changeRecordEnabled")]
        [Validation(Required=false)]
        public bool? ChangeRecordEnabled { get; set; }

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
        /// <para>企业知识库根目录 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-example</para>
        /// </summary>
        [NameInMap("directoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>错误描述，成功时为 success</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>数字员工可见模式；历史未显式设置 ALL 的配置按 SPECIFIED 返回</para>
        /// 
        /// <b>Example:</b>
        /// <para>SPECIFIED</para>
        /// </summary>
        [NameInMap("ooVisibilityMode")]
        [Validation(Required=false)]
        public string OoVisibilityMode { get; set; }

        /// <summary>
        /// <para>显式关联的数字员工名称；ALL 返回空数组，SPECIFIED 空数组表示没有关联员工</para>
        /// </summary>
        [NameInMap("operatingObjectNames")]
        [Validation(Required=false)]
        public List<string> OperatingObjectNames { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
