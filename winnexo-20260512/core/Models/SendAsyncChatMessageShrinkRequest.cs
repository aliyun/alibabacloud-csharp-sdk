// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SendAsyncChatMessageShrinkRequest : TeaModel {
        /// <summary>
        /// <para>用户消息正文</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例内容</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>消息类型：Text / Markdown</para>
        /// 
        /// <b>Example:</b>
        /// <para>Text</para>
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>数字员工名称列表（兼容旧格式可传单个字符串）</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("digitalEmployeeName")]
        [Validation(Required=false)]
        public string DigitalEmployeeNameShrink { get; set; }

        /// <summary>
        /// <para>是否启用直连模式；true 时跳过常规场景路由，直接进入直连对话场景</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("directChat")]
        [Validation(Required=false)]
        public bool? DirectChat { get; set; }

        /// <summary>
        /// <para>文件引用列表；每项为对象，fileId 必传（由 uploadChatFile 返回）</para>
        /// </summary>
        [NameInMap("files")]
        [Validation(Required=false)]
        public string FilesShrink { get; set; }

        /// <summary>
        /// <para>抽象模型档位（quick / standard / flagship）；缺省时新会话用 standard，已有会话沿用会话当前档位</para>
        /// 
        /// <b>Example:</b>
        /// <para>quick</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>不传 sessionId 时是否复用该数字员工下最近一个会话（CLI 场景），缺省 false 即新建会话</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("reuseLastSession")]
        [Validation(Required=false)]
        public bool? ReuseLastSession { get; set; }

        /// <summary>
        /// <para>会话ID，不传则新建会话</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSessionId</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>是否流式生成；本接口固定按流式生成后台内容并写入消息流，取值不改变返回结构</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// <para>executeScheduledTask 返回的任务执行元数据；传入后按任务执行链路处理</para>
        /// </summary>
        [NameInMap("taskExecution")]
        [Validation(Required=false)]
        public string TaskExecutionShrink { get; set; }

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
