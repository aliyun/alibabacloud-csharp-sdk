// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UpdateQualityCheckSchemeResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success. Other values indicate failure. Use this field to determine the cause of a failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error details if the request fails. If the request is successful, the value is \<c>successful\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Messages")]
        [Validation(Required=false)]
        public UpdateQualityCheckSchemeResponseBodyMessages Messages { get; set; }
        public class UpdateQualityCheckSchemeResponseBodyMessages : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public List<string> Message { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96138D8D-8D26-4E41-BFF4-77AED1088BBD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. A value of \<c>true\\</c> indicates success. A value of \<c>false\\</c> or \<c>null\\</c> indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
