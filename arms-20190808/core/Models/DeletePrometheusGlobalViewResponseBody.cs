// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeletePrometheusGlobalViewResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. The status code 200 indicates a successful request, whereas others indicate a failed request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response parameters in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Success&quot;:true,&quot;Msg&quot;:&quot;OK&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The supplemental message providing additional context about the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>337B8F7E-0A64-5768-9225-E9B3CF******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
