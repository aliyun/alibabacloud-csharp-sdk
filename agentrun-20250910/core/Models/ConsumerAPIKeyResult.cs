// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ConsumerAPIKeyResult : TeaModel {
        /// <summary>
        /// <para><c>SUCCESS</c> indicates that the request was successful. If the request fails, this field returns an error type, such as <c>ERR_BAD_REQUEST</c>, <c>ERR_VALIDATION_FAILED</c>, or <c>ERR_INTERNAL_SERVER_ERROR</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Details of the consumer API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ConsumerAPIKey Data { get; set; }

        /// <summary>
        /// <para>A unique request ID for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8A0F5F3-0C3E-4C82-9D4F-5E4B6A7C8D9E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
