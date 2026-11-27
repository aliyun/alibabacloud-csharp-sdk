// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetRLLogContextRequest : TeaModel {
        /// <summary>
        /// <para>用于辅助定位的锚点日志消息，可取自 GetRLTrainingProgress 返回的 Fatal[].RawMessage。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[rank0]: torch.OutOfMemoryError: CUDA out of memory. Tried to allocate 2.00 GiB</para>
        /// </summary>
        [NameInMap("AnchorMessage")]
        [Validation(Required=false)]
        public string AnchorMessage { get; set; }

        /// <summary>
        /// <para>锚点日志行的时间，采用 RFC3339 格式。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-05T16:36:55Z</para>
        /// </summary>
        [NameInMap("AnchorTime")]
        [Validation(Required=false)]
        public string AnchorTime { get; set; }

        /// <summary>
        /// <para>锚点日志采集时间，采用纯数字的纳秒时间戳字符串，可取自 GetRLTrainingProgress 返回的 Fatal[].CollectNs，用于辅助定位上下文。实际定位方式由 Mode 返回，结果不保证包含原始锚点日志。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1785947815190122847</para>
        /// </summary>
        [NameInMap("CollectTime")]
        [Validation(Required=false)]
        public string CollectTime { get; set; }

    }

}
