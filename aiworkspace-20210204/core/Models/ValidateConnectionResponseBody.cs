// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ValidateConnectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned when the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the validation result.</para>
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public Dictionary<string, string> Details { get; set; }

        /// <summary>
        /// <para>The description of the validation result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The connection is reachable.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A14FA81-DD4E-******-6343FE44B941</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the validation result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>success: The validation succeeded.</description></item>
        /// <item><description>failed: The validation failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
