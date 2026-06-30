// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class VerifyFileResponseBody : TeaModel {
        /// <summary>
        /// <para>Result code. <b>200</b> indicates success. Other values indicate failure. Callers can determine the failure reason using this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Current detection accuracy: Number of incorrect characters in verified files / Total number of characters in verified files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.9485294</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public float? Data { get; set; }

        /// <summary>
        /// <para>Error details when an error occurs. Successful when successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>106C6CA0-282D-4AF7-85F0-D2D24F4CE647</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Callers can determine if the request was successful using this field: true indicates success; false/null indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
