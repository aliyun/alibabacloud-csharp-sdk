// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLJobSettings : TeaModel {
        /// <summary>
        /// <para>沿用 DLC 的高级设置键值约定；运行时值须为字符串且键不能为空，具体选项是否生效取决于运行环境支持。</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;EnableDinD&quot;:&quot;true&quot;}</para>
        /// </summary>
        [NameInMap("AdvancedSettings")]
        [Validation(Required=false)]
        public Dictionary<string, object> AdvancedSettings { get; set; }

        /// <summary>
        /// <para>作业关联用户 ID，沿用 DLC 的受信调用方规则。</para>
        /// 
        /// <b>Example:</b>
        /// <para>166924</para>
        /// </summary>
        [NameInMap("BusinessUserId")]
        [Validation(Required=false)]
        public string BusinessUserId { get; set; }

        /// <summary>
        /// <para>调用方标识，与 DLC Settings.Caller 一致。</para>
        /// 
        /// <b>Example:</b>
        /// <para>pai-cli</para>
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        /// <summary>
        /// <para>沿用 DLC 的 RDMA 配置，是否生效取决于配额和运行环境。</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableRDMA")]
        [Validation(Required=false)]
        public bool? EnableRDMA { get; set; }

        /// <summary>
        /// <para>工作流 ID，与 DLC Settings.PipelineId 一致。</para>
        /// 
        /// <b>Example:</b>
        /// <para>pid-123456</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>DLC 作业标签，场景使用 rls.scene。</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;rls.scene&quot;:&quot;code-rl&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

    }

}
