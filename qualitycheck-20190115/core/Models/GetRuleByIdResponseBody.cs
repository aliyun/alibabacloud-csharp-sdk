// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetRuleByIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success. Other values indicate an error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The detailed information about the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RulesInfo Data { get; set; }

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
        /// <para>The returned message. A value of successful is returned on success, and an error message is returned on failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Details about the error. This parameter is used when multiple messages are returned.</para>
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<string> Messages { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3CEA0495-341B-4482-9AD9-8191EF4***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. A value of true indicates success, and false or null indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
