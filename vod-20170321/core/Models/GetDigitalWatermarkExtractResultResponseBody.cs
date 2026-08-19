// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetDigitalWatermarkExtractResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the watermark extraction jobs.</para>
        /// </summary>
        [NameInMap("AiExtractResultList")]
        [Validation(Required=false)]
        public List<GetDigitalWatermarkExtractResultResponseBodyAiExtractResultList> AiExtractResultList { get; set; }
        public class GetDigitalWatermarkExtractResultResponseBodyAiExtractResultList : TeaModel {
            /// <summary>
            /// <para>The time when the watermark extraction job was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-16T02:49:04Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error message. This parameter is returned only when the watermark extraction job fails (the value of <c>Status</c> is <c>Failed</c>).</para>
            /// 
            /// <b>Example:</b>
            /// <para>query copyright info err</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The ID of the watermark extraction job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3af004763bcf459698860f4ede20****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The time when the watermark extraction job was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-17T06:20:45Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The status of the watermark extraction job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Success</b>: The job succeeded.	</description></item>
            /// <item><description><b>Failed</b>: The job failed.</description></item>
            /// <item><description><b>Processing</b>: The job is being processed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Failed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The extracted watermark text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test mark</para>
            /// </summary>
            [NameInMap("WaterMarkText")]
            [Validation(Required=false)]
            public string WaterMarkText { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42E0554B-80F4-4921-****-ACFB22CAAAD0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
