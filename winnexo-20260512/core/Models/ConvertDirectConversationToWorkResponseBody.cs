// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ConvertDirectConversationToWorkResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The session conversion record ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleConversionId</para>
        /// </summary>
        [NameInMap("conversionId")]
        [Validation(Required=false)]
        public string ConversionId { get; set; }

        /// <summary>
        /// <para>The number of converted conversation turns.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("convertedRounds")]
        [Validation(Required=false)]
        public int? ConvertedRounds { get; set; }

        /// <summary>
        /// <para>The scope of the converted historical messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>direct</para>
        /// </summary>
        [NameInMap("historyScope")]
        [Validation(Required=false)]
        public string HistoryScope { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specifies whether retries are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("retryable")]
        [Validation(Required=false)]
        public bool? Retryable { get; set; }

        /// <summary>
        /// <para>The source session version identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("sourceEpoch")]
        [Validation(Required=false)]
        public long? SourceEpoch { get; set; }

        /// <summary>
        /// <para>The source session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSourceSessionId</para>
        /// </summary>
        [NameInMap("sourceSessionId")]
        [Validation(Required=false)]
        public string SourceSessionId { get; set; }

        /// <summary>
        /// <para>The conversion status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>succeeded</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The target work session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleTargetSessionId</para>
        /// </summary>
        [NameInMap("targetSessionId")]
        [Validation(Required=false)]
        public string TargetSessionId { get; set; }

        /// <summary>
        /// <para>The cutoff message sequence number for the conversion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("throughSequence")]
        [Validation(Required=false)]
        public long? ThroughSequence { get; set; }

        /// <summary>
        /// <para>The work session mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>work</para>
        /// </summary>
        [NameInMap("workMode")]
        [Validation(Required=false)]
        public string WorkMode { get; set; }

    }

}
