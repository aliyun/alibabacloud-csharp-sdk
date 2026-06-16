// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListTemplatesResult : TeaModel {
        /// <summary>
        /// <para>A value of <c>SUCCESS</c> indicates the request was successful. On failure, this parameter returns an error type, such as <c>ERR_BAD_REQUEST</c>, <c>ERR_VALIDATION_FAILED</c>, or <c>ERR_INTERNAL_SERVER_ERROR</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Details about the template list.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListTemplatesOutput Data { get; set; }

        /// <summary>
        /// <para>A unique request ID for troubleshooting and tracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C0595DB0-D1EE-55C3-8DDD-790872C7EC2F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
