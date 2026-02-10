// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PolardbAI20251013.Models
{
    public class UpdateMultimodalLabelStudioServiceWhiteListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>模型相关信息
        /// 返回示例：
        /// {
        ///   &quot;Data&quot;: {
        ///     &quot;Items&quot;: [
        ///       {
        ///         &quot;Model&quot;: &quot;MultiModal-Embedding&quot;
        ///       }
        ///     ]
        ///   },
        ///   &quot;RequestId&quot;: &quot;7A53B3C8-2228-1478-9D12-B4C219369540&quot;,
        ///   &quot;Success&quot;: true
        /// }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>错误码</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>错误信息</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>983863E2-****-1D15-A4AE-3468CD75383D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
