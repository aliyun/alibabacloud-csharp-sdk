// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class KillJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. If this parameter was not empty and the value of this parameter was not 200, the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0abb7ede16814560741256732e91b6</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
