// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class ReadPageScrapeResponseBody : TeaModel {
        /// <summary>
        /// <para>Parsing result of the target URL</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ReadPageItem Data { get; set; }

        /// <summary>
        /// <para>error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Request ID. Provide this information when troubleshooting issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7cd43c86-731a-4d4c-8385-d070cfc509a4</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
