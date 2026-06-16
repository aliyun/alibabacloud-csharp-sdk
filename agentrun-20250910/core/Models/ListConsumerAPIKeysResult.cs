// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListConsumerAPIKeysResult : TeaModel {
        /// <summary>
        /// <para>The request status. <c>SUCCESS</c> indicates that the request was successful. Otherwise, this field returns the error type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of consumer API keys.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListConsumerAPIKeysOutput Data { get; set; }

        /// <summary>
        /// <para>The unique request ID. Use this ID for issue tracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8A0F5F3-0C3E-4C82-9D4F-5E4B6A7C8D9E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
