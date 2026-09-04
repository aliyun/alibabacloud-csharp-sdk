// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLProgressFatal : TeaModel {
        /// <summary>
        /// <para>锚点行 agent_collect_time（纳秒字符串，超 JS 安全整数）</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487713456789</para>
        /// </summary>
        [NameInMap("CollectNs")]
        [Validation(Required=false)]
        public string CollectNs { get; set; }

        /// <summary>
        /// <para>错误文案（截断至 500 字符）</para>
        /// 
        /// <b>Example:</b>
        /// <para>CUDA out of memory. Tried to allocate 2.00 GiB</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>原始日志行（截断至 2000 字符）；调用 GetRLLogContext 时作为 AnchorMessage 传入</para>
        /// 
        /// <b>Example:</b>
        /// <para>[rank0]: torch.OutOfMemoryError: CUDA out of memory. Tried to allocate 2.00 GiB</para>
        /// </summary>
        [NameInMap("RawMessage")]
        [Validation(Required=false)]
        public string RawMessage { get; set; }

        /// <summary>
        /// <para>同秒内的纳秒偏移，用于同秒日志排序</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("SubsecNs")]
        [Validation(Required=false)]
        public long? SubsecNs { get; set; }

        /// <summary>
        /// <para>日志时间（unix 秒）</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

    }

}
