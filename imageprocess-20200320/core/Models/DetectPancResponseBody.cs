// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectPancResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectPancResponseBodyData Data { get; set; }
        public class DetectPancResponseBodyData : TeaModel {
            [NameInMap("Lesion")]
            [Validation(Required=false)]
            public DetectPancResponseBodyDataLesion Lesion { get; set; }
            public class DetectPancResponseBodyDataLesion : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/screen-pdac/2022-05-25_14%3A33%3A30/4CA2BF25-BCDB-9C6C-B14C-EB41E8266588.nii.gz?Expires=1653462210&OSSAccessKeyId=LTAI4FoLmvQ9urWXgSR****&Signature=8t%2FknUrQyyyCU2p7QhMC%2BXBCR">http://vibktprfx-prod-prod-aic-med-cn-shanghai.oss-cn-shanghai.aliyuncs.com/screen-pdac/2022-05-25_14%3A33%3A30/4CA2BF25-BCDB-9C6C-B14C-EB41E8266588.nii.gz?Expires=1653462210&amp;OSSAccessKeyId=LTAI4FoLmvQ9urWXgSR****&amp;Signature=8t%2FknUrQyyyCU2p7QhMC%2BXBCR</a>****</para>
                /// </summary>
                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NonPdacVol")]
                [Validation(Required=false)]
                public string NonPdacVol { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PancVol")]
                [Validation(Required=false)]
                public string PancVol { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PdacVol")]
                [Validation(Required=false)]
                public string PdacVol { get; set; }

                [NameInMap("Possibilities")]
                [Validation(Required=false)]
                public List<string> Possibilities { get; set; }

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
        /// <para>CA1C672A-4F85-1CD9-893D-3434C924C4B2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
