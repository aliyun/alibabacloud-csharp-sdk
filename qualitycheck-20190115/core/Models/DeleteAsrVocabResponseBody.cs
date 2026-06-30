// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class DeleteAsrVocabResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> means success. Any other value means failure. Use this field to identify the cause of failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The hotword ID you specified as vocabId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>71b1795ac8634bd8bdf4d3878480c7c2</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>Details about the error if the request fails. If the request succeeds, the value is <b>successful</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4987D326-83D9-4A42-B9A5-0B27F9B40539</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. Use this field to check the result:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b> means success.</para>
        /// </description></item>
        /// <item><description><para>false or <b>null</b> means failure.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
