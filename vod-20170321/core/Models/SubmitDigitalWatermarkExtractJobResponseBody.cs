// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitDigitalWatermarkExtractJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the watermark extraction job. This ID can be used as a request parameter of the <a href="https://help.aliyun.com/document_detail/2587769.html">GetDigitalWatermarkExtractResult</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ad90a501b1b9472374ad005046****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-****-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
