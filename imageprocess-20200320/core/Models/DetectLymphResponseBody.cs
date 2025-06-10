// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectLymphResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectLymphResponseBodyData Data { get; set; }
        public class DetectLymphResponseBodyData : TeaModel {
            [NameInMap("Lesions")]
            [Validation(Required=false)]
            public List<DetectLymphResponseBodyDataLesions> Lesions { get; set; }
            public class DetectLymphResponseBodyDataLesions : TeaModel {
                [NameInMap("Boxes")]
                [Validation(Required=false)]
                public List<float?> Boxes { get; set; }

                [NameInMap("Diametermm")]
                [Validation(Required=false)]
                public List<float?> Diametermm { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("KeySlice")]
                [Validation(Required=false)]
                public long? KeySlice { get; set; }

                [NameInMap("Recist")]
                [Validation(Required=false)]
                public List<List<float?>> Recist { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.6298</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

            }

        }

        /// <summary>
        /// <para>提交异步任务后的提示信息。</para>
        /// 
        /// <b>Example:</b>
        /// <para>该调用为异步调用，任务已提交成功，请以requestId的值作为jobId参数调用同类目下GetAsyncJobResult接口查询任务执行状态和结果。</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>59598577-13C6-12A2-8CBF-A4DA4C9280A1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
