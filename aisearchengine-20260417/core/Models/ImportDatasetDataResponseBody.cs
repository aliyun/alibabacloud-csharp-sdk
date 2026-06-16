// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiSearchEngine20260417.Models
{
    public class ImportDatasetDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates a successful request. Other values indicate exceptions. For more information, see error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data body, which uses an empty placeholder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// <para>The status description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique request ID, used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a0f40dd17774641794394269ec0e9</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
