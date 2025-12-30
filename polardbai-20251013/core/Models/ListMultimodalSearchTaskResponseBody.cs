// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PolardbAI20251013.Models
{
    public class ListMultimodalSearchTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>模型相关信息</para>
        /// <para>{
        ///   &quot;Data&quot;: {
        ///     &quot;PageSize&quot;: 1,
        ///     &quot;PageNumber&quot;: 1,
        ///     &quot;Total&quot;: 12,
        ///     &quot;Items&quot;: [
        ///       {
        ///         &quot;Status&quot;: &quot;Running&quot;,
        ///         &quot;ProcessBatch&quot;: 0,
        ///         &quot;TotalBatch&quot;: 0,
        ///         &quot;EndTime&quot;: &quot;&quot;,
        ///         &quot;CreateTime&quot;: &quot;2025-12-25T20:38:35&quot;,
        ///         &quot;Id&quot;: &quot;dd84065b-eb46-4c7b-abb0-0d633ec811d7&quot;,
        ///         &quot;SuccessBatch&quot;: 0,
        ///         &quot;Query&quot; : &quot;油漆桶&quot;,
        ///         &quot;DatasetIds&quot;: [&quot;ds-1&quot;, &quot;ds-2&quot;]
        ///       }
        ///     ]
        ///   },
        ///   &quot;RequestId&quot;: &quot;849E84DB-*****-9D734&quot;,
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
